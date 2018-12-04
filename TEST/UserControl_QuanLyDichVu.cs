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
    public partial class UserControl_QuanLyDichVu : UserControl
    {
        public UserControl_QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void UserControl_QuanLyDichVu_Resize(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            int k;
            int g;
            x = this.Width - txtTimKiem.Width;
            g = panel_HienThi_QLDV.Width / 2 - 150;// (label1.Width/2);
            y = this.Width - txtTimKiem.Width - btnDelete.Width;
            z = this.Width - txtTimKiem.Width - btnDelete.Width - btnEdit.Width;
            k = this.Width - txtTimKiem.Width - btnDelete.Width - btnEdit.Width - btnAdd.Width;
            txtTimKiem.Location = new Point(x, txtTimKiem.Location.Y);
            btnDelete.Location = new Point(y, btnDelete.Location.Y);
            btnEdit.Location = new Point(z, btnEdit.Location.Y);
            btnAdd.Location = new Point(k, btnAdd.Location.Y);
            label1.Location = new Point(g, label1.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_QuanLyDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_AddDichVu add = new Frm_AddDichVu();
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Frm_Edit_DichVu edit = new Frm_Edit_DichVu();
            edit.Show();
        }
    }
}
