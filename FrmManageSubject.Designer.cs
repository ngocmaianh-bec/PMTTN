namespace Phần_mềm_thi_trắc_nghiệm
{
    partial class FrmManageSubject
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinMonThi = new System.Windows.Forms.GroupBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMaMonThi = new System.Windows.Forms.TextBox();
            this.txtTenMonThi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaMonThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMonThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTinMonThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÔN THI";
            // 
            // grbThongTinMonThi
            // 
            this.grbThongTinMonThi.Controls.Add(this.btnTimKiem);
            this.grbThongTinMonThi.Controls.Add(this.txtTimKiem);
            this.grbThongTinMonThi.Controls.Add(this.btnXoa);
            this.grbThongTinMonThi.Controls.Add(this.btnSua);
            this.grbThongTinMonThi.Controls.Add(this.btnThem);
            this.grbThongTinMonThi.Controls.Add(this.txtTenMonThi);
            this.grbThongTinMonThi.Controls.Add(this.txtMaMonThi);
            this.grbThongTinMonThi.Controls.Add(this.lblTen);
            this.grbThongTinMonThi.Controls.Add(this.lblMa);
            this.grbThongTinMonThi.Location = new System.Drawing.Point(29, 61);
            this.grbThongTinMonThi.Name = "grbThongTinMonThi";
            this.grbThongTinMonThi.Size = new System.Drawing.Size(746, 216);
            this.grbThongTinMonThi.TabIndex = 1;
            this.grbThongTinMonThi.TabStop = false;
            this.grbThongTinMonThi.Text = "Thông tin môn thi";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(41, 48);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(91, 20);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã môn thi:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(353, 48);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(96, 20);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên môn thi:";
            // 
            // txtMaMonThi
            // 
            this.txtMaMonThi.Location = new System.Drawing.Point(152, 42);
            this.txtMaMonThi.Name = "txtMaMonThi";
            this.txtMaMonThi.Size = new System.Drawing.Size(184, 26);
            this.txtMaMonThi.TabIndex = 2;
            // 
            // txtTenMonThi
            // 
            this.txtTenMonThi.Location = new System.Drawing.Point(464, 42);
            this.txtTenMonThi.Name = "txtTenMonThi";
            this.txtTenMonThi.Size = new System.Drawing.Size(235, 26);
            this.txtTenMonThi.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThem.Location = new System.Drawing.Point(152, 96);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 32);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSua.Location = new System.Drawing.Point(305, 96);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 32);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoa.Location = new System.Drawing.Point(464, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 32);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(45, 154);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(276, 26);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.Text = "Nhập mã/ tên môn thi";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTimKiem.Location = new System.Drawing.Point(357, 150);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 34);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMonThi,
            this.colTenMonThi});
            this.dataGridView1.Location = new System.Drawing.Point(29, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(746, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // colMaMonThi
            // 
            this.colMaMonThi.DataPropertyName = "MaMonThi";
            this.colMaMonThi.HeaderText = "Mã môn thi";
            this.colMaMonThi.MinimumWidth = 8;
            this.colMaMonThi.Name = "colMaMonThi";
            this.colMaMonThi.ReadOnly = true;
            // 
            // colTenMonThi
            // 
            this.colTenMonThi.DataPropertyName = "TenMonThi";
            this.colTenMonThi.HeaderText = "Tên môn thi";
            this.colTenMonThi.MinimumWidth = 8;
            this.colTenMonThi.Name = "colTenMonThi";
            this.colTenMonThi.ReadOnly = true;
            // 
            // FrmManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbThongTinMonThi);
            this.Controls.Add(this.label1);
            this.Name = "FrmManageSubject";
            this.Text = "FrmManageSubject";
            this.grbThongTinMonThi.ResumeLayout(false);
            this.grbThongTinMonThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTinMonThi;
        private System.Windows.Forms.TextBox txtTenMonThi;
        private System.Windows.Forms.TextBox txtMaMonThi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMonThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMonThi;
    }
}