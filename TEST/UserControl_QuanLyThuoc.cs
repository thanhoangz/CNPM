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
    public partial class UserControl_QuanLyThuoc : UserControl
    {
        public UserControl_QuanLyThuoc()
        {
            InitializeComponent();
            //toolTip1.Show("Xóa", btnDelete);

        }

        private void UserControl_QuanLyThuoc_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_QuanLyThuoc_Resize(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            int k;
            int g;
            g = panel_HienThi_QLBN.Width / 2 - 150;
            x = this.Width - txtTimKiem.Width;
            y = this.Width - txtTimKiem.Width - btnDelete.Width;
            z = this.Width - txtTimKiem.Width - btnDelete.Width - btnEdit.Width;
            k = this.Width - txtTimKiem.Width - btnDelete.Width - btnEdit.Width - btnAdd.Width;
            txtTimKiem.Location = new Point(x, txtTimKiem.Location.Y);
            btnDelete.Location = new Point(y, btnDelete.Location.Y);
            btnEdit.Location = new Point(z, btnEdit.Location.Y);
            btnAdd.Location = new Point(k, btnAdd.Location.Y);
            label1.Location = new Point(g, label1.Location.Y);
        }

        private void txtTimKiem_OnTextChange(object sender, EventArgs e)
        {

        }

        

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddThuoc add = new Frm_AddThuoc();
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Frm_EditThuoc edit = new Frm_EditThuoc();
            edit.Show();
        }
    }
}
