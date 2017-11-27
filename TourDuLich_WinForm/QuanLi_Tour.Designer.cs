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
            this.label1 = new System.Windows.Forms.Label();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKetThuc_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // QuanLi_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 473);
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
    }
}