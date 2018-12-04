namespace TEST
{
    partial class UserControl_Account_System
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Account_System));
            this.pnl_Manage = new System.Windows.Forms.Panel();
            this.datagridview_Account = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_DeleteAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_ChangePassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_AddAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_Manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DeleteAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Manage
            // 
            this.pnl_Manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.pnl_Manage.Controls.Add(this.btn_DeleteAccount);
            this.pnl_Manage.Controls.Add(this.btn_ChangePassword);
            this.pnl_Manage.Controls.Add(this.btn_AddAccount);
            this.pnl_Manage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Manage.Location = new System.Drawing.Point(923, 0);
            this.pnl_Manage.Name = "pnl_Manage";
            this.pnl_Manage.Size = new System.Drawing.Size(32, 478);
            this.pnl_Manage.TabIndex = 2;
            // 
            // datagridview_Account
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_Account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_Account.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridview_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_Account.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_Account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_Account.DoubleBuffered = true;
            this.datagridview_Account.EnableHeadersVisualStyles = false;
            this.datagridview_Account.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.datagridview_Account.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.datagridview_Account.Location = new System.Drawing.Point(0, 0);
            this.datagridview_Account.Name = "datagridview_Account";
            this.datagridview_Account.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_Account.RowTemplate.Height = 24;
            this.datagridview_Account.Size = new System.Drawing.Size(923, 478);
            this.datagridview_Account.TabIndex = 3;
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteAccount.Image")));
            this.btn_DeleteAccount.ImageActive = null;
            this.btn_DeleteAccount.Location = new System.Drawing.Point(6, 455);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(20, 20);
            this.btn_DeleteAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_DeleteAccount.TabIndex = 0;
            this.btn_DeleteAccount.TabStop = false;
            this.btn_DeleteAccount.Zoom = 10;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangePassword.Image")));
            this.btn_ChangePassword.ImageActive = null;
            this.btn_ChangePassword.Location = new System.Drawing.Point(5, 429);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(20, 20);
            this.btn_ChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ChangePassword.TabIndex = 0;
            this.btn_ChangePassword.TabStop = false;
            this.btn_ChangePassword.Zoom = 10;
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddAccount.Image")));
            this.btn_AddAccount.ImageActive = null;
            this.btn_AddAccount.Location = new System.Drawing.Point(6, 403);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(20, 20);
            this.btn_AddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AddAccount.TabIndex = 0;
            this.btn_AddAccount.TabStop = false;
            this.btn_AddAccount.Zoom = 10;
            // 
            // UserControl_Account_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datagridview_Account);
            this.Controls.Add(this.pnl_Manage);
            this.Name = "UserControl_Account_System";
            this.Size = new System.Drawing.Size(955, 478);
            this.pnl_Manage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DeleteAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Manage;
        private Bunifu.Framework.UI.BunifuImageButton btn_DeleteAccount;
        private Bunifu.Framework.UI.BunifuImageButton btn_ChangePassword;
        private Bunifu.Framework.UI.BunifuImageButton btn_AddAccount;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridview_Account;
    }
}
