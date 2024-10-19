namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ textbox
            string username = tbname.Text;
            string password = tbpassword.Text;

            // Kiểm tra thông tin đăng nhập
            if (username == "1" && password == "1")
            {
                // Nếu đúng, mở form Home
                Home home = new Home();
                home.Show();
                this.Hide(); // Ẩn form hiện tại
            }
            else
            {
                // Nếu sai, hiển thị thông báo
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
