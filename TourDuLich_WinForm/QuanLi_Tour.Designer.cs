namespace TourDuLich_WinForm
{
    partial class QuanLi_Tour
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
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKetThuc_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTour
            // 
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.tenTour,
            this.giaTour,
            this.DiemKetThuc_Tour});
            this.dgvTour.Location = new System.Drawing.Point(110, 115);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(721, 302);
            this.dgvTour.TabIndex = 3;
            // 
            // maTour
            // 
            this.maTour.DataPropertyName = "MaTour";
            this.maTour.HeaderText = "Mã Tour";
            this.maTour.Name = "maTour";
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
            this.giaTour.HeaderText = "Điểm khởi hành";
            this.giaTour.Name = "giaTour";
            // 
            // DiemKetThuc_Tour
            // 
            this.DiemKetThuc_Tour.HeaderText = "Điểm kết thúc";
            this.DiemKetThuc_Tour.Name = "DiemKetThuc_Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bảng giá hiện tại của mỗi Tour";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 45);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(281, 32);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Thống kê doanh thu";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuanLi_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 473);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.label1);
            this.Name = "QuanLi_Tour";
            this.Text = "QuanLi_Tour";
            this.Load += new System.EventHandler(this.QuanLi_Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKetThuc_Tour;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}