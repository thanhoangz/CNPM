using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class FrmMain : Form
    {
        #region Properties
        private bool isFisrtStartForm;

        #endregion
        public FrmMain()
        {
            InitializeComponent();
            isFisrtStartForm = true;


        }

        #region Button Menu

      
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyBenhNhan.Top;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyLichHen.Top;
            panel_HienThi.Controls.Clear();
            UserControl_LichHen userControl_LichHen = new UserControl_LichHen();
            panel_HienThi.Controls.Add(userControl_LichHen);
            userControl_LichHen.Dock = DockStyle.Fill;

        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyThuoc.Top;
            UserControl_QuanLyThuoc userControl_QuanLyThuoc = new UserControl_QuanLyThuoc();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_QuanLyThuoc);
            userControl_QuanLyThuoc.Dock = DockStyle.Fill;
        }

        private void btnQuanLyNVBS_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyNVBS.Top;
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnDichVu.Top;
            UserControl_QuanLyDichVu userControl_QuanLyDichVu = new UserControl_QuanLyDichVu();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_QuanLyDichVu);
            userControl_QuanLyDichVu.Dock = DockStyle.Fill;
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnDonThuoc.Top;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnThongKe.Top;
            UserControl_ThongKe userControl_ThongKe = new UserControl_ThongKe();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_ThongKe);
            userControl_ThongKe.Dock = DockStyle.Fill;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnThanhToan.Top;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnHeThong.Top;
            panel_HienThi.Controls.Clear();
            UserControl_System userControl_System = new UserControl_System();
            panel_HienThi.Controls.Add(userControl_System);
            userControl_System.Dock = DockStyle.Fill;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // chú thích pannel_hienthi width = 1154
            if(panel_ChucNang.Width == 42)
            {
                panel_ChucNang.Visible = false;
                panel_ChucNang.Width = 245;
                transition_Menu.ShowSync(panel_ChucNang);

            }
            else
            {
                                
                panel_ChucNang.Visible = false;
                panel_ChucNang.Width = 42;
                transition_Menu.ShowSync(panel_ChucNang);

            }
        }
        
        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btn_home.Top;
            Panel anh = new Panel();
            anh.BackgroundImage = Properties.Resources.wPEgISa;
            anh.BackgroundImageLayout = ImageLayout.Stretch;
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(anh);
            anh.Dock = DockStyle.Fill;
            anh.Hide();
            transition_AnhGai.ShowSync(anh);
            /*UserControl1_NenGaiNgon userControl1_NenGaiNgon = new UserControl1_NenGaiNgon();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl1_NenGaiNgon);
            userControl1_NenGaiNgon.Dock = DockStyle.Fill;
            userControl1_NenGaiNgon.AnhViDieu();*/
            
            
        }


        #endregion


        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            
        }

   
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            if(isFisrtStartForm)
            {
                btn_home_Click(sender, e);
                isFisrtStartForm = false;
            }
                
        }
    }
}
