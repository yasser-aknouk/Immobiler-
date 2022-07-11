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
    public partial class UserControl2 : UserControl
    {
        private static UserControl2 Userrepresenetant ;
        public static UserControl2 Instance
        {
            get
            {
                if (Userrepresenetant == null)
                {
                    Userrepresenetant = new UserControl2();
                }
                return Userrepresenetant;
            }
        }
        public UserControl2()
        {
            InitializeComponent();
        }
             Project p = new Project();
             private void button1_Click(object sender, EventArgs e)
             {
                 try
                 {
                     p.cmd.CommandText = "insert into represnetant values('" + textBox1.Text + "','" +
                       textBox2.Text + "','" + textBox3.Text + "')"; 
                     p.cmd.ExecuteNonQuery();
                     MessageBox.Show("bien ajouter");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);


                 }
             }

        private void button3_Click(object sender, EventArgs e)
        {

            p.cmd.CommandText = "update  represnetant set nomrep='" + textBox2.Text + "',prenomrrep='" + textBox3.Text + "'   where coderep='" + textBox1.Text + "'";
            p.cmd.ExecuteNonQuery();

            MessageBox.Show("bien modifié");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.cmd.Connection = p.cnx;
            p.cmd.CommandText = "DELETE represnetant WHERE coderep=" + textBox1.Text + "";
            p.cmd.ExecuteNonQuery();

            MessageBox.Show("bien supprimer");
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.dt.Clear();
            p.cmd.CommandText = " select * from represnetant";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Load(p.dr);
            dataGridView1.DataSource = p.dt;
            p.dr.Close();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            p.cmd.CommandType = CommandType.Text;
            p.cmd.CommandText = "";
            p.cmd.Connection = p.cnx;
            p.cnx.Open();
            p.cmd.CommandText = "select * from represnetant ";
            p.dr = p.cmd.ExecuteReader();
            while (p.dr.Read())
            {
                comboBox1.Items.Add(p.dr[0].ToString());

            }
            p.dr.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.cmd.CommandText = "select * from represnetant where coderep='" + comboBox1.Text + "'";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Clear();
            p.dt.Load(p.dr);
            dataGridView1.DataSource = p.dt;
            p.dr.Close();
        }
           

    }
}
