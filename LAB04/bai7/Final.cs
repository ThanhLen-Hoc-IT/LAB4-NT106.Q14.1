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

namespace Lab4.Bai7.Final
{
    public partial class Final : Form
    {
        // Các đường dẫn API
        private const string BASE_URL = "https://nt106.uitiot.vn/api/v1/monan";
        private const string AUTH_URL = "https://nt106.uitiot.vn/auth/token";

        // Danh sách tạm trong RAM để Random
        private List<DishModel> _currentList = new List<DishModel>();

        public Final()
        {
            InitializeComponent();

            // Cấu hình ban đầu
            cbMode.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            dgvDishes.AutoGenerateColumns = true;
            dgvDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // --- GẮN SỰ KIỆN ---
            // 1. Sự kiện Đăng nhập
            btnLogin.Click += async (s, e) => await HandleLogin();

            // 2. Sự kiện đổi trang hoặc đổi chế độ xem -> Tự động tải lại
            numPage.ValueChanged += async (s, e) => await LoadData();
            cbMode.SelectedIndexChanged += async (s, e) => await LoadData();

            // 3. Các nút chức năng
            btnAdd.Click += async (s, e) => await AddDish();
            btnDelete.Click += async (s, e) => await DeleteDish();
            btnRandom.Click += (s, e) => PickRandomDish();

            // 4. Sự kiện chọn dòng để xem ảnh
            dgvDishes.CellClick += DgvDishes_CellClick;
        }

        // --- Helper: Ghi log ---
        private void Log(string msg)
        {
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\n");
            rtbLog.ScrollToCaret();
        }

        // --- Helper: Lấy HttpClient có Token ---
        private HttpClient GetClient()
        {
            var client = new HttpClient();
            string token = txtToken.Text.Trim();
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return client;
        }

        // ==========================================
        // CHỨC NĂNG 1: ĐĂNG NHẬP (Lấy Token)
        // ==========================================
        private async Task HandleLogin()
        {
            Log("Đang đăng nhập...");
            try
            {
                using (var client = new HttpClient())
                {
                    var content = new MultipartFormDataContent
                    {
                        { new StringContent(txtUsername.Text), "username" },
                        { new StringContent(txtPassword.Text), "password" }
                    };

                    var response = await client.PostAsync(AUTH_URL, content);
                    var json = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var jObj = JObject.Parse(json);
                        string token = jObj["access_token"].ToString();
                        txtToken.Text = token; // Tự động điền Token
                        Log("✅ Đăng nhập thành công! Đã lấy Token.");

                        // Tự động tải dữ liệu luôn cho tiện
                        await LoadData();
                    }
                    else
                    {
                        Log($"❌ Đăng nhập thất bại: {json}");
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { Log($"⚠️ Lỗi: {ex.Message}"); }
        }

        // ==========================================
        // CHỨC NĂNG 2: TẢI DANH SÁCH (Phân trang & Lọc)
        // ==========================================
        private async Task LoadData()
        {
            if (string.IsNullOrEmpty(txtToken.Text)) return; // Chưa có token thì thôi

            int page = (int)numPage.Value;
            int pageSize = 10;
            string endpoint = (cbMode.SelectedIndex == 0) ? "/all" : "/my-dishes";
            string url = BASE_URL + endpoint;

            Log($"Đang tải trang {page} ({cbMode.Text})...");

            var paginationData = new { current = page, pageSize = pageSize };

            try
            {
                using (var client = GetClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(paginationData), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);
                    var jsonString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        List<DishModel> dishes = null;
                        if (jsonString.Trim().StartsWith("["))
                            dishes = JsonConvert.DeserializeObject<List<DishModel>>(jsonString);
                        else
                        {
                            var jObj = JObject.Parse(jsonString);
                            if (jObj["data"] != null) dishes = jObj["data"].ToObject<List<DishModel>>();
                            else dishes = new List<DishModel>();
                        }

                        _currentList = dishes;
                        dgvDishes.DataSource = dishes;
                        Log($"✅ Tải xong {dishes.Count} món.");
                    }
                    else
                    {
                        Log($"❌ Lỗi tải: {jsonString}");
                    }
                }
            }
            catch (Exception ex) { Log($"⚠️ Lỗi: {ex.Message}"); }
        }

