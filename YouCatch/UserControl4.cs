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
    public partial class UserControl4 : UserControl
    {
        public static UserControl4 _instanse;
        public static UserControl4 Instance
        {
            get
            {
                if (_instanse == null)
                    _instanse = new UserControl4();
                return _instanse;

            }
        }

        public UserControl4()
        {
            InitializeComponent();
        }
    }
}
