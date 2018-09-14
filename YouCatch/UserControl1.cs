using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouCatch
{

    public partial class UserControl1 : UserControl
    {
        public static UserControl1 _instanse;
        public static UserControl1 Instance
        {
            get
            {
                if (_instanse == null)
                    _instanse = new UserControl1();
                return _instanse;

            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
