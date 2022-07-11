using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Project p = new Project();
        private void Form1_Load(object sender, EventArgs e)
        {
              
              p.cnx.Open();
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            bool tr=false;
            p.cmd.CommandText = "select nom,motdepasse from utilisateur";
            p.cmd.Connection = p.cnx;
            p.dr = p.cmd.ExecuteReader();
                  while (p.dr.Read())
                    {
                if (textBox3.Text.Equals(p.dr[0]) && textBox4.Text.Equals(p.dr[1]))
                { 
                       tr=true;
                    break;
                  
                }
            }
                  if (tr == true)
                  {
                      Form2 f = new Form2();
                      f.ShowDialog();
                   
                     
                      
                   
                  }
                  else 
                  {
                      MessageBox .Show(" Usernam ou le mot de passe est incorecte");
                  }

                  p.dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
