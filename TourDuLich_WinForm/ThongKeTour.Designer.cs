namespace TourDuLich_WinForm
{
    partial class ThongKeTour
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemBangGia_Tour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtThoiGian_Tour = new System.Windows.Forms.DateTimePicker();
            this.dgvGia_Tour = new System.Windows.Forms.DataGridView();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTour_TKTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem_TKTH = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtNgayBD_TKTH = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayKT_TKTH = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThongKe_NV_Tour = new System.Windows.Forms.Button();
            this.dtNgayBD_NV = new System.Windows.Forms.DateTimePicker();
            this.cboTenNhanVien = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtNgayKT_NV = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtaGridVCTDST_DST = new System.Windows.Forms.DataGridView();
            this.btnThongKe_DSTour = new System.Windows.Forms.Button();
            this.dtaGridVDSTour_DST = new System.Windows.Forms.DataGridView();
            this.btnLayDL_DSTour = new System.Windows.Forms.Button();
            this.txtTenTour_DST = new System.Windows.Forms.TextBox();
            this.dtNgayKT_DST = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBD_DST = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.lbTDT = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia_Tour)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridVCTDST_DST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridVDSTour_DST)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xem Giá";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemBangGia_Tour);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtThoiGian_Tour);
            this.panel1.Controls.Add(this.dgvGia_Tour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 459);
            this.panel1.TabIndex = 1;
            // 
            // btnXemBangGia_Tour
            // 
            this.btnXemBangGia_Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBangGia_Tour.Location = new System.Drawing.Point(713, 72);
            this.btnXemBangGia_Tour.Name = "btnXemBangGia_Tour";
            this.btnXemBangGia_Tour.Size = new System.Drawing.Size(157, 33);
            this.btnXemBangGia_Tour.TabIndex = 4;
            this.btnXemBangGia_Tour.Text = "Xem bảng giá";
            this.btnXemBangGia_Tour.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn ngày:";
            // 
            // dtThoiGian_Tour
            // 
            this.dtThoiGian_Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThoiGian_Tour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtThoiGian_Tour.Location = new System.Drawing.Point(389, 73);
            this.dtThoiGian_Tour.Name = "dtThoiGian_Tour";
            this.dtThoiGian_Tour.Size = new System.Drawing.Size(229, 26);
            this.dtThoiGian_Tour.TabIndex = 2;
            // 
            // dgvGia_Tour
            // 
            this.dgvGia_Tour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGia_Tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGia_Tour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenTour,
            this.giaTour});
            this.dgvGia_Tour.Location = new System.Drawing.Point(95, 130);
            this.dgvGia_Tour.Name = "dgvGia_Tour";
            this.dgvGia_Tour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGia_Tour.Size = new System.Drawing.Size(890, 302);
            this.dgvGia_Tour.TabIndex = 1;
            // 
            // tenTour
            // 
            this.tenTour.DataPropertyName = "Ten";
            this.tenTour.HeaderText = "Tên Tour";
            this.tenTour.Name = "tenTour";
            // 
            // giaTour
            // 
            this.giaTour.DataPropertyName = "Gia";
            this.giaTour.HeaderText = "Giá";
            this.giaTour.Name = "giaTour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng giá hiện tại của mỗi Tour";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tình Hình Hoạt Động";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(851, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(849, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiền lời";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnTimKiem_TKTH);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.dtNgayBD_TKTH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtNgayKT_TKTH);
            this.groupBox1.Location = new System.Drawing.Point(28, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 487);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện thống kê";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTour,
            this.TenTour_TKTH});
            this.dataGridView1.Location = new System.Drawing.Point(25, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // MaTour
            // 
            this.MaTour.HeaderText = "Mã Tour";
            this.MaTour.Name = "MaTour";
            // 
            // TenTour_TKTH
            // 
            this.TenTour_TKTH.HeaderText = "Tên Tour";
            this.TenTour_TKTH.Name = "TenTour_TKTH";
            // 
            // btnTimKiem_TKTH
            // 
            this.btnTimKiem_TKTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_TKTH.Location = new System.Drawing.Point(337, 381);
            this.btnTimKiem_TKTH.Name = "btnTimKiem_TKTH";
            this.btnTimKiem_TKTH.Size = new System.Drawing.Size(140, 51);
            this.btnTimKiem_TKTH.TabIndex = 10;
            this.btnTimKiem_TKTH.Text = "Thống kê";
            this.btnTimKiem_TKTH.UseVisualStyleBackColor = true;
            this.btnTimKiem_TKTH.Click += new System.EventHandler(this.btnTimKiem_TKTH_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(136, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 24);
            this.textBox3.TabIndex = 11;
            // 
            // dtNgayBD_TKTH
            // 
            this.dtNgayBD_TKTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD_TKTH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBD_TKTH.Location = new System.Drawing.Point(157, 19);
            this.dtNgayBD_TKTH.Name = "dtNgayBD_TKTH";
            this.dtNgayBD_TKTH.Size = new System.Drawing.Size(200, 26);
            this.dtNgayBD_TKTH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên Tour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày kết thúc";
            // 
            // dtNgayKT_TKTH
            // 
            this.dtNgayKT_TKTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKT_TKTH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKT_TKTH.Location = new System.Drawing.Point(157, 64);
            this.dtNgayKT_TKTH.Name = "dtNgayKT_TKTH";
            this.dtNgayKT_TKTH.Size = new System.Drawing.Size(200, 26);
            this.dtNgayKT_TKTH.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số đoàn khách tham gia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thống kê tình hình hoạt động";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1200, 630);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhân Viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(296, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số lượng Tour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThongKe_NV_Tour);
            this.groupBox2.Controls.Add(this.dtNgayBD_NV);
            this.groupBox2.Controls.Add(this.cboTenNhanVien);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtNgayKT_NV);
            this.groupBox2.Location = new System.Drawing.Point(31, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 197);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều kiện thống kê";
            // 
            // btnThongKe_NV_Tour
            // 
            this.btnThongKe_NV_Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe_NV_Tour.Location = new System.Drawing.Point(391, 128);
            this.btnThongKe_NV_Tour.Name = "btnThongKe_NV_Tour";
            this.btnThongKe_NV_Tour.Size = new System.Drawing.Size(140, 51);
            this.btnThongKe_NV_Tour.TabIndex = 10;
            this.btnThongKe_NV_Tour.Text = "Thống Kê";
            this.btnThongKe_NV_Tour.UseVisualStyleBackColor = true;
            this.btnThongKe_NV_Tour.Click += new System.EventHandler(this.btnThongKe_NV_Tour_Click);
            // 
            // dtNgayBD_NV
            // 
            this.dtNgayBD_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD_NV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBD_NV.Location = new System.Drawing.Point(201, 21);
            this.dtNgayBD_NV.Name = "dtNgayBD_NV";
            this.dtNgayBD_NV.Size = new System.Drawing.Size(200, 26);
            this.dtNgayBD_NV.TabIndex = 5;
            // 
            // cboTenNhanVien
            // 
            this.cboTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenNhanVien.FormattingEnabled = true;
            this.cboTenNhanVien.Location = new System.Drawing.Point(201, 76);
            this.cboTenNhanVien.Name = "cboTenNhanVien";
            this.cboTenNhanVien.Size = new System.Drawing.Size(275, 27);
            this.cboTenNhanVien.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ngày bắt đầu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên Nhân Viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(481, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ngày kết thúc";
            // 
            // dtNgayKT_NV
            // 
            this.dtNgayKT_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKT_NV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKT_NV.Location = new System.Drawing.Point(606, 19);
            this.dtNgayKT_NV.Name = "dtNgayKT_NV";
            this.dtNgayKT_NV.Size = new System.Drawing.Size(200, 26);
            this.dtNgayKT_NV.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(276, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(482, 31);
            this.label13.TabIndex = 16;
            this.label13.Text = "Thống kê số lượng Tour của một nhân viên";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbTDT);
            this.tabPage4.Controls.Add(this.lbTongDoanhThu);
            this.tabPage4.Controls.Add(this.dtaGridVCTDST_DST);
            this.tabPage4.Controls.Add(this.btnThongKe_DSTour);
            this.tabPage4.Controls.Add(this.dtaGridVDSTour_DST);
            this.tabPage4.Controls.Add(this.btnLayDL_DSTour);
            this.tabPage4.Controls.Add(this.txtTenTour_DST);
            this.tabPage4.Controls.Add(this.dtNgayKT_DST);
            this.tabPage4.Controls.Add(this.dtNgayBD_DST);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1200, 630);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Doanh Số Tour";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtaGridVCTDST_DST
            // 
            this.dtaGridVCTDST_DST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridVCTDST_DST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridVCTDST_DST.Location = new System.Drawing.Point(671, 200);
            this.dtaGridVCTDST_DST.Name = "dtaGridVCTDST_DST";
            this.dtaGridVCTDST_DST.ReadOnly = true;
            this.dtaGridVCTDST_DST.Size = new System.Drawing.Size(502, 420);
            this.dtaGridVCTDST_DST.TabIndex = 12;
            // 
            // btnThongKe_DSTour
            // 
            this.btnThongKe_DSTour.Location = new System.Drawing.Point(562, 393);
            this.btnThongKe_DSTour.Name = "btnThongKe_DSTour";
            this.btnThongKe_DSTour.Size = new System.Drawing.Size(90, 62);
            this.btnThongKe_DSTour.TabIndex = 11;
            this.btnThongKe_DSTour.Text = "Thống kê";
            this.btnThongKe_DSTour.UseVisualStyleBackColor = true;
            this.btnThongKe_DSTour.Click += new System.EventHandler(this.btnThongKe_DSTour_Click);
            // 
            // dtaGridVDSTour_DST
            // 
            this.dtaGridVDSTour_DST.AllowUserToAddRows = false;
            this.dtaGridVDSTour_DST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridVDSTour_DST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridVDSTour_DST.Location = new System.Drawing.Point(42, 204);
            this.dtaGridVDSTour_DST.Name = "dtaGridVDSTour_DST";
            this.dtaGridVDSTour_DST.ReadOnly = true;
            this.dtaGridVDSTour_DST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridVDSTour_DST.Size = new System.Drawing.Size(502, 420);
            this.dtaGridVDSTour_DST.TabIndex = 10;
            // 
            // btnLayDL_DSTour
            // 
            this.btnLayDL_DSTour.Location = new System.Drawing.Point(944, 85);
            this.btnLayDL_DSTour.Name = "btnLayDL_DSTour";
            this.btnLayDL_DSTour.Size = new System.Drawing.Size(124, 62);
            this.btnLayDL_DSTour.TabIndex = 9;
            this.btnLayDL_DSTour.Text = "Lấy dữ liệu";
            this.btnLayDL_DSTour.UseVisualStyleBackColor = true;
            this.btnLayDL_DSTour.Click += new System.EventHandler(this.btnLayDL_DSTour_Click);
            // 
            // txtTenTour_DST
            // 
            this.txtTenTour_DST.Location = new System.Drawing.Point(208, 128);
            this.txtTenTour_DST.Name = "txtTenTour_DST";
            this.txtTenTour_DST.Size = new System.Drawing.Size(717, 20);
            this.txtTenTour_DST.TabIndex = 8;
            // 
            // dtNgayKT_DST
            // 
            this.dtNgayKT_DST.Location = new System.Drawing.Point(663, 85);
            this.dtNgayKT_DST.Name = "dtNgayKT_DST";
            this.dtNgayKT_DST.Size = new System.Drawing.Size(262, 20);
            this.dtNgayKT_DST.TabIndex = 7;
            // 
            // dtNgayBD_DST
            // 
            this.dtNgayBD_DST.Location = new System.Drawing.Point(290, 85);
            this.dtNgayBD_DST.Name = "dtNgayBD_DST";
            this.dtNgayBD_DST.Size = new System.Drawing.Size(262, 20);
            this.dtNgayBD_DST.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(733, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 19);
            this.label19.TabIndex = 5;
            this.label19.Text = "Bảng chi tiết doanh thu";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(221, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 19);
            this.label18.TabIndex = 4;
            this.label18.Text = "Danh sách các tour";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(119, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Tìm tên tour";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(558, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Chọn ngày KT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(119, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Chọn ngày BĐ Thống Kê";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label14.Location = new System.Drawing.Point(496, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Doanh Số Tour";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDoanhThu.Location = new System.Drawing.Point(950, 178);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(118, 19);
            this.lbTongDoanhThu.TabIndex = 13;
            this.lbTongDoanhThu.Text = "Tổng Doanh Thu: ";
            // 
            // lbTDT
            // 
            this.lbTDT.AutoSize = true;
            this.lbTDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTDT.Location = new System.Drawing.Point(1074, 178);
            this.lbTDT.Name = "lbTDT";
            this.lbTDT.Size = new System.Drawing.Size(17, 19);
            this.lbTDT.TabIndex = 14;
            this.lbTDT.Text = "0";
            // 
            // ThongKeTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 669);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKeTour";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ThongKeTour_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia_Tour)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridVCTDST_DST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridVDSTour_DST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemBangGia_Tour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtThoiGian_Tour;
        private System.Windows.Forms.DataGridView dgvGia_Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem_TKTH;
        private System.Windows.Forms.DateTimePicker dtNgayBD_TKTH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayKT_TKTH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour_TKTH;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThongKe_NV_Tour;
        private System.Windows.Forms.DateTimePicker dtNgayBD_NV;
        private System.Windows.Forms.ComboBox cboTenNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtNgayKT_NV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnLayDL_DSTour;
        private System.Windows.Forms.TextBox txtTenTour_DST;
        private System.Windows.Forms.DateTimePicker dtNgayKT_DST;
        private System.Windows.Forms.DateTimePicker dtNgayBD_DST;
        private System.Windows.Forms.Button btnThongKe_DSTour;
        private System.Windows.Forms.DataGridView dtaGridVDSTour_DST;
        private System.Windows.Forms.DataGridView dtaGridVCTDST_DST;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.Label lbTDT;
    }
}

