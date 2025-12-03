using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4.Bai7
{
    public partial class FormPhu : Form
    {
        // Link API gốc
        private const string BASE_URL = "https://nt106.uitiot.vn/api/v1/monan";

        // List lưu tạm dữ liệu để dùng cho chức năng Random
        private List<DishModel> _currentList = new List<DishModel>();

        public FormPhu()
        {
            InitializeComponent();

            // Mặc định chọn chế độ xem "Tất cả"
            cbMode.SelectedIndex = 0;

            // Cấu hình bảng
            dgvDishes.AutoGenerateColumns = true;
            dgvDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Gắn sự kiện
            btnLoad.Click += async (s, e) => await LoadData();
            btnAdd.Click += async (s, e) => await AddDish();
            btnDelete.Click += async (s, e) => await DeleteDish();
            btnRandom.Click += (s, e) => PickRandomDish();
        }

        // --- Helper: Tạo HttpClient có Token ---
        private HttpClient GetClient()
        {
            var client = new HttpClient();
            string token = txtToken.Text.Trim();

            // Xóa chữ Bearer nếu user lỡ copy thừa
            if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                token = token.Substring(7).Trim();

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
            return client;
        }

        // --- Helper: Ghi log ---
        private void Log(string msg)
        {
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\n");
            rtbLog.ScrollToCaret();
        }

        // --- 1. CHỨC NĂNG LOAD DỮ LIỆU (All & My Dishes & Pagination) ---
        private async Task LoadData()
        {
            int page = (int)numPage.Value;
            int pageSize = 10; // Số lượng món mỗi trang

            // Xác định Endpoint dựa vào ComboBox
            string endpoint = (cbMode.SelectedIndex == 0) ? "/all" : "/my-dishes";
            string url = BASE_URL + endpoint;

            Log($"Đang tải dữ liệu trang {page} từ {endpoint}...");

            // Chuẩn bị Body cho phân trang
            var paginationData = new
            {
                current = page,
                pageSize = pageSize
            };

            try
            {
                using (var client = GetClient())
                {
                    // API dùng method POST để lấy danh sách (theo ảnh m gửi)
                    var content = new StringContent(JsonConvert.SerializeObject(paginationData), Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);
                    var jsonString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        // API trả về JSON. Cần xử lý xem nó là Array hay Object chứa data
                        // Theo chuẩn thường gặp của API này thì nó trả về Object có field "data"
                        List<DishModel> dishes = null;

                        if (jsonString.Trim().StartsWith("["))
                        {
                            dishes = JsonConvert.DeserializeObject<List<DishModel>>(jsonString);
                        }
                        else
                        {
                            var jObj = JObject.Parse(jsonString);
                            // Kiểm tra xem data nằm ở đâu (data, results, items...)
                            if (jObj["data"] != null)
                                dishes = jObj["data"].ToObject<List<DishModel>>();
                            else
                                dishes = new List<DishModel>(); // Không tìm thấy data
                        }

                        // Hiển thị lên DataGridView
                        _currentList = dishes;
                        dgvDishes.DataSource = dishes;
                        Log($"✅ Tải thành công {dishes.Count} món.");
                    }
                    else
                    {
                        Log($"❌ Lỗi tải ({response.StatusCode}): {jsonString}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log($"⚠️ Exception: {ex.Message}");
            }
        }

        // --- 2. CHỨC NĂNG THÊM MÓN ---
        private async Task AddDish()
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món và giá!");
                return;
            }

            var newDish = new
            {
                ten_mon_an = txtName.Text,
                gia = double.Parse(string.IsNullOrEmpty(txtPrice.Text) ? "0" : txtPrice.Text),

                // QUAN TRỌNG: Server bắt buộc phải có 'dia_chi'
                dia_chi = txtAddress.Text,

                // Vẫn gửi thêm mo_ta để đảm bảo (có thể lấy giống địa chỉ hoặc để trống)
                mo_ta = txtAddress.Text,

                hinh_anh = "https://via.placeholder.com/150" // Ảnh mẫu
            };

            Log("Đang thêm món...");
            try
            {
                using (var client = GetClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(newDish), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(BASE_URL + "/add", content);
                    var result = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        Log("✅ Thêm món thành công!");
                        // Xóa trắng các ô nhập liệu sau khi thêm
                        txtName.Clear();
                        txtPrice.Clear();
                        txtAddress.Clear();

                        await LoadData(); // Tải lại danh sách
                    }
                    else
                    {
                        // Hiển thị chi tiết lỗi từ Server trả về (JSON)
                        Log($"❌ Lỗi thêm: {result}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log($"⚠️ Exception: {ex.Message}");
            }
        }

        // --- 3. CHỨC NĂNG XÓA MÓN ---
        private async Task DeleteDish()
        {
            if (dgvDishes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!");
                return;
            }

            // Lấy ID từ dòng đang chọn
            var row = dgvDishes.SelectedRows[0];
            // Lưu ý: Tên cột ID có thể là "id", "mon_an_id" tùy API trả về. 
            // Ta dùng DishModel nên sẽ lấy property Id
            var dish = (DishModel)row.DataBoundItem;

            if (MessageBox.Show($"Bạn chắc chắn muốn xóa món '{dish.TenMonAn}'?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Log($"Đang xóa món ID: {dish.Id}...");
            try
            {
                using (var client = GetClient())
                {
                    var response = await client.DeleteAsync($"{BASE_URL}/{dish.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        Log("✅ Xóa thành công!");
                        await LoadData();
                    }
                    else
                    {
                        Log($"❌ Lỗi xóa: {await response.Content.ReadAsStringAsync()}");
                    }
                }
            }
            catch (Exception ex)
            {
                Log($"⚠️ Exception: {ex.Message}");
            }
        }

        // --- 4. CHỨC NĂNG RANDOM (ĂN GÌ GIỜ?) ---
        private void PickRandomDish()
        {
            if (_currentList == null || _currentList.Count == 0)
            {
                MessageBox.Show("Danh sách trống! Hãy tải dữ liệu trước.");
                return;
            }

            var rnd = new Random();
            int index = rnd.Next(_currentList.Count);
            var luckyDish = _currentList[index];

            // Hiển thị kết quả đẹp mắt chút
            string msg = $"🎉 HÔM NAY ĂN MÓN: {luckyDish.TenMonAn}\n" +
                         $"💰 Giá: {luckyDish.Gia}\n" +
                         $"📍 Mô tả/Địa chỉ: {luckyDish.MoTa}";

            MessageBox.Show(msg, "KẾT QUẢ RANDOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Class Model để hứng dữ liệu từ JSON
    public class DishModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ten_mon_an")]
        public string TenMonAn { get; set; }

        [JsonProperty("gia")]
        public double Gia { get; set; }

        [JsonProperty("mo_ta")]
        public string MoTa { get; set; }

        [JsonProperty("hinh_anh")]
        public string HinhAnh { get; set; }

        // Thêm field người đóng góp nếu API trả về
        [JsonProperty("nguoi_dong_gop")]
        public string NguoiDongGop { get; set; }
    }
}