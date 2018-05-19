namespace QuanLyPhongMay.Views
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.gpThongTinDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.labMatKhauMoi = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labMatKhauCu = new DevExpress.XtraEditors.LabelControl();
            this.labTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpThongTinDangNhap)).BeginInit();
            this.gpThongTinDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(255, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(236, 31);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Thay Đổi Mật Khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThoat.ImageOptions.ImageIndex = 5;
            this.btnThoat.Location = new System.Drawing.Point(411, 262);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDoiMatKhau.ImageOptions.ImageIndex = 12;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(210, 262);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(119, 37);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // gpThongTinDangNhap
            // 
            this.gpThongTinDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTinDangNhap.Appearance.Options.UseFont = true;
            this.gpThongTinDangNhap.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTinDangNhap.AppearanceCaption.Options.UseFont = true;
            this.gpThongTinDangNhap.Controls.Add(this.txtMatKhauMoi);
            this.gpThongTinDangNhap.Controls.Add(this.labMatKhauMoi);
            this.gpThongTinDangNhap.Controls.Add(this.txtMatKhauCu);
            this.gpThongTinDangNhap.Controls.Add(this.txtTenDangNhap);
            this.gpThongTinDangNhap.Controls.Add(this.labMatKhauCu);
            this.gpThongTinDangNhap.Controls.Add(this.labTenDangNhap);
            this.gpThongTinDangNhap.Location = new System.Drawing.Point(177, 68);
            this.gpThongTinDangNhap.Name = "gpThongTinDangNhap";
            this.gpThongTinDangNhap.Size = new System.Drawing.Size(389, 170);
            this.gpThongTinDangNhap.TabIndex = 4;
            this.gpThongTinDangNhap.Text = "Thông tin đăng nhập:";
            this.gpThongTinDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.gpThongTinDangNhap_Paint);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(157, 125);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(196, 20);
            this.txtMatKhauMoi.TabIndex = 3;
            // 
            // labMatKhauMoi
            // 
            this.labMatKhauMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatKhauMoi.Appearance.Options.UseFont = true;
            this.labMatKhauMoi.Location = new System.Drawing.Point(33, 124);
            this.labMatKhauMoi.Name = "labMatKhauMoi";
            this.labMatKhauMoi.Size = new System.Drawing.Size(90, 19);
            this.labMatKhauMoi.TabIndex = 2;
            this.labMatKhauMoi.Text = "Mật khẩu Mới:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(157, 89);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(196, 20);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(157, 51);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(196, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // labMatKhauCu
            // 
            this.labMatKhauCu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatKhauCu.Appearance.Options.UseFont = true;
            this.labMatKhauCu.Location = new System.Drawing.Point(33, 88);
            this.labMatKhauCu.Name = "labMatKhauCu";
            this.labMatKhauCu.Size = new System.Drawing.Size(83, 19);
            this.labMatKhauCu.TabIndex = 0;
            this.labMatKhauCu.Text = "Mật khẩu Cũ:";
            // 
            // labTenDangNhap
            // 
            this.labTenDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTenDangNhap.Appearance.Options.UseFont = true;
            this.labTenDangNhap.Location = new System.Drawing.Point(33, 50);
            this.labTenDangNhap.Name = "labTenDangNhap";
            this.labTenDangNhap.Size = new System.Drawing.Size(92, 19);
            this.labTenDangNhap.TabIndex = 0;
            this.labTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 317);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.gpThongTinDangNhap);
            this.Name = "frmDoiMatKhau";
            this.Text = "Thay Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpThongTinDangNhap)).EndInit();
            this.gpThongTinDangNhap.ResumeLayout(false);
            this.gpThongTinDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.GroupControl gpThongTinDangNhap;
        public DevExpress.XtraEditors.TextEdit txtMatKhauCu;
        public DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labMatKhauCu;
        private DevExpress.XtraEditors.LabelControl labTenDangNhap;
        public DevExpress.XtraEditors.TextEdit txtMatKhauMoi;
        private DevExpress.XtraEditors.LabelControl labMatKhauMoi;
    }
}