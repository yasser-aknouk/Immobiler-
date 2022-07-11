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
    public partial class UserControl3 : UserControl
    {
        private static UserControl3 Userappartement;
        public static UserControl3 Instance
        {
            get
            {
                if (Userappartement == null)
                {
                    Userappartement = new UserControl3();
                }
                return Userappartement;
            }
        }
        public UserControl3()
        {
            InitializeComponent();
        }
        Project p = new Project();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p.cmd.CommandText = "insert into appartement values('" + textBox1.Text + "','" +
                  textBox2.Text + "'," + textBox3.Text + ", '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
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
           
            
            p.cmd.CommandText = "update  appartement  set superficie ='"+textBox2.Text+"', prixvente= "+textBox3.Text +" , secteur= '" + textBox4.Text + "',coderep= '"+textBox5.Text+"',codeclt= '"+textBox6.Text+"' where ref = '"+textBox1.Text+"'";
            p.cmd.ExecuteNonQuery();
            MessageBox.Show("bien modifier");

           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.cmd.Connection = p.cnx;
            p.cmd.CommandText = "delete appartement where ref='" + textBox1.Text + "'";
            p.cmd.ExecuteNonQuery();

            MessageBox.Show("bien supprimer");
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.dt.Clear();
            p.cmd.CommandText = " select * from appartement";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Load(p.dr);
            dataGridView1.DataSource = p.dt;
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            p.cmd.CommandType = CommandType.Text;
            p.cmd.CommandText = "";
            p.cmd.Connection = p.cnx;
            p.cnx.Open();
            p.cmd.CommandText = "select * from appartement ";
            p.dr = p.cmd.ExecuteReader();
            while (p.dr.Read())
            {
                comboBox1.Items.Add(p.dr[0].ToString());

            }
            p.dr.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.cmd.CommandText = "select * from appartement where ref='" + comboBox1.Text + "'";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Clear();
            p.dt.Load(p.dr);
            dataGridView1.DataSource = p.dt;
            p.dr.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_lappartement fr = new frm_lappartement();
            fr.ShowDialog();
        }
       
      

        }

        
    }

