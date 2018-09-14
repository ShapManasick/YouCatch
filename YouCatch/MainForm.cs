using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouCatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        UserControl1 Home = new UserControl1();

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox msgBox = new MessageBox("Confirmation ", "Are you sure?");
            msgBox.Show();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutUI au = new AboutUI();
            au.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!pnlMiddle.Controls.Contains(UserControl1.Instance))
            {
                pnlMiddle.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
                UserControl1.Instance.BringToFront();
        }

        private void btnDownloadNow_Click(object sender, EventArgs e)
        {
            if (!pnlMiddle.Controls.Contains(UserControl2.Instance))
            {
                pnlMiddle.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();
            }
            else
                UserControl2.Instance.BringToFront();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (!pnlMiddle.Controls.Contains(UserControl4.Instance))
            {
                pnlMiddle.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();
            }
            else
                UserControl4.Instance.BringToFront();
        }

        private void btnChanale_Click(object sender, EventArgs e)
        {
            if (!pnlMiddle.Controls.Contains(UserControl4.Instance))
            {
                pnlMiddle.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();
            }
            else
                UserControl4.Instance.BringToFront();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void pnlMiddle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
