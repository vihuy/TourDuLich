namespace TourDuLich_WinForm
{
    partial class ThongKe_TinhHinh_Tour
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayBD_TKTH = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKT_TKTH = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cboTenTour_TKTH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem_TKTH = new System.Windows.Forms.Button();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.tenTour,
            this.giaTour});
            this.dataGridView1.Location = new System.Drawing.Point(71, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(838, 134);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống kê tình hình hoạt động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // dtNgayBD_TKTH
            // 
            this.dtNgayBD_TKTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD_TKTH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBD_TKTH.Location = new System.Drawing.Point(215, 19);
            this.dtNgayBD_TKTH.Name = "dtNgayBD_TKTH";
            this.dtNgayBD_TKTH.Size = new System.Drawing.Size(200, 26);
            this.dtNgayBD_TKTH.TabIndex = 5;
            // 
            // dtNgayKT_TKTH
            // 
            this.dtNgayKT_TKTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKT_TKTH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKT_TKTH.Location = new System.Drawing.Point(606, 19);
            this.dtNgayKT_TKTH.Name = "dtNgayKT_TKTH";
            this.dtNgayKT_TKTH.Size = new System.Drawing.Size(200, 26);
            this.dtNgayKT_TKTH.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày kết thúc";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên Tour";
            // 
            // cboTenTour_TKTH
            // 
            this.cboTenTour_TKTH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenTour_TKTH.FormattingEnabled = true;
            this.cboTenTour_TKTH.Location = new System.Drawing.Point(215, 72);
            this.cboTenTour_TKTH.Name = "cboTenTour_TKTH";
            this.cboTenTour_TKTH.Size = new System.Drawing.Size(297, 27);
            this.cboTenTour_TKTH.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem_TKTH);
            this.groupBox1.Controls.Add(this.dtNgayBD_TKTH);
            this.groupBox1.Controls.Add(this.cboTenTour_TKTH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtNgayKT_TKTH);
            this.groupBox1.Location = new System.Drawing.Point(26, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 197);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện thống kê";
            // 
            // btnTimKiem_TKTH
            // 
            this.btnTimKiem_TKTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_TKTH.Location = new System.Drawing.Point(391, 128);
            this.btnTimKiem_TKTH.Name = "btnTimKiem_TKTH";
            this.btnTimKiem_TKTH.Size = new System.Drawing.Size(140, 51);
            this.btnTimKiem_TKTH.TabIndex = 10;
            this.btnTimKiem_TKTH.Text = "Tìm Kiếm";
            this.btnTimKiem_TKTH.UseVisualStyleBackColor = true;
            this.btnTimKiem_TKTH.Click += new System.EventHandler(this.button1_Click);
            // 
            // maTour
            // 
            this.maTour.HeaderText = "Thời gian";
            this.maTour.Name = "maTour";
            // 
            // tenTour
            // 
            this.tenTour.HeaderText = "Số đoàn khách đi Tour";
            this.tenTour.Name = "tenTour";
            // 
            // giaTour
            // 
            this.giaTour.HeaderText = "Tiền lời";
            this.giaTour.Name = "giaTour";
            // 
            // ThongKe_TinhHinh_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe_TinhHinh_Tour";
            this.Text = "ThongKe_TinhHinh_Tour";
            this.Load += new System.EventHandler(this.ThongKe_TinhHinh_Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayBD_TKTH;
        private System.Windows.Forms.DateTimePicker dtNgayKT_TKTH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTenTour_TKTH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem_TKTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTour;
    }
}