        // ==========================================
        // CHỨC NĂNG 3: THÊM MÓN (Kèm Địa chỉ)
        // ==========================================
        private async Task AddDish()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Nhập tên món!"); return; }

            var newDish = new
            {
                ten_mon_an = txtName.Text,
                gia = double.Parse(string.IsNullOrEmpty(txtPrice.Text) ? "0" : txtPrice.Text),
                dia_chi = txtAddress.Text, // Bắt buộc
                mo_ta = txtAddress.Text,   // Gửi kèm cho chắc
                hinh_anh = "https://via.placeholder.com/150"
            };

            Log("Đang thêm món...");
            try
            {
                using (var client = GetClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(newDish), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(BASE_URL + "/add", content);

                    if (response.IsSuccessStatusCode)
                    {
                        Log("✅ Thêm thành công!");
                        txtName.Clear(); txtPrice.Clear(); txtAddress.Clear();
                        await LoadData();
                    }
                    else
                    {
                        Log($"❌ Lỗi thêm: {await response.Content.ReadAsStringAsync()}");
                    }
                }
            }
            catch (Exception ex) { Log($"⚠️ Lỗi: {ex.Message}"); }
        }

        // ==========================================
        // CHỨC NĂNG 4: XÓA MÓN
        // ==========================================
        private async Task DeleteDish()
        {
            if (dgvDishes.SelectedRows.Count == 0) return;
            var dish = (DishModel)dgvDishes.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Xóa món '{dish.TenMonAn}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;

            Log($"Đang xóa ID {dish.Id}...");
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
                        Log($"❌ Không xóa được (Có thể không phải món của bạn): {await response.Content.ReadAsStringAsync()}");
                    }
                }
            }
            catch (Exception ex) { Log($"⚠️ Lỗi: {ex.Message}"); }
        }

        // ==========================================
        // CHỨC NĂNG 5: RANDOM (ĂN GÌ GIỜ?)
        // ==========================================
        private void PickRandomDish()
        {
            if (_currentList == null || _currentList.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            var rnd = new Random();
            var dish = _currentList[rnd.Next(_currentList.Count)];

            string msg = $"🎉 HÔM NAY ĂN: {dish.TenMonAn}\n💰 Giá: {dish.Gia}\n📍 Tại: {dish.DiaChi}";
            MessageBox.Show(msg, "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // TIỆN ÍCH: HIỂN THỊ ẢNH KHI CLICK
        // ==========================================
        private void DgvDishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var dish = (DishModel)dgvDishes.Rows[e.RowIndex].DataBoundItem;

            // Fill lại text box để lỡ muốn xóa/thêm lại
            txtName.Text = dish.TenMonAn;
            txtPrice.Text = dish.Gia.ToString();
            txtAddress.Text = dish.DiaChi;

            // Load ảnh
            if (!string.IsNullOrEmpty(dish.HinhAnh) && dish.HinhAnh.StartsWith("http"))
                pbDish.LoadAsync(dish.HinhAnh);
            else
                pbDish.Image = null;
        }
    }

    // Class Model hứng dữ liệu
    public class DishModel
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("ten_mon_an")] public string TenMonAn { get; set; }
        [JsonProperty("gia")] public double Gia { get; set; }
        [JsonProperty("mo_ta")] public string MoTa { get; set; }
        [JsonProperty("dia_chi")] public string DiaChi { get; set; } // Quan trọng
        [JsonProperty("hinh_anh")] public string HinhAnh { get; set; }
        [JsonProperty("nguoi_dong_gop")] public string NguoiDongGop { get; set; }
    }
}