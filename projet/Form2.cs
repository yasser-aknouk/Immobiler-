using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Top = button2.Top;
            if (!pnlficher.Controls.Contains(UserControl1.Instance))
            {
                pnlficher.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();



            }
            else
            {
                UserControl1.Instance.BringToFront();
            }​​​​
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Top = button3.Top;
            if (!pnlficher.Controls.Contains(UserControl2.Instance))
            {
                pnlficher.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();



            }
            else
            {
                UserControl2.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Top = button4.Top;
            if (!pnlficher.Controls.Contains(UserControl3.Instance))
            {
                pnlficher.Controls.Add(UserControl3.Instance);
                UserControl3.Instance.Dock = DockStyle.Fill;
                UserControl3.Instance.BringToFront();



            }
            else
            {
                UserControl3.Instance.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Top = button1.Top;
            if (!pnlficher.Controls.Contains(UserControl4.Instance))
            {
                pnlficher.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();



            }
            else
            {
                UserControl4.Instance.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
