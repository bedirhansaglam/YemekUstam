using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalProject
{   
    public partial class Yenitarifekle : Form
    {
        
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbCommand kmt = new OleDbCommand();
        public static int yemekid;
        

        public Yenitarifekle()
        {
            InitializeComponent();
        }

        private void Yenitarifekle_Load(object sender, EventArgs e)
        {
            yemekturleri();
            btnsonraki.Enabled = false; 
        }

        void yemekturleri()
        {
            string sec = "select * from genelyemek";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["yemekturleri"] != null) ds.Tables["yemekturleri"].Clear();
            da.Fill(ds, "yemekturleri");
            lbyemekturleri.ValueMember = "gyid";
            lbyemekturleri.DisplayMember = "gyad";
            lbyemekturleri.DataSource = ds.Tables["yemekturleri"];
        }

        private void cbkilitle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkilitle.Checked)
            { lbyemekturleri.Enabled = false; btnsonraki.Enabled = true; }
            else
            { lbyemekturleri.Enabled = true; btnsonraki.Enabled =false; }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            yemekid = int.Parse(lbyemekturleri.SelectedValue.ToString());
           
            Yenitarifekle2 gec = new Yenitarifekle2();
            gec.Show();
            this.Hide();
        }

        private void Yenitarifekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
