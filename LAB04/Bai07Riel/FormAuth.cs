using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Bai7Riel
{
    public partial class FormAuth : Form
    {
        public FormAuth() { InitializeComponent(); }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var content = new MultipartFormDataContent {
                        { new StringContent(txtUser.Text), "username" },
                        { new StringContent(txtPass.Text), "password" }
                    };
                    var res = await client.PostAsync("https://nt106.uitiot.vn/auth/token", content);
                    var json = await res.Content.ReadAsStringAsync();

                    if (res.IsSuccessStatusCode)
                    {
                        AppState.Token = JObject.Parse(json)["access_token"].ToString();
                        MessageBox.Show("Đăng nhập thành công!");

                        // Mở Form Main
                        this.Hide();
                        new FormMain().ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show($"Lỗi: {json}");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var regData = new
            {
                username = txtUser.Text,
                email = txtUser.Text + "@gmail.com",
                password = txtPass.Text,
                first_name = "User",
                last_name = "New",
                phone = "0999999999",
                dob = "2000-01-01"
            };
            try
            {
                using (var client = new HttpClient())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(regData), Encoding.UTF8, "application/json");
                    var res = await client.PostAsync("https://nt106.uitiot.vn/api/v1/user/signup", content);
                    if (res.IsSuccessStatusCode) MessageBox.Show("Đăng ký thành công! Hãy đăng nhập.");
                    else MessageBox.Show("Đăng ký thất bại: " + await res.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

    }
}