namespace QLSinhVien
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btAdd = new Button();
            tbid = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btEdit = new Button();
            btDelete = new Button();
            btExit = new Button();
            lb = new Label();
            label2 = new Label();
            tbten = new TextBox();
            label3 = new Label();
            tbnamsinh = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbgioitinh = new ComboBox();
            cbnganh = new ComboBox();
            cblop = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btAdd.Location = new Point(480, 548);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 40);
            btAdd.TabIndex = 0;
            btAdd.Text = "Thêm";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tbid
            // 
            tbid.Anchor = AnchorStyles.None;
            tbid.Location = new Point(74, 479);
            tbid.Name = "tbid";
            tbid.Size = new Size(173, 27);
            tbid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(929, 358);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, -2);
            label1.Name = "label1";
            label1.Size = new Size(253, 40);
            label1.TabIndex = 3;
            label1.Text = "Quản lí sinh viên";
            // 
            // btEdit
            // 
            btEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btEdit.Location = new Point(631, 548);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 40);
            btEdit.TabIndex = 4;
            btEdit.Text = "Sửa";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btDelete.Location = new Point(774, 548);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 40);
            btDelete.TabIndex = 5;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btExit
            // 
            btExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btExit.Location = new Point(925, 548);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 40);
            btExit.TabIndex = 6;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // lb
            // 
            lb.Anchor = AnchorStyles.None;
            lb.AutoSize = true;
            lb.Location = new Point(74, 446);
            lb.Name = "lb";
            lb.Size = new Size(49, 20);
            lb.TabIndex = 7;
            lb.Text = "MASV";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(74, 528);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên";
            // 
            // tbten
            // 
            tbten.Anchor = AnchorStyles.None;
            tbten.Location = new Point(74, 561);
            tbten.Name = "tbten";
            tbten.Size = new Size(173, 27);
            tbten.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(280, 446);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 11;
            label3.Text = "Năm sinh";
            // 
            // tbnamsinh
            // 
            tbnamsinh.Anchor = AnchorStyles.None;
            tbnamsinh.Location = new Point(280, 479);
            tbnamsinh.Name = "tbnamsinh";
            tbnamsinh.Size = new Size(173, 27);
            tbnamsinh.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(280, 528);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 13;
            label4.Text = "Giới tính";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(481, 446);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 17;
            label6.Text = "Ngành";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(681, 446);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 19;
            label7.Text = "Lớp";
            // 
            // tbgioitinh
            // 
            tbgioitinh.Anchor = AnchorStyles.None;
            tbgioitinh.FormattingEnabled = true;
            tbgioitinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            tbgioitinh.Location = new Point(280, 561);
            tbgioitinh.Name = "tbgioitinh";
            tbgioitinh.Size = new Size(151, 28);
            tbgioitinh.TabIndex = 20;
            // 
            // cbnganh
            // 
            cbnganh.Anchor = AnchorStyles.None;
            cbnganh.FormattingEnabled = true;
            cbnganh.Items.AddRange(new object[] { "Công nghệ thông tin ", "Quản trị khách sạn ", "Ngôn ngữ anh ", "Cơ khí ", "Điện ", "Thực phẩm", "Quản trị kinh doanh", "Maketing" });
            cbnganh.Location = new Point(481, 479);
            cbnganh.Name = "cbnganh";
            cbnganh.Size = new Size(151, 28);
            cbnganh.TabIndex = 21;
            // 
            // cblop
            // 
            cblop.Anchor = AnchorStyles.None;
            cblop.FormattingEnabled = true;
            cblop.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H" });
            cblop.Location = new Point(681, 479);
            cblop.Name = "cblop";
            cblop.Size = new Size(151, 28);
            cblop.TabIndex = 22;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1070, 616);
            Controls.Add(cblop);
            Controls.Add(cbnganh);
            Controls.Add(tbgioitinh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbnamsinh);
            Controls.Add(label2);
            Controls.Add(tbten);
            Controls.Add(lb);
            Controls.Add(btExit);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(tbid);
            Controls.Add(btAdd);
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAdd;
        private TextBox tbid;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btEdit;
        private Button btDelete;
        private Button btExit;
        private Label lb;
        private Label label2;
        private TextBox tbten;
        private Label label3;
        private TextBox tbnamsinh;
        private Label label4;
        private Label label6;
        private Label label7;
        private ComboBox tbgioitinh;
        private ComboBox cbnganh;
        private ComboBox cblop;
    }
}