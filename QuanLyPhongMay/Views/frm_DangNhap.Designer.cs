namespace QuanLyPhongMay.Views
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.gpThongTinDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.labTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.hyplQuenMatKhau = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chkGhiNho = new DevExpress.XtraEditors.CheckEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.imgDangNhap = new DevExpress.Utils.ImageCollection(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gpThongTinDangNhap)).BeginInit();
            this.gpThongTinDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGhiNho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpThongTinDangNhap
            // 
            this.gpThongTinDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTinDangNhap.Appearance.Options.UseFont = true;
            this.gpThongTinDangNhap.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongTinDangNhap.AppearanceCaption.Options.UseFont = true;
            this.gpThongTinDangNhap.Controls.Add(this.chkGhiNho);
            this.gpThongTinDangNhap.Controls.Add(this.hyplQuenMatKhau);
            this.gpThongTinDangNhap.Controls.Add(this.txtMatKhau);
            this.gpThongTinDangNhap.Controls.Add(this.txtTenDangNhap);
            this.gpThongTinDangNhap.Controls.Add(this.labMatKhau);
            this.gpThongTinDangNhap.Controls.Add(this.labTenDangNhap);
            this.gpThongTinDangNhap.Location = new System.Drawing.Point(171, 74);
            this.gpThongTinDangNhap.Name = "gpThongTinDangNhap";
            this.gpThongTinDangNhap.Size = new System.Drawing.Size(389, 170);
            this.gpThongTinDangNhap.TabIndex = 0;
            this.gpThongTinDangNhap.Text = "Thông tin đăng nhập:";
            this.gpThongTinDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.gpThongTinDangNhap_Paint);
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
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(157, 51);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(196, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // labMatKhau
            // 
            this.labMatKhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatKhau.Appearance.Options.UseFont = true;
            this.labMatKhau.Location = new System.Drawing.Point(33, 88);
            this.labMatKhau.Name = "labMatKhau";
            this.labMatKhau.Size = new System.Drawing.Size(61, 19);
            this.labMatKhau.TabIndex = 0;
            this.labMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(157, 89);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(196, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // hyplQuenMatKhau
            // 
            this.hyplQuenMatKhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyplQuenMatKhau.Appearance.Options.UseFont = true;
            this.hyplQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyplQuenMatKhau.Location = new System.Drawing.Point(78, 136);
            this.hyplQuenMatKhau.Name = "hyplQuenMatKhau";
            this.hyplQuenMatKhau.Size = new System.Drawing.Size(108, 15);
            this.hyplQuenMatKhau.TabIndex = 2;
            this.hyplQuenMatKhau.Text = "Bạn quên mật khẩu?";
            // 
            // chkGhiNho
            // 
            this.chkGhiNho.Location = new System.Drawing.Point(234, 137);
            this.chkGhiNho.Name = "chkGhiNho";
            this.chkGhiNho.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGhiNho.Properties.Appearance.Options.UseFont = true;
            this.chkGhiNho.Properties.Caption = "Ghi nhớ tài khoản";
            this.chkGhiNho.Size = new System.Drawing.Size(119, 19);
            this.chkGhiNho.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDangNhap.ImageOptions.ImageIndex = 12;
            this.btnDangNhap.ImageOptions.ImageList = this.imgDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(204, 268);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(119, 37);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng Nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThoat.ImageOptions.ImageIndex = 5;
            this.btnThoat.ImageOptions.ImageList = this.imgDangNhap;
            this.btnThoat.Location = new System.Drawing.Point(405, 268);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 37);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            // 
            // imgDangNhap
            // 
            this.imgDangNhap.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgDangNhap.ImageStream")));
            this.imgDangNhap.Images.SetKeyName(0, "Bookmark-delete-icon.png");
            this.imgDangNhap.Images.SetKeyName(1, "Delete-group-icon.png");
            this.imgDangNhap.Images.SetKeyName(2, "Login.ico");
            this.imgDangNhap.Images.SetKeyName(3, "networkexplorer_dll_20_10.ico");
            this.imgDangNhap.Images.SetKeyName(4, "Apps-preferences-system-login-icon.png");
            this.imgDangNhap.Images.SetKeyName(5, "Bookmark-delete-icon.png");
            this.imgDangNhap.Images.SetKeyName(6, "Delete-group-icon.png");
            this.imgDangNhap.Images.SetKeyName(7, "huy.png");
            this.imgDangNhap.Images.SetKeyName(8, "Login.ico");
            this.imgDangNhap.Images.SetKeyName(9, "networkexplorer_dll_20_10.ico");
            this.imgDangNhap.Images.SetKeyName(10, "PhanQuyen.png");
            this.imgDangNhap.Images.SetKeyName(11, "thoat.png");
            this.imgDangNhap.Images.SetKeyName(12, "unlock-icon.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(249, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 31);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 317);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.gpThongTinDangNhap);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gpThongTinDangNhap)).EndInit();
            this.gpThongTinDangNhap.ResumeLayout(false);
            this.gpThongTinDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGhiNho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpThongTinDangNhap;
        private DevExpress.XtraEditors.CheckEdit chkGhiNho;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyplQuenMatKhau;
        private DevExpress.XtraEditors.LabelControl labMatKhau;
        private DevExpress.XtraEditors.LabelControl labTenDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.Utils.ImageCollection imgDangNhap;
        public DevExpress.XtraEditors.TextEdit txtMatKhau;
        public DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}