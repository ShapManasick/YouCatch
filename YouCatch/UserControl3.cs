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
    public partial class UserControl3 : UserControl
    {
        public static UserControl3 _instanse;
        public static UserControl3 Instance
        {
            get
            {
                if (_instanse == null)
                    _instanse = new UserControl3();
                return _instanse;

            }
        }

        public UserControl3()
        {
            InitializeComponent();
        }
    }
}
