using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lab4.Bai7
{
    public partial class Form7 : Form
    {
        // URL GỐC CHUẨN (Dựa trên ảnh m gửi)
        private const string BASE_URL = "https://nt106.uitiot.vn/api/v1/monan";

        public Form7()
        {
            InitializeComponent();

            // Cấu hình DataGridView
            dgvDishes.AutoGenerateColumns = true;
            dgvDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Gắn sự kiện click
            btnGetDishes.Click += async (s, e) => await GetDishesAsync();
            btnAdd.Click += async (s, e) => await CreateDishAsync();
            btnUpdate.Click += async (s, e) => await UpdateDishAsync();
            btnDelete.Click += async (s, e) => await DeleteDishAsync();

            // Sự kiện click vào bảng để lấy dữ liệu lên TextBox
            dgvDishes.CellClick += DgvDishes_CellClick;
        }

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            string token = txtToken.Text.Trim();
            if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase)) token = token.Substring(7).Trim();

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return client;
        }

        private void ShowResponse(string title, HttpResponseMessage response, string content)
        {
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var json = JToken.Parse(content);
                    rtbResult.Text = $"✅ {title} THÀNH CÔNG!\n\n{json.ToString(Formatting.Indented)}";
                }
                catch
                {
                    rtbResult.Text = $"✅ {title} THÀNH CÔNG!\n\n{content}";
                }
            }
            else
            {
                string errorMsg = content.Trim().StartsWith("<") ? "Lỗi HTML từ Server (Check URL/Token)" : content;
                rtbResult.Text = $"❌ {title} THẤT BẠI (HTTP {response.StatusCode})\n\nChi tiết: {errorMsg}";
            }
        }

        private void DgvDishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDishes.Rows.Count)
            {
                var row = dgvDishes.Rows[e.RowIndex];
                // Lưu ý: Kiểm tra tên cột trong API trả về (có thể là mon_an_id, ten_mon_an, v.v. hoặc id, name)
                // Tạm thời để mặc định id/name, nếu ko hiện thì m phải xem JSON trả về để sửa tên cột
                txtDishID.Text = row.Cells["id"].Value?.ToString() ?? row.Cells["mon_an_id"]?.Value?.ToString() ?? "";
                txtDishName.Text = row.Cells["name"].Value?.ToString() ?? row.Cells["ten_mon_an"]?.Value?.ToString() ?? "";
                txtPrice.Text = row.Cells["price"].Value?.ToString() ?? row.Cells["gia"]?.Value?.ToString() ?? "0";
                txtDescription.Text = row.Cells["description"].Value?.ToString() ?? row.Cells["mo_ta"]?.Value?.ToString() ?? "";
            }
        }

        // ==========================================
        // 1. GET LIST: Theo ảnh là POST /api/v1/monan/all
        // ==========================================
        private async Task GetDishesAsync()
        {
            rtbResult.Text = "Đang lấy danh sách (POST /all)...";
            dgvDishes.DataSource = null;

            try
            {
                using (var client = GetHttpClient())
                {
                    // API này yêu cầu POST vào /all để lấy danh sách
                    string url = $"{BASE_URL}/all";

                    // Body rỗng (hoặc có thể cần pagination nếu API yêu cầu)
                    var content = new StringContent("{}", Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        // Xử lý hiển thị lên lưới
                        // Cần check xem API trả về mảng [] hay object {"data": []}
                        if (responseString.Trim().StartsWith("["))
                        {
                            dgvDishes.DataSource = JsonConvert.DeserializeObject<List<DishModel>>(responseString);
                        }
                        else
                        {
                            JObject obj = JObject.Parse(responseString);
                            if (obj["data"] != null) dgvDishes.DataSource = obj["data"].ToObject<List<DishModel>>();
                            else dgvDishes.DataSource = new List<object> { JsonConvert.DeserializeObject(responseString) };
                        }
                        ShowResponse("LẤY DANH SÁCH", response, responseString);
                    }
                    else
                    {
                        ShowResponse("LẤY DANH SÁCH", response, responseString);
                    }
                }
            }
            catch (Exception ex)
            {
                rtbResult.Text = $"⚠️ Lỗi: {ex.Message}";
            }
        }

        // ==========================================
        // 2. CREATE: Theo ảnh là POST /api/v1/monan/add
        // ==========================================
        private async Task CreateDishAsync()
        {
            rtbResult.Text = "Đang thêm món (POST /add)...";

            // Lưu ý: Kiểm tra xem API cần "name" hay "ten_mon_an"
            // T viết theo chuẩn chung, nếu lỗi m báo t sửa key json
            var dish = new
            {
                name = txtDishName.Text,
                price = int.Parse(txtPrice.Text),
                description = txtDescription.Text,
                image = "https://via.placeholder.com/150"
            };

            string jsonBody = JsonConvert.SerializeObject(dish);

            try
            {
                using (var client = GetHttpClient())
                {
                    string url = $"{BASE_URL}/add"; // Endpoint add
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    ShowResponse("THÊM MÓN", response, responseString);
                    if (response.IsSuccessStatusCode) await GetDishesAsync();
                }
            }
            catch (Exception ex)
            {
                rtbResult.Text = $"⚠️ Lỗi: {ex.Message}";
            }
        }

        // ==========================================
        // 3. UPDATE: PUT /api/v1/monan/{id}
        // ==========================================
        private async Task UpdateDishAsync()
        {
            string id = txtDishID.Text;
            if (string.IsNullOrEmpty(id)) { MessageBox.Show("Chưa có ID!"); return; }

            rtbResult.Text = $"Đang cập nhật món ID {id}...";

            var dish = new
            {
                name = txtDishName.Text,
                price = int.Parse(txtPrice.Text),
                description = txtDescription.Text,
                image = "https://via.placeholder.com/150"
            };

            string jsonBody = JsonConvert.SerializeObject(dish);

            try
            {
                using (var client = GetHttpClient())
                {
                    string url = $"{BASE_URL}/{id}"; // Endpoint update theo ID
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync(url, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    ShowResponse("CẬP NHẬT", response, responseString);
                    if (response.IsSuccessStatusCode) await GetDishesAsync();
                }
            }
            catch (Exception ex)
            {
                rtbResult.Text = $"⚠️ Lỗi: {ex.Message}";
            }
        }

        // ==========================================
        // 4. DELETE: DELETE /api/v1/monan/{id}
        // ==========================================
        private async Task DeleteDishAsync()
        {
            string id = txtDishID.Text;
            if (string.IsNullOrEmpty(id)) { MessageBox.Show("Chưa có ID!"); return; }

            rtbResult.Text = $"Đang xóa món ID {id}...";

            try
            {
                using (var client = GetHttpClient())
                {
                    string url = $"{BASE_URL}/{id}";
                    HttpResponseMessage response = await client.DeleteAsync(url);
                    string responseString = await response.Content.ReadAsStringAsync();

                    ShowResponse("XÓA MÓN", response, responseString);
                    if (response.IsSuccessStatusCode)
                    {
                        txtDishID.Text = "";
                        await GetDishesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                rtbResult.Text = $"⚠️ Lỗi: {ex.Message}";
            }
        }

        // Class Model để hứng dữ liệu (T thêm cả tiếng Việt và Anh phòng hờ)
        public class DishModel
        {
            // Các trường có thể API trả về (Mapping)
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("mon_an_id")] // Phòng hờ API trả về field này
            public string MonAnId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("ten_mon_an")] // Phòng hờ
            public string TenMonAn { get; set; }

            [JsonProperty("price")]
            public int Price { get; set; }

            [JsonProperty("gia")] // Phòng hờ
            public int Gia { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("mo_ta")] // Phòng hờ
            public string MoTa { get; set; }
        }
    }
}