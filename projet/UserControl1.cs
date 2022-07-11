using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet
{
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 Userclient;
        public static UserControl1 Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new UserControl1();
                }
                return Userclient;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }
        Project p = new Project();




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p.cmd.CommandText = "insert into Client values ('" + textBox1.Text + " ','" +
                  textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
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
            p.cmd.CommandText = "update  Client set nomclt ='" + textBox2.Text + "',prenomclt='" + textBox3.Text + "' ,adressclt ='" + textBox4.Text + "',villeclt='" + textBox5.Text + "'   where codeclt='" + textBox1.Text + "'";
                 
            p.cmd.ExecuteNonQuery();

            MessageBox.Show("bien modifier");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           p. cmd.Connection = p.cnx;
           p. cmd.CommandText = "delete Client where codeclt= '"+ textBox1.Text +"'";
            p.cmd.ExecuteNonQuery();

            MessageBox.Show("bien supprimer");
          

        }

        private void button4_Click(object sender, EventArgs e)
           {
               Application.Exit();
           }

        private void button5_Click(object sender, EventArgs e)
        {
            p.dt.Clear();
            p.cmd.CommandText = " select * from Client";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Load(p.dr);
            dataGridView1.DataSource = p.dt;
            p.dr.Close();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            p.cmd.CommandType = CommandType.Text;
            p.cmd.CommandText = "";
            p.cmd.Connection = p.cnx;
            p.cnx.Open();
            p.cmd.CommandText ="select * from Client ";
            p.dr = p.cmd.ExecuteReader();
            while (p.dr.Read())
            {
                comboBox1.Items.Add(p.dr[0].ToString());

            }
            p.dr.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.cmd.CommandText="select * from client where codeclt='"+comboBox1.Text+"'";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Clear();
            p.dt.Load(p.dr);
            dataGridView1.DataSource = p.dt;
            p.dr.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm_client fr = new frm_client();
            fr.ShowDialog();
        }
    }
    }

