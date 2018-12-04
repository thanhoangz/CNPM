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
    public partial class UserControl_ThongKe : UserControl
    {
        public UserControl_ThongKe()
        {
            InitializeComponent();
            UserControl_ThongKe_Resize(this, new EventArgs());
        }

        private void btnThongKeBenhNhan_Click(object sender, EventArgs e)
        {
            panel_Choose.Left = btnThongKeBenhNhan.Left;
        }

        private void btnThongKeThuoc_Click(object sender, EventArgs e)
        {
            panel_Choose.Left = btnThongKeThuoc.Left;
            panel_HienThiThongKe.Controls.Clear();

           
        }

        private void UserControl_ThongKe_Resize(object sender, EventArgs e)
        {
            btnThongKeBenhNhan.Width = this.Width / 3;
            btnThongKeDoanhThu.Width = this.Width / 3;
            panel_Choose.Width = btnThongKeBenhNhan.Width;
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            panel_Choose.Left = btnThongKeDoanhThu.Left;
        }
    }
}
