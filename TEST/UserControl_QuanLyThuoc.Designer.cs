namespace TEST
{
    partial class UserControl_QuanLyThuoc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_QuanLyThuoc));
            this.panel_Title_BenhNhan = new System.Windows.Forms.Panel();
            this.panel_HienThi_QLBN = new System.Windows.Forms.Panel();
            this.DataGrid_QuanLyThuoc = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel_HienThi_QLBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title_BenhNhan
            // 
            this.panel_Title_BenhNhan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Title_BenhNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title_BenhNhan.Location = new System.Drawing.Point(0, 0);
            this.panel_Title_BenhNhan.Name = "panel_Title_BenhNhan";
            this.panel_Title_BenhNhan.Size = new System.Drawing.Size(955, 26);
            this.panel_Title_BenhNhan.TabIndex = 0;
            // 
            // panel_HienThi_QLBN
            // 
            this.panel_HienThi_QLBN.Controls.Add(this.DataGrid_QuanLyThuoc);
            this.panel_HienThi_QLBN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_HienThi_QLBN.Location = new System.Drawing.Point(0, 178);
            this.panel_HienThi_QLBN.Name = "panel_HienThi_QLBN";
            this.panel_HienThi_QLBN.Size = new System.Drawing.Size(955, 456);
            this.panel_HienThi_QLBN.TabIndex = 1;
            // 
            // DataGrid_QuanLyThuoc
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_QuanLyThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.DataGrid_QuanLyThuoc.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_QuanLyThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_QuanLyThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(18)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_QuanLyThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DataGrid_QuanLyThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QuanLyThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lol,
            this.Cax});
            this.DataGrid_QuanLyThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_QuanLyThuoc.DoubleBuffered = true;
            this.DataGrid_QuanLyThuoc.EnableHeadersVisualStyles = false;
            this.DataGrid_QuanLyThuoc.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(18)))), ((int)(((byte)(137)))));
            this.DataGrid_QuanLyThuoc.HeaderForeColor = System.Drawing.Color.Empty;
            this.DataGrid_QuanLyThuoc.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_QuanLyThuoc.Name = "DataGrid_QuanLyThuoc";
            this.DataGrid_QuanLyThuoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_QuanLyThuoc.Size = new System.Drawing.Size(955, 456);
            this.DataGrid_QuanLyThuoc.TabIndex = 0;
            // 
            // lol
            // 
            this.lol.HeaderText = "Column1";
            this.lol.Name = "lol";
            // 
            // Cax
            // 
            this.Cax.HeaderText = "Cặc";
            this.Cax.Name = "Cax";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.txtTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.BackgroundImage")));
            this.txtTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.Icon")));
            this.txtTimKiem.Location = new System.Drawing.Point(579, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(373, 34);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.text = "Bunifu TextBox";
            this.toolTip1.SetToolTip(this.txtTimKiem, "Tìm kiếm");
            this.txtTimKiem.OnTextChange += new System.EventHandler(this.txtTimKiem_OnTextChange);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(411, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 34);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Thêm");
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(467, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 34);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 3;
            this.btnEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEdit, "Sửa");
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(523, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 34);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa");
            this.btnDelete.Zoom = 10;
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(360, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản lý thuốc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.panel_HienThi_QLBN);
            this.Controls.Add(this.panel_Title_BenhNhan);
            this.Name = "UserControl_QuanLyThuoc";
            this.Size = new System.Drawing.Size(955, 634);
            this.Load += new System.EventHandler(this.UserControl_QuanLyThuoc_Load);
            this.Resize += new System.EventHandler(this.UserControl_QuanLyThuoc_Resize);
            this.panel_HienThi_QLBN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title_BenhNhan;
        private System.Windows.Forms.Panel panel_HienThi_QLBN;
        private Bunifu.Framework.UI.BunifuTextbox txtTimKiem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_QuanLyThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cax;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}
