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
    
    public partial class frm_lappartement : Form
    {
        public frm_lappartement()
        {
            InitializeComponent();
        }

        private void CrystalReport12_InitReport(object sender, EventArgs e)
        {

        }
        Project p = new Project();

        private void frm_lappartement_Load(object sender, EventArgs e)
        {
            p.cmd.CommandType = CommandType.Text;
            p.cmd.CommandText = "";
            p.cmd.Connection = p.cnx;
            p.cnx.Open();
            p.cmd.CommandText = "SELECT * FROM appartement";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Clear();
            p.dt.Load(p.dr);
            CrystalReport1 ap = new CrystalReport1();
            ap.SetDataSource(p.dt);
            crystalReportViewer1.ReportSource = ap;
            crystalReportViewer1.Refresh();
        }
    }
}
