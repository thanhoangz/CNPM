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
    public partial class UserControl_LichHen : UserControl
    {
        public UserControl_LichHen()
        {
            InitializeComponent();
        }

        private void bnt_ThemLichHen_Click(object sender, EventArgs e)
        {
            Form_ThemLichHen formThemLichHen = new Form_ThemLichHen();
            formThemLichHen.ShowDialog();
        }

        private void bnt_SuaLichHen_Click(object sender, EventArgs e)
        {
            Form_SuaLichHencs formSuaLichHen = new Form_SuaLichHencs();
            formSuaLichHen.ShowDialog();
        }

        private void bnt_XoaLichHen_Click(object sender, EventArgs e)
        {
            Form_XoaLichHen formXoaLichHen = new Form_XoaLichHen();
            formXoaLichHen.ShowDialog();
        }
    }
}
