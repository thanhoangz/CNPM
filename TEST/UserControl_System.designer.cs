namespace TEST
{
    partial class UserControl_System
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_System));
            this.lbl_System = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.transition_System = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_System = new System.Windows.Forms.Panel();
            this.pnl_ManageSystem = new System.Windows.Forms.Panel();
            this.pnl_ControlSystem = new System.Windows.Forms.Panel();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.lbl_TroGiup = new System.Windows.Forms.Label();
            this.separatorChoose = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnl_System.SuspendLayout();
            this.pnl_ControlSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_System
            // 
            this.lbl_System.AutoSize = true;
            this.transition_System.SetDecoration(this.lbl_System, BunifuAnimatorNS.DecorationType.None);
            this.lbl_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_System.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_System.Location = new System.Drawing.Point(348, 3);
            this.lbl_System.Name = "lbl_System";
            this.lbl_System.Size = new System.Drawing.Size(256, 32);
            this.lbl_System.TabIndex = 1;
            this.lbl_System.Text = "Quản Trị Hệ Thống";
            // 
            // transition_System
            // 
            this.transition_System.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transition_System.Cursor = null;
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
            this.transition_System.DefaultAnimation = animation6;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.Silver;
            this.transition_System.SetDecoration(this.pnl_Top, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(955, 44);
            this.pnl_Top.TabIndex = 6;
            // 
            // pnl_System
            // 
            this.pnl_System.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.pnl_System.Controls.Add(this.lbl_System);
            this.transition_System.SetDecoration(this.pnl_System, BunifuAnimatorNS.DecorationType.None);
            this.pnl_System.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_System.Location = new System.Drawing.Point(0, 44);
            this.pnl_System.Name = "pnl_System";
            this.pnl_System.Size = new System.Drawing.Size(955, 41);
            this.pnl_System.TabIndex = 8;
            // 
            // pnl_ManageSystem
            // 
            this.pnl_ManageSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transition_System.SetDecoration(this.pnl_ManageSystem, BunifuAnimatorNS.DecorationType.None);
            this.pnl_ManageSystem.Location = new System.Drawing.Point(0, 133);
            this.pnl_ManageSystem.Name = "pnl_ManageSystem";
            this.pnl_ManageSystem.Size = new System.Drawing.Size(955, 501);
            this.pnl_ManageSystem.TabIndex = 9;
            // 
            // pnl_ControlSystem
            // 
            this.pnl_ControlSystem.Controls.Add(this.separatorChoose);
            this.pnl_ControlSystem.Controls.Add(this.lbl_TroGiup);
            this.pnl_ControlSystem.Controls.Add(this.lbl_TaiKhoan);
            this.transition_System.SetDecoration(this.pnl_ControlSystem, BunifuAnimatorNS.DecorationType.None);
            this.pnl_ControlSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ControlSystem.Location = new System.Drawing.Point(0, 85);
            this.pnl_ControlSystem.Name = "pnl_ControlSystem";
            this.pnl_ControlSystem.Size = new System.Drawing.Size(955, 45);
            this.pnl_ControlSystem.TabIndex = 0;
            // 
            // lbl_TaiKhoan
            // 
            this.transition_System.SetDecoration(this.lbl_TaiKhoan, BunifuAnimatorNS.DecorationType.None);
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(3, 0);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(152, 45);
            this.lbl_TaiKhoan.TabIndex = 0;
            this.lbl_TaiKhoan.Text = "Tài khoản";
            this.lbl_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TaiKhoan.Click += new System.EventHandler(this.lbl_TaiKhoan_Click);
            // 
            // lbl_TroGiup
            // 
            this.transition_System.SetDecoration(this.lbl_TroGiup, BunifuAnimatorNS.DecorationType.None);
            this.lbl_TroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TroGiup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TroGiup.Location = new System.Drawing.Point(161, 0);
            this.lbl_TroGiup.Name = "lbl_TroGiup";
            this.lbl_TroGiup.Size = new System.Drawing.Size(152, 45);
            this.lbl_TroGiup.TabIndex = 0;
            this.lbl_TroGiup.Text = "Trợ giúp";
            this.lbl_TroGiup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TroGiup.Click += new System.EventHandler(this.lbl_TroGiup_Click);
            // 
            // separatorChoose
            // 
            this.separatorChoose.BackColor = System.Drawing.Color.Transparent;
            this.transition_System.SetDecoration(this.separatorChoose, BunifuAnimatorNS.DecorationType.None);
            this.separatorChoose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(82)))));
            this.separatorChoose.LineThickness = 2;
            this.separatorChoose.Location = new System.Drawing.Point(4, 35);
            this.separatorChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separatorChoose.Name = "separatorChoose";
            this.separatorChoose.Size = new System.Drawing.Size(152, 10);
            this.separatorChoose.TabIndex = 1;
            this.separatorChoose.Transparency = 255;
            this.separatorChoose.Vertical = false;
            // 
            // UserControl_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.pnl_ManageSystem);
            this.Controls.Add(this.pnl_ControlSystem);
            this.Controls.Add(this.pnl_System);
            this.Controls.Add(this.pnl_Top);
            this.transition_System.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "UserControl_System";
            this.Size = new System.Drawing.Size(955, 634);
            this.Load += new System.EventHandler(this.UserControl_System_Load);
            this.Resize += new System.EventHandler(this.UserControl_System_Resize);
            this.pnl_System.ResumeLayout(false);
            this.pnl_System.PerformLayout();
            this.pnl_ControlSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_System;
        private BunifuAnimatorNS.BunifuTransition transition_System;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_System;
        private System.Windows.Forms.Panel pnl_ManageSystem;
        private System.Windows.Forms.Panel pnl_ControlSystem;
        private System.Windows.Forms.Label lbl_TroGiup;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private Bunifu.Framework.UI.BunifuSeparator separatorChoose;
    }
}
