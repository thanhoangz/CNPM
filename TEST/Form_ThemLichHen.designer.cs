namespace TEST
{
    partial class Form_ThemLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThemLichHen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenLichHen = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lbl_NgayHen = new System.Windows.Forms.Label();
            this.dtp_NgayHen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaBenhNhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_GioHen = new System.Windows.Forms.DateTimePicker();
            this.bnt_OkThemLichHen = new System.Windows.Forms.Button();
            this.bnt_CancelThemLichHen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaLichHen = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 31);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txt_MaLichHen);
            this.groupBox1.Controls.Add(this.dtp_GioHen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_TenLichHen);
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.lbl_NgayHen);
            this.groupBox1.Controls.Add(this.dtp_NgayHen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_MaBenhNhan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 294);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lịch Hẹn";
            // 
            // txt_TenLichHen
            // 
            this.txt_TenLichHen.Location = new System.Drawing.Point(129, 58);
            this.txt_TenLichHen.Name = "txt_TenLichHen";
            this.txt_TenLichHen.Size = new System.Drawing.Size(211, 21);
            this.txt_TenLichHen.TabIndex = 1;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(129, 165);
            this.txtDonViTinh.Multiline = true;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(211, 102);
            this.txtDonViTinh.TabIndex = 3;
            // 
            // lbl_NgayHen
            // 
            this.lbl_NgayHen.AutoSize = true;
            this.lbl_NgayHen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayHen.Location = new System.Drawing.Point(33, 111);
            this.lbl_NgayHen.Name = "lbl_NgayHen";
            this.lbl_NgayHen.Size = new System.Drawing.Size(61, 15);
            this.lbl_NgayHen.TabIndex = 1;
            this.lbl_NgayHen.Text = "Ngày Hẹn";
            // 
            // dtp_NgayHen
            // 
            this.dtp_NgayHen.CustomFormat = "dd/MM/yyy";
            this.dtp_NgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayHen.Location = new System.Drawing.Point(129, 111);
            this.dtp_NgayHen.Name = "dtp_NgayHen";
            this.dtp_NgayHen.Size = new System.Drawing.Size(211, 21);
            this.dtp_NgayHen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lịch Hẹn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Bệnh Nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi Chú";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_MaBenhNhan
            // 
            this.txt_MaBenhNhan.Location = new System.Drawing.Point(129, 84);
            this.txt_MaBenhNhan.Name = "txt_MaBenhNhan";
            this.txt_MaBenhNhan.Size = new System.Drawing.Size(211, 21);
            this.txt_MaBenhNhan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giờ Hẹn";
            // 
            // dtp_GioHen
            // 
            this.dtp_GioHen.CustomFormat = "hh:mm:ss";
            this.dtp_GioHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_GioHen.Location = new System.Drawing.Point(129, 138);
            this.dtp_GioHen.Name = "dtp_GioHen";
            this.dtp_GioHen.Size = new System.Drawing.Size(211, 21);
            this.dtp_GioHen.TabIndex = 6;
            // 
            // bnt_OkThemLichHen
            // 
            this.bnt_OkThemLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_OkThemLichHen.Location = new System.Drawing.Point(99, 370);
            this.bnt_OkThemLichHen.Name = "bnt_OkThemLichHen";
            this.bnt_OkThemLichHen.Size = new System.Drawing.Size(83, 32);
            this.bnt_OkThemLichHen.TabIndex = 8;
            this.bnt_OkThemLichHen.Text = "Ok";
            this.bnt_OkThemLichHen.UseVisualStyleBackColor = true;
            // 
            // bnt_CancelThemLichHen
            // 
            this.bnt_CancelThemLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_CancelThemLichHen.Location = new System.Drawing.Point(254, 370);
            this.bnt_CancelThemLichHen.Name = "bnt_CancelThemLichHen";
            this.bnt_CancelThemLichHen.Size = new System.Drawing.Size(81, 32);
            this.bnt_CancelThemLichHen.TabIndex = 9;
            this.bnt_CancelThemLichHen.Text = "Cancel";
            this.bnt_CancelThemLichHen.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thêm Lịch Hẹn";
            // 
            // txt_MaLichHen
            // 
            this.txt_MaLichHen.Location = new System.Drawing.Point(129, 32);
            this.txt_MaLichHen.Name = "txt_MaLichHen";
            this.txt_MaLichHen.Size = new System.Drawing.Size(211, 21);
            this.txt_MaLichHen.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(33, 32);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 15);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Mã Lịch Hẹn";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(12, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(16)))), ((int)(((byte)(118)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(405, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Form_ThemLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 432);
            this.Controls.Add(this.bnt_CancelThemLichHen);
            this.Controls.Add(this.bnt_OkThemLichHen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ThemLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_ThemLichHen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenLichHen;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lbl_NgayHen;
        private System.Windows.Forms.DateTimePicker dtp_NgayHen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaBenhNhan;
        private System.Windows.Forms.DateTimePicker dtp_GioHen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_CancelThemLichHen;
        private System.Windows.Forms.Button bnt_OkThemLichHen;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txt_MaLichHen;
    }
}