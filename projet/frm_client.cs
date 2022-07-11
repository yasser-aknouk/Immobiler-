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
    public partial class frm_client : Form
    {
        public frm_client()
        {
            InitializeComponent();
        }
        Project p = new Project();
        private void frm_client_Load(object sender, EventArgs e)
        {
            p.cmd.CommandType = CommandType.Text;
            p.cmd.CommandText = "";
            p.cmd.Connection = p.cnx;
            p.cnx.Open();
            p.cmd.CommandText = "SELECT * FROM Client";
            p.dr = p.cmd.ExecuteReader();
            p.dt.Clear();
            p.dt.Load(p.dr);
            CrystalReport2 ap = new CrystalReport2();
            ap.SetDataSource(p.dt);
            crystalReportViewer1.ReportSource = ap;
            crystalReportViewer1.Refresh();
        }
    }
}
