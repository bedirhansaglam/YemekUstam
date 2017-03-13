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
    public partial class Yenitarifekle2 : Form
    {   public static int yemekid2;
    public static string yemekaditut;
    public static string yemekturutut;
    
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbCommand kmt = new OleDbCommand();
        public Yenitarifekle2()
        {
            InitializeComponent();
        }
        void yemekturleri()
        {
            string sec = "select * from genelyemek where genelyemek.gyid="+yemekid2+"";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["yemekturleri"] != null) ds.Tables["yemekturleri"].Clear();
            da.Fill(ds, "yemekturleri");
            bs.DataSource = ds.Tables["yemekturleri"];  
        }

        private void Yenitarifekle2_Load(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            yemekid2 = Yenitarifekle.yemekid; yemekturleri();
            tbyemekturu.Enabled = false; tbyemekturu.DataBindings.Add("Text", bs, "gyad");//yemektürünü göstersin diye tekrardan çektim...önceki formdaki displaymember ile hatalı oluyor..
        }

        void kayitbaslat()
        {
            kmt.Connection = baglan;
            kmt.CommandText = "insert into yemekadi (yemekadi,gyid) values (@yemekadi,@gyid)";
            kmt.Parameters.AddWithValue("@yemekadi", tbyemekadi.Text);
            kmt.Parameters.AddWithValue("@gyid", yemekid2);
            kmt.ExecuteNonQuery();
            MessageBox.Show(yemekaditut+"  Kayıt edildi, Sonraki adıma geçiliyor..");
            
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            if (tbyemekadi.Text == "") { MessageBox.Show("Yemek adı boş geçilemez...", "HATA"); tbyemekadi.Focus(); }
            else
            {
                yemekaditut = tbyemekadi.Text; yemekturutut = tbyemekturu.Text;
                kayitbaslat(); Yenitarifekle3 gec = new Yenitarifekle3(); gec.Show(); this.Hide();
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            AnaForm goster = new AnaForm();
            goster.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
