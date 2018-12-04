namespace TEST
{
    partial class UserControl_LichHen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_LichHen));
            this.panel_Title_LichHen = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLichHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLichHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_XoaLichHen = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnt_SuaLichHen = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_TimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.bnt_ThemLichHen = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_XoaLichHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_SuaLichHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_ThemLichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title_LichHen
            // 
            this.panel_Title_LichHen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Title_LichHen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title_LichHen.Location = new System.Drawing.Point(0, 0);
            this.panel_Title_LichHen.Name = "panel_Title_LichHen";
            this.panel_Title_LichHen.Size = new System.Drawing.Size(955, 26);
            this.panel_Title_LichHen.TabIndex = 1;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(18)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaBenhNhan,
            this.NgayHen,
            this.GioHen,
            this.TenLichHen,
            this.MaLichHen,
            this.GhiChu});
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(18)))), ((int)(((byte)(137)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(955, 456);
            this.bunifuCustomDataGrid1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 456);
            this.panel1.TabIndex = 10;
            // 
            // STT
            // 
            this.STT.FillWeight = 200F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.HeaderText = "Mã Bệnh Nhân";
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.Width = 130;
            // 
            // NgayHen
            // 
            this.NgayHen.HeaderText = "Ngày Hẹn";
            this.NgayHen.Name = "NgayHen";
            this.NgayHen.Width = 150;
            // 
            // GioHen
            // 
            this.GioHen.HeaderText = "Giờ Hẹn";
            this.GioHen.Name = "GioHen";
            this.GioHen.Width = 130;
            // 
            // TenLichHen
            // 
            this.TenLichHen.HeaderText = "Tên Lịch Hẹn";
            this.TenLichHen.Name = "TenLichHen";
            this.TenLichHen.Width = 130;
            // 
            // MaLichHen
            // 
            this.MaLichHen.HeaderText = "Mã Lịch Hẹn";
            this.MaLichHen.Name = "MaLichHen";
            this.MaLichHen.Width = 140;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 220;
            // 
            // bnt_XoaLichHen
            // 
            this.bnt_XoaLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.bnt_XoaLichHen.Image = ((System.Drawing.Image)(resources.GetObject("bnt_XoaLichHen.Image")));
            this.bnt_XoaLichHen.ImageActive = null;
            this.bnt_XoaLichHen.Location = new System.Drawing.Point(508, 32);
            this.bnt_XoaLichHen.Name = "bnt_XoaLichHen";
            this.bnt_XoaLichHen.Size = new System.Drawing.Size(50, 34);
            this.bnt_XoaLichHen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_XoaLichHen.TabIndex = 8;
            this.bnt_XoaLichHen.TabStop = false;
            this.bnt_XoaLichHen.Zoom = 10;
            this.bnt_XoaLichHen.Click += new System.EventHandler(this.bnt_XoaLichHen_Click);
            // 
            // bnt_SuaLichHen
            // 
            this.bnt_SuaLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.bnt_SuaLichHen.Image = ((System.Drawing.Image)(resources.GetObject("bnt_SuaLichHen.Image")));
            this.bnt_SuaLichHen.ImageActive = null;
            this.bnt_SuaLichHen.Location = new System.Drawing.Point(452, 32);
            this.bnt_SuaLichHen.Name = "bnt_SuaLichHen";
            this.bnt_SuaLichHen.Size = new System.Drawing.Size(50, 34);
            this.bnt_SuaLichHen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_SuaLichHen.TabIndex = 7;
            this.bnt_SuaLichHen.TabStop = false;
            this.bnt_SuaLichHen.Zoom = 10;
            this.bnt_SuaLichHen.Click += new System.EventHandler(this.bnt_SuaLichHen_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.txt_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_TimKiem.BackgroundImage")));
            this.txt_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_TimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txt_TimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("txt_TimKiem.Icon")));
            this.txt_TimKiem.Location = new System.Drawing.Point(579, 32);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(373, 34);
            this.txt_TimKiem.TabIndex = 5;
            this.txt_TimKiem.text = "Tìm Kiếm";
            // 
            // bnt_ThemLichHen
            // 
            this.bnt_ThemLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.bnt_ThemLichHen.Image = ((System.Drawing.Image)(resources.GetObject("bnt_ThemLichHen.Image")));
            this.bnt_ThemLichHen.ImageActive = null;
            this.bnt_ThemLichHen.Location = new System.Drawing.Point(396, 32);
            this.bnt_ThemLichHen.Name = "bnt_ThemLichHen";
            this.bnt_ThemLichHen.Size = new System.Drawing.Size(50, 34);
            this.bnt_ThemLichHen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_ThemLichHen.TabIndex = 6;
            this.bnt_ThemLichHen.TabStop = false;
            this.bnt_ThemLichHen.Zoom = 10;
            this.bnt_ThemLichHen.Click += new System.EventHandler(this.bnt_ThemLichHen_Click);
            // 
            // UserControl_LichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnt_XoaLichHen);
            this.Controls.Add(this.panel_Title_LichHen);
            this.Controls.Add(this.bnt_SuaLichHen);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.bnt_ThemLichHen);
            this.Name = "UserControl_LichHen";
            this.Size = new System.Drawing.Size(955, 634);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnt_XoaLichHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_SuaLichHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_ThemLichHen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title_LichHen;
        private Bunifu.Framework.UI.BunifuImageButton bnt_XoaLichHen;
        private Bunifu.Framework.UI.BunifuImageButton bnt_SuaLichHen;
        private Bunifu.Framework.UI.BunifuImageButton bnt_ThemLichHen;
        private Bunifu.Framework.UI.BunifuTextbox txt_TimKiem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}
