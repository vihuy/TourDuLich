namespace TourDuLich_WinForm
{
    partial class Quanli_Doan
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
            this.dgvDoan = new System.Windows.Forms.DataGridView();
            this.maDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTourGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoan
            // 
            this.dgvDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoan,
            this.tenDoan,
            this.maTourGia});
            this.dgvDoan.Location = new System.Drawing.Point(84, 69);
            this.dgvDoan.Name = "dgvDoan";
            this.dgvDoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoan.Size = new System.Drawing.Size(721, 302);
            this.dgvDoan.TabIndex = 2;
            // 
            // maDoan
            // 
            this.maDoan.HeaderText = "Mã Đoàn";
            this.maDoan.Name = "maDoan";
            // 
            // tenDoan
            // 
            this.tenDoan.HeaderText = "Tên Đoàn";
            this.tenDoan.Name = "tenDoan";
            // 
            // maTourGia
            // 
            this.maTourGia.HeaderText = "Mã Tour Giá";
            this.maTourGia.Name = "maTourGia";
            // 
            // Quanli_Doan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 441);
            this.Controls.Add(this.dgvDoan);
            this.Name = "Quanli_Doan";
            this.Text = "Quanli_Doan";
            this.Load += new System.EventHandler(this.Quanli_Doan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTourGia;
    }
}