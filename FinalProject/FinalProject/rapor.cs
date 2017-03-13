using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace FinalProject
{
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }

        private void rapor_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSet1", Yemeklerim2.ds.Tables["yemekadi"]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
