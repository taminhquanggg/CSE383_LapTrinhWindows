using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienBTL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void ts_InfoTypeOfBook_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("InfoTypeOfBookForm"))
            {
                InfoTypeOfBookForm form = new InfoTypeOfBookForm();
                form.MdiParent = this;
                form.Name = "InfoTypeOfBookForm";
                form.Show();
            }
            else
                ActiveChildForm("InfoTypeOfBookForm");
            
        }

        private void ts_InfoBook_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("InfoBookForm"))
            {
                InfoBookForm form = new InfoBookForm();
                form.MdiParent = this;
                form.Name = "InfoBookForm";
                form.Show();
            }
            else
                ActiveChildForm("InfoBookForm");
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
