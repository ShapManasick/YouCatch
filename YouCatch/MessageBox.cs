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
    public partial class MessageBox : Form
    {
        public MessageBox(String msgHead,String msg)
        {
            InitializeComponent();
            lblMessage.Text = msg;
            lblMsgType.Text = msgHead;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
