namespace TEST
{
    partial class UserControl_QuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_QuanLyDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Title_DichVu = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_HienThi_QLDV = new System.Windows.Forms.Panel();
            this.DataGrid_QuanLyDichVu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.panel_HienThi_QLDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title_DichVu
            // 
            this.panel_Title_DichVu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Title_DichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title_DichVu.Location = new System.Drawing.Point(0, 0);
            this.panel_Title_DichVu.Name = "panel_Title_DichVu";
            this.panel_Title_DichVu.Size = new System.Drawing.Size(955, 26);
            this.panel_Title_DichVu.TabIndex = 5;
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
            this.btnDelete.TabIndex = 10;
            this.btnDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa");
            this.btnDelete.Zoom = 10;
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
            this.btnEdit.TabIndex = 9;
            this.btnEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEdit, "Sửa");
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Thêm");
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.text = "Bunifu TextBox";
            this.toolTip1.SetToolTip(this.txtTimKiem, "Tìm kiếm");
            // 
            // panel_HienThi_QLDV
            // 
            this.panel_HienThi_QLDV.Controls.Add(this.DataGrid_QuanLyDichVu);
            this.panel_HienThi_QLDV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_HienThi_QLDV.Location = new System.Drawing.Point(0, 178);
            this.panel_HienThi_QLDV.Name = "panel_HienThi_QLDV";
            this.panel_HienThi_QLDV.Size = new System.Drawing.Size(955, 456);
            this.panel_HienThi_QLDV.TabIndex = 7;
            // 
            // DataGrid_QuanLyDichVu
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_QuanLyDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_QuanLyDichVu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_QuanLyDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_QuanLyDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(18)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_QuanLyDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_QuanLyDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QuanLyDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lol,
            this.Cax});
            this.DataGrid_QuanLyDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_QuanLyDichVu.DoubleBuffered = true;
            this.DataGrid_QuanLyDichVu.EnableHeadersVisualStyles = false;
            this.DataGrid_QuanLyDichVu.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(18)))), ((int)(((byte)(137)))));
            this.DataGrid_QuanLyDichVu.HeaderForeColor = System.Drawing.Color.Empty;
            this.DataGrid_QuanLyDichVu.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_QuanLyDichVu.Name = "DataGrid_QuanLyDichVu";
            this.DataGrid_QuanLyDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_QuanLyDichVu.Size = new System.Drawing.Size(955, 456);
            this.DataGrid_QuanLyDichVu.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(322, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý dịch vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl_QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_HienThi_QLDV);
            this.Controls.Add(this.panel_Title_DichVu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "UserControl_QuanLyDichVu";
            this.Size = new System.Drawing.Size(955, 634);
            this.Load += new System.EventHandler(this.UserControl_QuanLyDichVu_Load);
            this.Resize += new System.EventHandler(this.UserControl_QuanLyDichVu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.panel_HienThi_QLDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Title_DichVu;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuTextbox txtTimKiem;
        private System.Windows.Forms.Panel panel_HienThi_QLDV;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_QuanLyDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn lol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cax;
        private System.Windows.Forms.Label label1;
    }
}
