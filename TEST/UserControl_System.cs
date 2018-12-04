using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class UserControl_System : UserControl
    {
        public UserControl_System()
        {
            InitializeComponent();
        }

        private void UserControl_System_Load(object sender, EventArgs e)
        {


            UserControl_System_Resize(sender, e);

        }

       

        
   

      
        private void UserControl_System_Resize(object sender, EventArgs e)
        {
            lbl_System.Location = new Point(this.Width / 2 - (lbl_System.Width/2), lbl_System.Location.Y);

           

        }

        private void lbl_TaiKhoan_Click(object sender, EventArgs e)
        {
            pnl_ManageSystem.Controls.Clear();
            separatorChoose.Left = lbl_TaiKhoan.Left;
            UserControl_Account_System userControl_Account_System = new UserControl_Account_System();
            pnl_ManageSystem.Controls.Add(userControl_Account_System);
            userControl_Account_System.Dock = DockStyle.Fill;
        }

        private void lbl_TroGiup_Click(object sender, EventArgs e)
        {
            pnl_ManageSystem.Controls.Clear();
            separatorChoose.Left = lbl_TroGiup.Left;
        }
    }
}
