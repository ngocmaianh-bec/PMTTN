namespace Phần_mềm_thi_trắc_nghiệm
{
    partial class FrmManageQuestion
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
            this.lblQLCH = new System.Windows.Forms.Label();
            this.grbTTCH = new System.Windows.Forms.GroupBox();
            this.lblMon = new System.Windows.Forms.Label();
            this.lbDapanDung = new System.Windows.Forms.Label();
            this.lblNDCH = new System.Windows.Forms.Label();
            this.lblDapanA = new System.Windows.Forms.Label();
            this.lblDapanC = new System.Windows.Forms.Label();
            this.lblDapanB = new System.Windows.Forms.Label();
            this.lblDapanD = new System.Windows.Forms.Label();
            this.lblMaCH = new System.Windows.Forms.Label();
            this.txtDapanD = new System.Windows.Forms.TextBox();
            this.txtDapanC = new System.Windows.Forms.TextBox();
            this.txtDapanA = new System.Windows.Forms.TextBox();
            this.txtNDCH = new System.Windows.Forms.TextBox();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtDapanB = new System.Windows.Forms.TextBox();
            this.cbbDapanDung = new System.Windows.Forms.ComboBox();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgrCauHoi = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapanA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapanB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapanD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTTCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLCH
            // 
            this.lblQLCH.AutoSize = true;
            this.lblQLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLCH.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQLCH.Location = new System.Drawing.Point(274, 45);
            this.lblQLCH.Name = "lblQLCH";
            this.lblQLCH.Size = new System.Drawing.Size(737, 51);
            this.lblQLCH.TabIndex = 0;
            this.lblQLCH.Text = "QUẢN LÝ CÂU HỎI TRẮC NGHIỆM";
            // 
            // grbTTCH
            // 
            this.grbTTCH.Controls.Add(this.cbbMon);
            this.grbTTCH.Controls.Add(this.cbbDapanDung);
            this.grbTTCH.Controls.Add(this.txtDapanB);
            this.grbTTCH.Controls.Add(this.txtMaCH);
            this.grbTTCH.Controls.Add(this.txtNDCH);
            this.grbTTCH.Controls.Add(this.txtDapanA);
            this.grbTTCH.Controls.Add(this.txtDapanC);
            this.grbTTCH.Controls.Add(this.txtDapanD);
            this.grbTTCH.Controls.Add(this.lblMaCH);
            this.grbTTCH.Controls.Add(this.lblDapanD);
            this.grbTTCH.Controls.Add(this.lblDapanB);
            this.grbTTCH.Controls.Add(this.lblDapanC);
            this.grbTTCH.Controls.Add(this.lblDapanA);
            this.grbTTCH.Controls.Add(this.lblNDCH);
            this.grbTTCH.Controls.Add(this.lbDapanDung);
            this.grbTTCH.Controls.Add(this.lblMon);
            this.grbTTCH.Location = new System.Drawing.Point(52, 124);
            this.grbTTCH.Name = "grbTTCH";
            this.grbTTCH.Size = new System.Drawing.Size(1199, 265);
            this.grbTTCH.TabIndex = 1;
            this.grbTTCH.TabStop = false;
            this.grbTTCH.Text = "Thông tin câu hỏi";
            this.grbTTCH.Enter += new System.EventHandler(this.grbTTCH_Enter);
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(24, 133);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(83, 25);
            this.lblMon.TabIndex = 0;
            this.lblMon.Text = "Môn thi";
            // 
            // lbDapanDung
            // 
            this.lbDapanDung.AutoSize = true;
            this.lbDapanDung.Location = new System.Drawing.Point(24, 208);
            this.lbDapanDung.Name = "lbDapanDung";
            this.lbDapanDung.Size = new System.Drawing.Size(135, 25);
            this.lbDapanDung.TabIndex = 1;
            this.lbDapanDung.Text = "Đáp án đúng";
            // 
            // lblNDCH
            // 
            this.lblNDCH.AutoSize = true;
            this.lblNDCH.Location = new System.Drawing.Point(428, 56);
            this.lblNDCH.Name = "lblNDCH";
            this.lblNDCH.Size = new System.Drawing.Size(174, 25);
            this.lblNDCH.TabIndex = 2;
            this.lblNDCH.Text = "Nội dung câu hỏi";
            // 
            // lblDapanA
            // 
            this.lblDapanA.AutoSize = true;
            this.lblDapanA.Location = new System.Drawing.Point(428, 133);
            this.lblDapanA.Name = "lblDapanA";
            this.lblDapanA.Size = new System.Drawing.Size(101, 25);
            this.lblDapanA.TabIndex = 3;
            this.lblDapanA.Text = "Đáp án A";
            // 
            // lblDapanC
            // 
            this.lblDapanC.AutoSize = true;
            this.lblDapanC.Location = new System.Drawing.Point(798, 133);
            this.lblDapanC.Name = "lblDapanC";
            this.lblDapanC.Size = new System.Drawing.Size(102, 25);
            this.lblDapanC.TabIndex = 4;
            this.lblDapanC.Text = "Đáp án C";
            // 
            // lblDapanB
            // 
            this.lblDapanB.AutoSize = true;
            this.lblDapanB.Location = new System.Drawing.Point(428, 208);
            this.lblDapanB.Name = "lblDapanB";
            this.lblDapanB.Size = new System.Drawing.Size(101, 25);
            this.lblDapanB.TabIndex = 5;
            this.lblDapanB.Text = "Đáp án B";
            // 
            // lblDapanD
            // 
            this.lblDapanD.AutoSize = true;
            this.lblDapanD.Location = new System.Drawing.Point(798, 211);
            this.lblDapanD.Name = "lblDapanD";
            this.lblDapanD.Size = new System.Drawing.Size(102, 25);
            this.lblDapanD.TabIndex = 6;
            this.lblDapanD.Text = "Đáp án D";
            // 
            // lblMaCH
            // 
            this.lblMaCH.AutoSize = true;
            this.lblMaCH.Location = new System.Drawing.Point(24, 56);
            this.lblMaCH.Name = "lblMaCH";
            this.lblMaCH.Size = new System.Drawing.Size(118, 25);
            this.lblMaCH.TabIndex = 2;
            this.lblMaCH.Text = "Mã câu hỏi";
            // 
            // txtDapanD
            // 
            this.txtDapanD.Location = new System.Drawing.Point(928, 208);
            this.txtDapanD.Name = "txtDapanD";
            this.txtDapanD.Size = new System.Drawing.Size(205, 31);
            this.txtDapanD.TabIndex = 7;
            // 
            // txtDapanC
            // 
            this.txtDapanC.Location = new System.Drawing.Point(928, 130);
            this.txtDapanC.Name = "txtDapanC";
            this.txtDapanC.Size = new System.Drawing.Size(205, 31);
            this.txtDapanC.TabIndex = 8;
            // 
            // txtDapanA
            // 
            this.txtDapanA.Location = new System.Drawing.Point(557, 130);
            this.txtDapanA.Name = "txtDapanA";
            this.txtDapanA.Size = new System.Drawing.Size(205, 31);
            this.txtDapanA.TabIndex = 9;
            // 
            // txtNDCH
            // 
            this.txtNDCH.Location = new System.Drawing.Point(639, 53);
            this.txtNDCH.Name = "txtNDCH";
            this.txtNDCH.Size = new System.Drawing.Size(494, 31);
            this.txtNDCH.TabIndex = 10;
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(173, 53);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(217, 31);
            this.txtMaCH.TabIndex = 11;
            // 
            // txtDapanB
            // 
            this.txtDapanB.Location = new System.Drawing.Point(557, 205);
            this.txtDapanB.Name = "txtDapanB";
            this.txtDapanB.Size = new System.Drawing.Size(205, 31);
            this.txtDapanB.TabIndex = 12;
            // 
            // cbbDapanDung
            // 
            this.cbbDapanDung.FormattingEnabled = true;
            this.cbbDapanDung.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbbDapanDung.Location = new System.Drawing.Point(173, 205);
            this.cbbDapanDung.Name = "cbbDapanDung";
            this.cbbDapanDung.Size = new System.Drawing.Size(217, 33);
            this.cbbDapanDung.TabIndex = 13;
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Items.AddRange(new object[] {
            "Listening",
            "Grammar",
            "Vocabulary"});
            this.cbbMon.Location = new System.Drawing.Point(173, 130);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(217, 33);
            this.cbbMon.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(283, 411);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 53);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(879, 411);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 53);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(579, 411);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 53);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(52, 492);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(423, 31);
            this.txtNhap.TabIndex = 5;
            this.txtNhap.Text = "Nhập mã câu hỏi/nội dung câu hỏi";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(528, 485);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 44);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgrCauHoi
            // 
            this.dgrCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.MonThi,
            this.NDCH,
            this.DapanA,
            this.DapanB,
            this.DapanC,
            this.DapanD,
            this.DapanDung});
            this.dgrCauHoi.Location = new System.Drawing.Point(52, 548);
            this.dgrCauHoi.Name = "dgrCauHoi";
            this.dgrCauHoi.RowHeadersWidth = 82;
            this.dgrCauHoi.RowTemplate.Height = 33;
            this.dgrCauHoi.Size = new System.Drawing.Size(1199, 189);
            this.dgrCauHoi.TabIndex = 7;
            // 
            // MaCH
            // 
            this.MaCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaCH.HeaderText = "Mã câu hỏi";
            this.MaCH.MinimumWidth = 10;
            this.MaCH.Name = "MaCH";
            this.MaCH.Width = 163;
            // 
            // MonThi
            // 
            this.MonThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MonThi.HeaderText = "Môn thi";
            this.MonThi.MinimumWidth = 10;
            this.MonThi.Name = "MonThi";
            this.MonThi.Width = 128;
            // 
            // NDCH
            // 
            this.NDCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NDCH.HeaderText = "Nội dung câu hỏi";
            this.NDCH.MinimumWidth = 10;
            this.NDCH.Name = "NDCH";
            this.NDCH.Width = 175;
            // 
            // DapanA
            // 
            this.DapanA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DapanA.HeaderText = "Đáp án A";
            this.DapanA.MinimumWidth = 10;
            this.DapanA.Name = "DapanA";
            this.DapanA.Width = 123;
            // 
            // DapanB
            // 
            this.DapanB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DapanB.HeaderText = "Đáp án B";
            this.DapanB.MinimumWidth = 10;
            this.DapanB.Name = "DapanB";
            this.DapanB.Width = 123;
            // 
            // DapanC
            // 
            this.DapanC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DapanC.HeaderText = "Đáp án C";
            this.DapanC.MinimumWidth = 10;
            this.DapanC.Name = "DapanC";
            this.DapanC.Width = 123;
            // 
            // DapanD
            // 
            this.DapanD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DapanD.HeaderText = "Đáp án D";
            this.DapanD.MinimumWidth = 10;
            this.DapanD.Name = "DapanD";
            this.DapanD.Width = 123;
            // 
            // DapanDung
            // 
            this.DapanDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DapanDung.HeaderText = "Đáp án đúng";
            this.DapanDung.MinimumWidth = 10;
            this.DapanDung.Name = "DapanDung";
            this.DapanDung.Width = 166;
            // 
            // FrmManageQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 773);
            this.Controls.Add(this.dgrCauHoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbTTCH);
            this.Controls.Add(this.lblQLCH);
            this.Name = "FrmManageQuestion";
            this.Text = "FrmManageQuestion";
            this.grbTTCH.ResumeLayout(false);
            this.grbTTCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLCH;
        private System.Windows.Forms.GroupBox grbTTCH;
        private System.Windows.Forms.Label lblDapanD;
        private System.Windows.Forms.Label lblDapanB;
        private System.Windows.Forms.Label lblDapanC;
        private System.Windows.Forms.Label lblDapanA;
        private System.Windows.Forms.Label lblNDCH;
        private System.Windows.Forms.Label lbDapanDung;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblMaCH;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.ComboBox cbbDapanDung;
        private System.Windows.Forms.TextBox txtDapanB;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtNDCH;
        private System.Windows.Forms.TextBox txtDapanA;
        private System.Windows.Forms.TextBox txtDapanC;
        private System.Windows.Forms.TextBox txtDapanD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgrCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapanA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapanB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapanD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapanDung;
    }
}