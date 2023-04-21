using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMainForm()
        {
            InitializeComponent();

        }

        public bool isLogin = false;
        public string tk;
        
        public void frmMainForm_Load(object sender, EventArgs e)
        {

            if (isLogin == false)
            {
                this.Hide();
                barBt_DangNhap.Enabled = true;
                barBt_DangKy.Enabled = false;
                barBt_DoiMK.Enabled = false;
                barBt_DangXuat.Enabled = false;
                barBt_ThongTinTK.Enabled = false;
                rbPage_Business.Visible = false;
                rbPage_Reader.Visible = false;
                rbPage_Book.Visible = false;
                rbPage_Borrow_GiveBack.Visible = false;
                rbPage_Report.Visible = false ;

                SplashScreen1 splashScreen1 = new SplashScreen1();
                splashScreen1.ShowDialog();
                this.Show();

                barBt_TrangChu_ItemClick(sender, null);
            }
            else
            {
                this.Hide();
                barBt_DangNhap.Enabled = false;
                barBt_DangKy.Enabled = true;
                barBt_DoiMK.Enabled = true;
                barBt_DangXuat.Enabled = true;
                barBt_ThongTinTK.Enabled = true;
                rbPage_Business.Visible = true;
                rbPage_Reader.Visible = true;
                rbPage_Book.Visible = true;
                rbPage_Borrow_GiveBack.Visible = true;
                rbPage_Report.Visible = true;
                SplashScreen1 splashScreen1 = new SplashScreen1();
                splashScreen1.ShowDialog();

                this.Show();
            }

            
        }

        private bool CheckExitForm(string name)
        {
            foreach (Form form in this.MdiChildren)
                if (form.Name == name)
                    return true;
            return false;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form form in this.MdiChildren)
                if (form.Name == name)
                {
                    form.Activate();
                    return;
                }
        }

        private void barBt_TrangChu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmTrangChu"))
            {
                frmTrangChu form = new frmTrangChu();
                form.MdiParent = this;
                form.Name = "frmTrangChu";
                form.Show();
            }
            else
                ActiveChildForm("frmTrangChu");
        }

        private void barBt_DangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmDangNhap"))
            {
                frmDangNhap form = new frmDangNhap(this);
                form.MdiParent = this;
                form.Name = "frmDangNhap";
                form.Show();
            }
            else
                ActiveChildForm("frmDangNhap");
        }

        private void barBt_DangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmDangKy"))
            {
                frmDangKy form = new frmDangKy();
                form.MdiParent = this;
                form.Name = "frmDangKy";
                form.Show();
            }
            else
                ActiveChildForm("frmDangKy");

        }

        private void barBt_DoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmDoiMK"))
            {
                frmDoiMK form = new frmDoiMK();
                form.MdiParent = this;
                form.Name = "frmDoiMK";
                form.Show();
            }
            else
                ActiveChildForm("frmDoiMK");
        }

        private void barBt_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                isLogin = false;
                frmMainForm_Load(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


            
        }

        private void barBt_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barBt_TimKiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmTimKiem"))
            {
                frmTimKiem form = new frmTimKiem();
                form.MdiParent = this;
                form.Name = "frmTimKiem";
                form.Show();
            }
            else
                ActiveChildForm("frmTimKiem");
        }

        private void barBt_NCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmNCC"))
            {
                frmNCC form = new frmNCC();
                form.MdiParent = this;
                form.Name = "frmNCC";
                form.Show();
            }
            else
                ActiveChildForm("frmNCC");
        }

        private void barBt_DocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmDocGia"))
            {
                frmDocGia form = new frmDocGia();
                form.MdiParent = this;
                form.Name = "frmDocGia";
                form.Show();
            }
            else
                ActiveChildForm("frmDocGia");
        }

        private void barBt_LoaiSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmLoaiSach"))
            {
                frmLoaiSach form = new frmLoaiSach();
                form.MdiParent = this;
                form.Name = "frmLoaiSach";
                form.Show();
            }
            else
                ActiveChildForm("frmLoaiSach");
        }

        private void barBt_Sach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmSach"))
            {
                frmSach form = new frmSach();
                form.MdiParent = this;
                form.Name = "frmSach";
                form.Show();
            }
            else
                ActiveChildForm("frmSach");
        }

        private void barBt_MuonSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmMuonSach"))
            {
                frmMuonSach form = new frmMuonSach();
                form.MdiParent = this;
                form.Name = "frmMuonSach";
                form.Show();
            }
            else
                ActiveChildForm("frmMuonSach");
        }

        private void barBt_TraSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmTraSach"))
            {
                frmTraSach form = new frmTraSach();
                form.MdiParent = this;
                form.Name = "frmTraSach";
                form.Show();
            }
            else
                ActiveChildForm("frmTraSach");
        }

        private void barBt_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            if (!CheckExitForm("frmThongKe"))
            {
                frmThongKe form = new frmThongKe();
                form.MdiParent = this;
                form.Name = "frmThongKe";
                form.Show();
            }
            else
                ActiveChildForm("frmThongKe");
        }

        private void barBt_ThongTinTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExitForm("frmThongTin"))
            {
                frmThongTin form = new frmThongTin(this);
                form.MdiParent = this;
                form.Name = "frmThongTin";
                form.Show();
            }
            else
                ActiveChildForm("frmThongTin");
        }
    }
}