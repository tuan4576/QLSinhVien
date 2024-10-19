using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Home : Form
    {
        // Khai báo danh sách sinh viên
        private List<Student> students = new List<Student>();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Xóa các mục có sẵn trong ComboBox để tránh lặp
            tbgioitinh.Items.Clear();
            cblop.Items.Clear();

            // Thêm giá trị vào ComboBox cho giới tính
            tbgioitinh.Items.Add("Nam");
            tbgioitinh.Items.Add("Nữ");
            tbgioitinh.Items.Add("Khác");

            // Thêm giá trị vào ComboBox cho lớp
            cblop.Items.Add("A");
            cblop.Items.Add("B");
            cblop.Items.Add("C");
            cblop.Items.Add("D");
            cblop.Items.Add("E");

            // Thêm dữ liệu mẫu để kiểm tra
            students.Add(new Student { masv = "1", ten = "Nguyen Van A", namsinh = 2000, gioitinh = "Nam", nganh = "CNTT", lop = "A" });

            // Gọi phương thức để khởi tạo DataGridView
            InitializeStudentGrid();
        }


        // Phương thức khởi tạo DataGridView
        private void InitializeStudentGrid()
        {
            // Tự động tạo cột dựa trên đối tượng Student
            dataGridView1.AutoGenerateColumns = true;

            // Gán dữ liệu cho DataGridView
            dataGridView1.DataSource = students;

            // Đảm bảo cột "lop" (lớp) được hiển thị
            dataGridView1.Columns["lop"].Visible = true; // Hiển thị cột lop
        }

        // Sự kiện khi bấm nút "Thêm"
        private void btAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường có được nhập đầy đủ không
            if (string.IsNullOrEmpty(tbid.Text) || string.IsNullOrEmpty(tbten.Text) || string.IsNullOrEmpty(tbnamsinh.Text) ||
                string.IsNullOrEmpty(tbgioitinh.Text) || cblop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các trường nhập
            string id = tbid.Text;
            string name = tbten.Text;

            // Kiểm tra năm sinh hợp lệ
            if (!int.TryParse(tbnamsinh.Text, out int namsinh) || namsinh < 1900 || namsinh > DateTime.Now.Year)
            {
                MessageBox.Show($"Vui lòng nhập năm sinh từ 1900 đến {DateTime.Now.Year}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioitinh = tbgioitinh.SelectedItem.ToString();  // Đảm bảo lấy giá trị từ ComboBox
            string nganh = cbnganh.SelectedItem.ToString();  // Đảm bảo lấy giá trị từ ComboBox
            string lop = cblop.SelectedItem.ToString(); // Lấy lớp từ ComboBox

            // Kiểm tra ID đã tồn tại trong danh sách sinh viên chưa
            if (students.Any(s => s.masv == id))
            {
                MessageBox.Show("ID sinh viên đã tồn tại. Vui lòng nhập ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo một đối tượng sinh viên mới
            Student newStudent = new Student
            {
                masv = id,
                ten = name,
                namsinh = namsinh,
                gioitinh = gioitinh,
                nganh = nganh,
                lop = lop
            };

            // Thêm vào danh sách sinh viên
            students.Add(newStudent);

            // Hiển thị thông báo
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật DataGridView
            UpdateStudentGrid();

            // Xóa trắng các ô nhập liệu
            ClearInputFields();
        }


        // Sự kiện khi bấm nút "Sửa"
        private void btEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ID có được nhập hay không
            if (string.IsNullOrEmpty(tbid.Text))
            {
                MessageBox.Show("Vui lòng nhập ID sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID sinh viên từ TextBox
            string id = tbid.Text;

            // Tìm sinh viên theo ID trong danh sách
            Student studentToEdit = students.FirstOrDefault(s => s.masv == id);

            if (studentToEdit != null)
            {
                // Cập nhật thông tin sinh viên
                studentToEdit.ten = tbten.Text;

                // Kiểm tra và cập nhật năm sinh hợp lệ
                if (!int.TryParse(tbnamsinh.Text, out int namsinh) || namsinh < 1900 || namsinh > DateTime.Now.Year)
                {
                    MessageBox.Show($"Vui lòng nhập năm sinh từ 1900 đến {DateTime.Now.Year}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                studentToEdit.namsinh = namsinh;

                // Cập nhật giới tính từ ComboBox
                if (tbgioitinh.SelectedItem != null)
                {
                    studentToEdit.gioitinh = tbgioitinh.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật lớp từ ComboBox cblop
                if (cblop.SelectedItem != null)
                {
                    studentToEdit.lop = cblop.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật ngành học từ ComboBox cbnganh
                if (cbnganh.SelectedItem != null)
                {
                    studentToEdit.nganh = cbnganh.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ngành học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị thông báo
                MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại DataGridView sau khi sửa
                UpdateStudentGrid();

                // Xóa trắng các ô nhập liệu
                ClearInputFields();
            }
            else
            {
                // Hiển thị thông báo nếu không tìm thấy sinh viên
                MessageBox.Show("Không tìm thấy sinh viên với ID đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Sự kiện khi bấm nút "Xóa"
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có nhập ID không
            if (string.IsNullOrEmpty(tbid.Text))
            {
                MessageBox.Show("Vui lòng nhập ID sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID từ TextBox tbid
            string id = tbid.Text;

            // Tìm sinh viên theo ID trong danh sách
            Student studentToDelete = students.FirstOrDefault(s => s.masv == id);

            if (studentToDelete != null)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa sinh viên khỏi danh sách
                    students.Remove(studentToDelete);

                    // Hiển thị thông báo
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView sau khi xóa
                    UpdateStudentGrid();
                }
            }
            else
            {
                // Hiển thị thông báo nếu không tìm thấy sinh viên
                MessageBox.Show("Không tìm thấy sinh viên với ID đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Xóa trắng TextBox sau khi xóa
            tbid.Clear();
        }

        // Phương thức cập nhật DataGridView
        private void UpdateStudentGrid()
        {
            dataGridView1.DataSource = null; // Đặt DataSource về null để reset
            dataGridView1.DataSource = students; // Gán lại danh sách sinh viên
        }

        // Phương thức xóa trắng các ô nhập liệu
        private void ClearInputFields()
        {
            tbid.Clear();
            tbten.Clear();
            tbnamsinh.Clear();
            tbgioitinh.SelectedIndex = -1; // Đặt ComboBox về trạng thái chưa chọn
            cblop.SelectedIndex = -1; // Đặt ComboBox về trạng thái chưa chọn
            cbnganh.SelectedIndex = -1; // Đặt ComboBox về trạng thái chưa chọn
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào hàng
            if (e.RowIndex >= 0)
            {
                var selectedStudent = students[e.RowIndex];

                // Hiển thị thông tin sinh viên vào các TextBox
                tbid.Text = selectedStudent.masv;
                tbten.Text = selectedStudent.ten;
                tbnamsinh.Text = selectedStudent.namsinh.ToString();
                tbgioitinh.SelectedItem = selectedStudent.gioitinh; // Gán giá trị vào ComboBox
                cblop.SelectedItem = selectedStudent.lop; // Gán giá trị vào ComboBox lớp
                cbnganh.SelectedItem = selectedStudent.nganh; // Gán giá trị vào ComboBox ngành
            }
        }

        // Sự kiện khi bấm nút "Thoát"
        private void btExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }
    }

    // Định nghĩa lớp Student
    public class Student
    {
        public string masv { get; set; }
        public string ten { get; set; }
        public int namsinh { get; set; }
        public string gioitinh { get; set; }
        public string nganh { get; set; }
        public string lop { get; set; }
    }
}


