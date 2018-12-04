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
    public partial class UserControl_Account_System : UserControl
    {
        public UserControl_Account_System()
        {
            InitializeComponent();
        }

        private void UserControl_Account_System_Resize(object sender, EventArgs e)
        {

            pnl_Manage.Size = new Size(32, 478);
            
             
        }
    }
}
