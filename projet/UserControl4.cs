using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class UserControl4 : UserControl
    {
        private static UserControl4 User4;
        public static UserControl4 Instance
        {
            get
            {
                if (User4 == null)
                {
                    User4 = new UserControl4();
                }
                return User4;
            }
        }
        public UserControl4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
