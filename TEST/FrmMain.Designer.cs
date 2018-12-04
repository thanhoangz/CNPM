namespace TEST
{
    partial class FrmMain
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Title = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_ChucNang = new System.Windows.Forms.Panel();
            this.panel_Select = new System.Windows.Forms.Panel();
            this.btn_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_NutMeNu = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHeThong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThanhToan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDonThuoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDichVu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyNVBS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyThuoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyLichHen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyBenhNhan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_HienThi = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.transition_Menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transition_AnhGai = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel_ChucNang.SuspendLayout();
            this.panel_NutMeNu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.panel_Title.Controls.Add(this.bunifuImageButton3);
            this.panel_Title.Controls.Add(this.bunifuImageButton2);
            this.panel_Title.Controls.Add(this.bunifuCustomLabel1);
            this.transition_AnhGai.SetDecoration(this.panel_Title, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_Title, BunifuAnimatorNS.DecorationType.None);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1200, 32);
            this.panel_Title.TabIndex = 0;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.transition_AnhGai.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1132, 4);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.transition_AnhGai.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1163, 4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.transition_Menu.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.transition_AnhGai.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(119, 16);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Nha Khoa Gia Bảo";
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.Controls.Add(this.panel_Select);
            this.panel_ChucNang.Controls.Add(this.btn_home);
            this.panel_ChucNang.Controls.Add(this.panel_NutMeNu);
            this.panel_ChucNang.Controls.Add(this.btnHeThong);
            this.panel_ChucNang.Controls.Add(this.btnThanhToan);
            this.panel_ChucNang.Controls.Add(this.btnThongKe);
            this.panel_ChucNang.Controls.Add(this.btnDonThuoc);
            this.panel_ChucNang.Controls.Add(this.btnDichVu);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyNVBS);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyThuoc);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyLichHen);
            this.panel_ChucNang.Controls.Add(this.btnQuanLyBenhNhan);
            this.transition_AnhGai.SetDecoration(this.panel_ChucNang, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_ChucNang, BunifuAnimatorNS.DecorationType.None);
            this.panel_ChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ChucNang.Location = new System.Drawing.Point(0, 32);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Size = new System.Drawing.Size(245, 634);
            this.panel_ChucNang.TabIndex = 1;
            // 
            // panel_Select
            // 
            this.panel_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.transition_AnhGai.SetDecoration(this.panel_Select, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_Select, BunifuAnimatorNS.DecorationType.None);
            this.panel_Select.Location = new System.Drawing.Point(0, 58);
            this.panel_Select.Name = "panel_Select";
            this.panel_Select.Size = new System.Drawing.Size(6, 39);
            this.panel_Select.TabIndex = 4;
            // 
            // btn_home
            // 
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = "    Home";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btn_home, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btn_home, BunifuAnimatorNS.DecorationType.None);
            this.btn_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_home.Iconimage")));
            this.btn_home.Iconimage_right = null;
            this.btn_home.Iconimage_right_Selected = null;
            this.btn_home.Iconimage_Selected = null;
            this.btn_home.IconMarginLeft = 0;
            this.btn_home.IconMarginRight = 0;
            this.btn_home.IconRightVisible = true;
            this.btn_home.IconRightZoom = 0D;
            this.btn_home.IconVisible = true;
            this.btn_home.IconZoom = 60D;
            this.btn_home.IsTab = false;
            this.btn_home.Location = new System.Drawing.Point(0, 57);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_home.selected = true;
            this.btn_home.Size = new System.Drawing.Size(245, 41);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "    Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Textcolor = System.Drawing.Color.LightGray;
            this.btn_home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_NutMeNu
            // 
            this.panel_NutMeNu.Controls.Add(this.btnMenu);
            this.transition_AnhGai.SetDecoration(this.panel_NutMeNu, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_NutMeNu, BunifuAnimatorNS.DecorationType.None);
            this.panel_NutMeNu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NutMeNu.Location = new System.Drawing.Point(0, 0);
            this.panel_NutMeNu.Name = "panel_NutMeNu";
            this.panel_NutMeNu.Size = new System.Drawing.Size(245, 33);
            this.panel_NutMeNu.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.transition_AnhGai.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(204, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(41, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeThong.BorderRadius = 0;
            this.btnHeThong.ButtonText = "    Hệ thống";
            this.btnHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnHeThong, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnHeThong, BunifuAnimatorNS.DecorationType.None);
            this.btnHeThong.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeThong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeThong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Iconimage")));
            this.btnHeThong.Iconimage_right = null;
            this.btnHeThong.Iconimage_right_Selected = null;
            this.btnHeThong.Iconimage_Selected = null;
            this.btnHeThong.IconMarginLeft = 0;
            this.btnHeThong.IconMarginRight = 0;
            this.btnHeThong.IconRightVisible = true;
            this.btnHeThong.IconRightZoom = 0D;
            this.btnHeThong.IconVisible = true;
            this.btnHeThong.IconZoom = 60D;
            this.btnHeThong.IsTab = false;
            this.btnHeThong.Location = new System.Drawing.Point(0, 478);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnHeThong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnHeThong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHeThong.selected = false;
            this.btnHeThong.Size = new System.Drawing.Size(245, 41);
            this.btnHeThong.TabIndex = 2;
            this.btnHeThong.Text = "    Hệ thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.Textcolor = System.Drawing.Color.LightGray;
            this.btnHeThong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.BorderRadius = 0;
            this.btnThanhToan.ButtonText = "    Thanh toán";
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnThanhToan, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnThanhToan, BunifuAnimatorNS.DecorationType.None);
            this.btnThanhToan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThanhToan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Iconimage")));
            this.btnThanhToan.Iconimage_right = null;
            this.btnThanhToan.Iconimage_right_Selected = null;
            this.btnThanhToan.Iconimage_Selected = null;
            this.btnThanhToan.IconMarginLeft = 0;
            this.btnThanhToan.IconMarginRight = 0;
            this.btnThanhToan.IconRightVisible = true;
            this.btnThanhToan.IconRightZoom = 0D;
            this.btnThanhToan.IconVisible = true;
            this.btnThanhToan.IconZoom = 60D;
            this.btnThanhToan.IsTab = false;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 431);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnThanhToan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnThanhToan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThanhToan.selected = false;
            this.btnThanhToan.Size = new System.Drawing.Size(245, 41);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "    Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Textcolor = System.Drawing.Color.LightGray;
            this.btnThanhToan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.BorderRadius = 0;
            this.btnThongKe.ButtonText = "    Thống kê";
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.btnThongKe.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKe.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Iconimage")));
            this.btnThongKe.Iconimage_right = null;
            this.btnThongKe.Iconimage_right_Selected = null;
            this.btnThongKe.Iconimage_Selected = null;
            this.btnThongKe.IconMarginLeft = 0;
            this.btnThongKe.IconMarginRight = 0;
            this.btnThongKe.IconRightVisible = true;
            this.btnThongKe.IconRightZoom = 0D;
            this.btnThongKe.IconVisible = true;
            this.btnThongKe.IconZoom = 60D;
            this.btnThongKe.IsTab = false;
            this.btnThongKe.Location = new System.Drawing.Point(0, 386);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnThongKe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnThongKe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKe.selected = false;
            this.btnThongKe.Size = new System.Drawing.Size(245, 41);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "    Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Textcolor = System.Drawing.Color.LightGray;
            this.btnThongKe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDonThuoc
            // 
            this.btnDonThuoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnDonThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnDonThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDonThuoc.BorderRadius = 0;
            this.btnDonThuoc.ButtonText = "    Tạo đơn thuốc";
            this.btnDonThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnDonThuoc, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnDonThuoc, BunifuAnimatorNS.DecorationType.None);
            this.btnDonThuoc.DisabledColor = System.Drawing.Color.Gray;
            this.btnDonThuoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDonThuoc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDonThuoc.Iconimage")));
            this.btnDonThuoc.Iconimage_right = null;
            this.btnDonThuoc.Iconimage_right_Selected = null;
            this.btnDonThuoc.Iconimage_Selected = null;
            this.btnDonThuoc.IconMarginLeft = 0;
            this.btnDonThuoc.IconMarginRight = 0;
            this.btnDonThuoc.IconRightVisible = true;
            this.btnDonThuoc.IconRightZoom = 0D;
            this.btnDonThuoc.IconVisible = true;
            this.btnDonThuoc.IconZoom = 60D;
            this.btnDonThuoc.IsTab = false;
            this.btnDonThuoc.Location = new System.Drawing.Point(0, 339);
            this.btnDonThuoc.Name = "btnDonThuoc";
            this.btnDonThuoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnDonThuoc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnDonThuoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDonThuoc.selected = false;
            this.btnDonThuoc.Size = new System.Drawing.Size(245, 41);
            this.btnDonThuoc.TabIndex = 2;
            this.btnDonThuoc.Text = "    Tạo đơn thuốc";
            this.btnDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonThuoc.Textcolor = System.Drawing.Color.LightGray;
            this.btnDonThuoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonThuoc.Click += new System.EventHandler(this.btnDonThuoc_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDichVu.BorderRadius = 0;
            this.btnDichVu.ButtonText = "    Quản lý dịch vụ";
            this.btnDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnDichVu, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnDichVu, BunifuAnimatorNS.DecorationType.None);
            this.btnDichVu.DisabledColor = System.Drawing.Color.Gray;
            this.btnDichVu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDichVu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Iconimage")));
            this.btnDichVu.Iconimage_right = null;
            this.btnDichVu.Iconimage_right_Selected = null;
            this.btnDichVu.Iconimage_Selected = null;
            this.btnDichVu.IconMarginLeft = 0;
            this.btnDichVu.IconMarginRight = 0;
            this.btnDichVu.IconRightVisible = true;
            this.btnDichVu.IconRightZoom = 0D;
            this.btnDichVu.IconVisible = true;
            this.btnDichVu.IconZoom = 60D;
            this.btnDichVu.IsTab = false;
            this.btnDichVu.Location = new System.Drawing.Point(0, 292);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnDichVu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnDichVu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDichVu.selected = false;
            this.btnDichVu.Size = new System.Drawing.Size(245, 41);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "    Quản lý dịch vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Textcolor = System.Drawing.Color.LightGray;
            this.btnDichVu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnQuanLyNVBS
            // 
            this.btnQuanLyNVBS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnQuanLyNVBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyNVBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNVBS.BorderRadius = 0;
            this.btnQuanLyNVBS.ButtonText = "    Quản lý nhân viên bác sĩ";
            this.btnQuanLyNVBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyNVBS, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyNVBS, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyNVBS.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyNVBS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyNVBS.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNVBS.Iconimage")));
            this.btnQuanLyNVBS.Iconimage_right = null;
            this.btnQuanLyNVBS.Iconimage_right_Selected = null;
            this.btnQuanLyNVBS.Iconimage_Selected = null;
            this.btnQuanLyNVBS.IconMarginLeft = 0;
            this.btnQuanLyNVBS.IconMarginRight = 0;
            this.btnQuanLyNVBS.IconRightVisible = true;
            this.btnQuanLyNVBS.IconRightZoom = 0D;
            this.btnQuanLyNVBS.IconVisible = true;
            this.btnQuanLyNVBS.IconZoom = 60D;
            this.btnQuanLyNVBS.IsTab = false;
            this.btnQuanLyNVBS.Location = new System.Drawing.Point(0, 245);
            this.btnQuanLyNVBS.Name = "btnQuanLyNVBS";
            this.btnQuanLyNVBS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyNVBS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyNVBS.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyNVBS.selected = false;
            this.btnQuanLyNVBS.Size = new System.Drawing.Size(245, 41);
            this.btnQuanLyNVBS.TabIndex = 2;
            this.btnQuanLyNVBS.Text = "    Quản lý nhân viên bác sĩ";
            this.btnQuanLyNVBS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNVBS.Textcolor = System.Drawing.Color.LightGray;
            this.btnQuanLyNVBS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNVBS.Click += new System.EventHandler(this.btnQuanLyNVBS_Click);
            // 
            // btnQuanLyThuoc
            // 
            this.btnQuanLyThuoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnQuanLyThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyThuoc.BorderRadius = 0;
            this.btnQuanLyThuoc.ButtonText = "   Quản lý thuốc";
            this.btnQuanLyThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyThuoc, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyThuoc, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyThuoc.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyThuoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyThuoc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThuoc.Iconimage")));
            this.btnQuanLyThuoc.Iconimage_right = null;
            this.btnQuanLyThuoc.Iconimage_right_Selected = null;
            this.btnQuanLyThuoc.Iconimage_Selected = null;
            this.btnQuanLyThuoc.IconMarginLeft = 0;
            this.btnQuanLyThuoc.IconMarginRight = 0;
            this.btnQuanLyThuoc.IconRightVisible = true;
            this.btnQuanLyThuoc.IconRightZoom = 0D;
            this.btnQuanLyThuoc.IconVisible = true;
            this.btnQuanLyThuoc.IconZoom = 60D;
            this.btnQuanLyThuoc.IsTab = false;
            this.btnQuanLyThuoc.Location = new System.Drawing.Point(0, 198);
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyThuoc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyThuoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyThuoc.selected = false;
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(245, 41);
            this.btnQuanLyThuoc.TabIndex = 2;
            this.btnQuanLyThuoc.Text = "   Quản lý thuốc";
            this.btnQuanLyThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuoc.Textcolor = System.Drawing.Color.LightGray;
            this.btnQuanLyThuoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuoc.Click += new System.EventHandler(this.btnQuanLyThuoc_Click);
            // 
            // btnQuanLyLichHen
            // 
            this.btnQuanLyLichHen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnQuanLyLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyLichHen.BorderRadius = 0;
            this.btnQuanLyLichHen.ButtonText = "   Quản lý lịch hẹn";
            this.btnQuanLyLichHen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyLichHen, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyLichHen, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyLichHen.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyLichHen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyLichHen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyLichHen.Iconimage")));
            this.btnQuanLyLichHen.Iconimage_right = null;
            this.btnQuanLyLichHen.Iconimage_right_Selected = null;
            this.btnQuanLyLichHen.Iconimage_Selected = null;
            this.btnQuanLyLichHen.IconMarginLeft = 0;
            this.btnQuanLyLichHen.IconMarginRight = 0;
            this.btnQuanLyLichHen.IconRightVisible = true;
            this.btnQuanLyLichHen.IconRightZoom = 0D;
            this.btnQuanLyLichHen.IconVisible = true;
            this.btnQuanLyLichHen.IconZoom = 60D;
            this.btnQuanLyLichHen.IsTab = false;
            this.btnQuanLyLichHen.Location = new System.Drawing.Point(0, 151);
            this.btnQuanLyLichHen.Name = "btnQuanLyLichHen";
            this.btnQuanLyLichHen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyLichHen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyLichHen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyLichHen.selected = false;
            this.btnQuanLyLichHen.Size = new System.Drawing.Size(245, 41);
            this.btnQuanLyLichHen.TabIndex = 1;
            this.btnQuanLyLichHen.Text = "   Quản lý lịch hẹn";
            this.btnQuanLyLichHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLichHen.Textcolor = System.Drawing.Color.LightGray;
            this.btnQuanLyLichHen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLichHen.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnQuanLyBenhNhan
            // 
            this.btnQuanLyBenhNhan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.btnQuanLyBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyBenhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyBenhNhan.BorderRadius = 0;
            this.btnQuanLyBenhNhan.ButtonText = "   Quản lý bệnh nhân";
            this.btnQuanLyBenhNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_AnhGai.SetDecoration(this.btnQuanLyBenhNhan, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.btnQuanLyBenhNhan, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyBenhNhan.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyBenhNhan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyBenhNhan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyBenhNhan.Iconimage")));
            this.btnQuanLyBenhNhan.Iconimage_right = null;
            this.btnQuanLyBenhNhan.Iconimage_right_Selected = null;
            this.btnQuanLyBenhNhan.Iconimage_Selected = null;
            this.btnQuanLyBenhNhan.IconMarginLeft = 0;
            this.btnQuanLyBenhNhan.IconMarginRight = 0;
            this.btnQuanLyBenhNhan.IconRightVisible = true;
            this.btnQuanLyBenhNhan.IconRightZoom = 0D;
            this.btnQuanLyBenhNhan.IconVisible = true;
            this.btnQuanLyBenhNhan.IconZoom = 60D;
            this.btnQuanLyBenhNhan.IsTab = false;
            this.btnQuanLyBenhNhan.Location = new System.Drawing.Point(0, 104);
            this.btnQuanLyBenhNhan.Name = "btnQuanLyBenhNhan";
            this.btnQuanLyBenhNhan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyBenhNhan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnQuanLyBenhNhan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyBenhNhan.selected = false;
            this.btnQuanLyBenhNhan.Size = new System.Drawing.Size(245, 41);
            this.btnQuanLyBenhNhan.TabIndex = 0;
            this.btnQuanLyBenhNhan.Text = "   Quản lý bệnh nhân";
            this.btnQuanLyBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyBenhNhan.Textcolor = System.Drawing.Color.LightGray;
            this.btnQuanLyBenhNhan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBenhNhan.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel_HienThi
            // 
            this.panel_HienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.transition_AnhGai.SetDecoration(this.panel_HienThi, BunifuAnimatorNS.DecorationType.None);
            this.transition_Menu.SetDecoration(this.panel_HienThi, BunifuAnimatorNS.DecorationType.None);
            this.panel_HienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_HienThi.Location = new System.Drawing.Point(245, 32);
            this.panel_HienThi.Name = "panel_HienThi";
            this.panel_HienThi.Size = new System.Drawing.Size(955, 634);
            this.panel_HienThi.TabIndex = 2;
            // 
            // transition_Menu
            // 
            this.transition_Menu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transition_Menu.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.transition_Menu.DefaultAnimation = animation6;
            // 
            // transition_AnhGai
            // 
            this.transition_AnhGai.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.transition_AnhGai.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 20;
            animation5.Padding = new System.Windows.Forms.Padding(30);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.transition_AnhGai.DefaultAnimation = animation5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1200, 666);
            this.Controls.Add(this.panel_HienThi);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.panel_Title);
            this.transition_Menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transition_AnhGai.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel_ChucNang.ResumeLayout(false);
            this.panel_NutMeNu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_HienThi;
        private System.Windows.Forms.Panel panel_ChucNang;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyBenhNhan;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKe;
        private Bunifu.Framework.UI.BunifuFlatButton btnDonThuoc;
        private Bunifu.Framework.UI.BunifuFlatButton btnDichVu;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyNVBS;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyThuoc;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuanLyLichHen;
        private System.Windows.Forms.Panel panel_Select;
        private Bunifu.Framework.UI.BunifuFlatButton btnHeThong;
        private Bunifu.Framework.UI.BunifuFlatButton btnThanhToan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BunifuAnimatorNS.BunifuTransition transition_Menu;
        private System.Windows.Forms.Panel panel_NutMeNu;
        private Bunifu.Framework.UI.BunifuFlatButton btn_home;
        private BunifuAnimatorNS.BunifuTransition transition_AnhGai;
    }
}