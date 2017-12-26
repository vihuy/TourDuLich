namespace TourDuLich_WinForm
{
    partial class DiaDiemTour
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView_DSDiaDiemdaydu = new System.Windows.Forms.DataGridView();
            this.MaDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTinhThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTinhThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_DSDiaDiem = new System.Windows.Forms.DataGridView();
            this.maDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_TenTour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_TinhThanh = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DSDiaDiemdaydu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSDiaDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(408, 292);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(59, 36);
            this.btn_Them.TabIndex = 24;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView_DSDiaDiemdaydu);
            this.groupBox2.Location = new System.Drawing.Point(489, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 380);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh  sách địa điểm của một tuor";
            // 
            // DataGridView_DSDiaDiemdaydu
            // 
            this.DataGridView_DSDiaDiemdaydu.AllowUserToAddRows = false;
            this.DataGridView_DSDiaDiemdaydu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_DSDiaDiemdaydu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_DSDiaDiemdaydu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDiaDiem,
            this.TenDiaDiem,
            this.MaTinhThanh,
            this.TenTinhThanh,
            this.Xoa});
            this.DataGridView_DSDiaDiemdaydu.Location = new System.Drawing.Point(16, 19);
            this.DataGridView_DSDiaDiemdaydu.Name = "DataGridView_DSDiaDiemdaydu";
            this.DataGridView_DSDiaDiemdaydu.Size = new System.Drawing.Size(336, 337);
            this.DataGridView_DSDiaDiemdaydu.TabIndex = 1;
            this.DataGridView_DSDiaDiemdaydu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_DSDiaDiemdaydu_CellContentClick);
            // 
            // MaDiaDiem
            // 
            this.MaDiaDiem.HeaderText = "Ma Dia Diem";
            this.MaDiaDiem.Name = "MaDiaDiem";
            this.MaDiaDiem.Visible = false;
            // 
            // TenDiaDiem
            // 
            this.TenDiaDiem.HeaderText = "Tên Địa Điểm";
            this.TenDiaDiem.Name = "TenDiaDiem";
            // 
            // MaTinhThanh
            // 
            this.MaTinhThanh.HeaderText = "Ma Tinh Thanh";
            this.MaTinhThanh.Name = "MaTinhThanh";
            this.MaTinhThanh.Visible = false;
            // 
            // TenTinhThanh
            // 
            this.TenTinhThanh.HeaderText = "Tên Tỉnh Thành";
            this.TenTinhThanh.Name = "TenTinhThanh";
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_DSDiaDiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 380);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách địa điểm";
            // 
            // dataGridView_DSDiaDiem
            // 
            this.dataGridView_DSDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DSDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSDiaDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDD,
            this.TenDD});
            this.dataGridView_DSDiaDiem.Location = new System.Drawing.Point(19, 19);
            this.dataGridView_DSDiaDiem.Name = "dataGridView_DSDiaDiem";
            this.dataGridView_DSDiaDiem.Size = new System.Drawing.Size(336, 337);
            this.dataGridView_DSDiaDiem.TabIndex = 0;
            // 
            // maDD
            // 
            this.maDD.DataPropertyName = "MaDD";
            this.maDD.HeaderText = "Mã DD";
            this.maDD.Name = "maDD";
            // 
            // TenDD
            // 
            this.TenDD.DataPropertyName = "Ten";
            this.TenDD.HeaderText = "Tên địa điểm";
            this.TenDD.Name = "TenDD";
            // 
            // cmb_TenTour
            // 
            this.cmb_TenTour.FormattingEnabled = true;
            this.cmb_TenTour.Location = new System.Drawing.Point(189, 69);
            this.cmb_TenTour.Name = "cmb_TenTour";
            this.cmb_TenTour.Size = new System.Drawing.Size(146, 21);
            this.cmb_TenTour.TabIndex = 28;
            this.cmb_TenTour.SelectedIndexChanged += new System.EventHandler(this.cmb_TenTour_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên đoàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Lập danh sách địa điểm của một tour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Chọn tỉnh thành";
            // 
            // cmb_TinhThanh
            // 
            this.cmb_TinhThanh.FormattingEnabled = true;
            this.cmb_TinhThanh.Location = new System.Drawing.Point(189, 106);
            this.cmb_TinhThanh.Name = "cmb_TinhThanh";
            this.cmb_TinhThanh.Size = new System.Drawing.Size(146, 21);
            this.cmb_TinhThanh.TabIndex = 32;
            this.cmb_TinhThanh.SelectedIndexChanged += new System.EventHandler(this.cmb_TinhThanh_SelectedIndexChanged);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(717, 567);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 36);
            this.btn_Luu.TabIndex = 33;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // DiaDiemTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 615);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cmb_TinhThanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_TenTour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DiaDiemTour";
            this.Text = "DiaDiemTour";
            this.Load += new System.EventHandler(this.DiaDiemTour_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DSDiaDiemdaydu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSDiaDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView_DSDiaDiemdaydu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_DSDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDD;
        private System.Windows.Forms.ComboBox cmb_TenTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_TinhThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTinhThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTinhThanh;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.Button btn_Luu;
    }
}