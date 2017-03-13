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
    public partial class Yemeklerim2 : Form
    {
       OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb");
       public static DataSet ds = new DataSet(); 
        BindingSource bs = new BindingSource();
        OleDbCommand kmt = new OleDbCommand();
        
        int resimkodu = 1, gyid=1;
        public Yemeklerim2()
        {
            InitializeComponent();
        }

        void fotocek()
        { this.BackgroundImage = Image.FromFile(resimkodu + ".jpg"); }

        private void Yemeklerim2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(12 + ".jpg");
            groupBox2.Visible = groupBox3.Visible = gbresimler.Visible = false;

        }


        void baslangicacik()
        {
            groupBox2.Visible = groupBox3.Visible = gbresimler.Visible = true;
        }

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        void yemekcek()
        {
            string sec = "select yemekadi.yemekadi,yemekadi.yemekid from yemekadi where yemekadi.gyid="+gyid;
            OleDbDataAdapter da = new OleDbDataAdapter(sec,baglan);
            if (ds.Tables["yemekadi"] != null) ds.Tables["yemekadi"].Clear();
            da.Fill(ds, "yemekadi");
            lbyemekler.ValueMember = "yemekid";
            lbyemekler.DisplayMember = "yemekadi"; 
            lbyemekler.DataSource = ds.Tables["yemekadi"];
            
        }
        void malzemecek()
        {
            string sec = "select malz.malzemead from malzemeler as malz where malz.yemekid=" + lbyemekler.SelectedValue;//seçili itemin value değeri
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["malzemeler"] != null) ds.Tables["malzemeler"].Clear();
             da.Fill(ds, "malzemeler");
             lbmalzemeler.DisplayMember = "malzemead";
            lbmalzemeler.DataSource = ds.Tables["malzemeler"];
        }
        void hazirlaniscek()
        {
            try
            {
                string sec = "select hazirlanis.hazirlanis from hazirlanis where hazirlanis.yemekid=" + lbyemekler.SelectedValue;
                OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
                if (ds.Tables["hazirlanis"] != null) ds.Tables["hazirlanis"].Clear();
                da.Fill(ds, "hazirlanis");
                bs.DataSource = ds.Tables["hazirlanis"];
                tbhazirlanis.DataBindings.Add("Text", bs, "hazirlanis");
            }
            catch (ArgumentException) { }
        }
        void servismalzemecek()
        {
            string sec = "select servis.servismalzeme from servismalzeme as servis where servis.yemekid=" + lbyemekler.SelectedValue;// Selectedvalue=yemekid olduğundan o yemeğe ait malzemeleri çekiyoruz..
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["servismalzemeler"] != null) ds.Tables["servismalzemeler"].Clear();
            da.Fill(ds, "servismalzemeler");
            lbservis.DisplayMember = "servismalzeme";
            lbservis.DataSource = ds.Tables["servismalzemeler"];
        }

        void resimcek1()
        {
            BindingSource bs1 = new BindingSource();
            string sec = "select * from resimler where resimler.resimadi='"+labelyemekadi.Text+"'";//yemek ismini çekip ona göre resim çekiyoruz..
            OleDbDataAdapter da1 = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["resimler"] != null) ds.Tables["resimler"].Clear();
            da1.Fill(ds, "resimler");
            bs1.DataSource = ds.Tables["resimler"]; pictureBox1.DataBindings.Clear();// önce temizliyoruz , sonra çekiyoruz yoksa yemekler arası geçiş yaparken hata veriyor...
            pictureBox1.DataBindings.Add("ImageLocation", bs1, "resim");
        }
        void resimcek2()
        {
            BindingSource bs2 = new BindingSource();
            string sec = "select * from resimler where resimler.resimadi='" + labelyemekadi.Text +"2"+ "'";
            OleDbDataAdapter da2 = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["resimler2"] != null) ds.Tables["resimler2"].Clear();
            da2.Fill(ds, "resimler2");
            bs2.DataSource = ds.Tables["resimler2"]; pictureBox2.DataBindings.Clear();
            pictureBox2.DataBindings.Add("ImageLocation", bs2, "resim");
        }
        void resimcek3()
        {
            BindingSource bs3 = new BindingSource();
            string sec = "select * from resimler where resimler.resimadi='" + labelyemekadi.Text + "3" + "'";
            OleDbDataAdapter da3 = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["resimler3"] != null) ds.Tables["resimler3"].Clear();
            da3.Fill(ds, "resimler3");
            bs3.DataSource = ds.Tables["resimler3"]; pictureBox3.DataBindings.Clear();
            pictureBox3.DataBindings.Add("ImageLocation", bs3, "resim");
        }
        void yemekadicek()
        {
            string sec = "select yemekadi.yemekadi from yemekadi where yemekadi.yemekid=" + lbyemekler.SelectedValue;
            OleDbDataAdapter dataa = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["yemekadicek"] != null) ds.Tables["yemekadicek"].Clear();
            dataa.Fill(ds, "yemekadicek");
            BindingSource bindings = new BindingSource(); bindings.DataSource = ds.Tables["yemekadicek"]; labelyemekadi.DataBindings.Clear();
            labelyemekadi.DataBindings.Add("Text", bindings, "yemekadi");

        }
       

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //********************************************************************************************************************************************************

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button1_Click(object sender, EventArgs e)
        {
            resimkodu = 1; gyid = 1;
            fotocek(); yemekcek(); baslangicacik();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resimkodu = 2; gyid = 2;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resimkodu = 3; gyid = 3;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resimkodu = 4; gyid = 4;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resimkodu = 5; gyid = 5;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resimkodu = 6; gyid = 6;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resimkodu = 7; gyid = 7;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resimkodu = 8; gyid = 8;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resimkodu = 9; gyid = 9;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resimkodu = 10; gyid = 10;
            fotocek(); yemekcek(); baslangicacik();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resimkodu = 11; gyid = 11;
            fotocek(); yemekcek(); baslangicacik();
        }
        
        private void lbyemekler_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbyemekler.SelectedValue == null) { }
            else
            {
                yemekadicek();
                malzemecek(); hazirlaniscek(); servismalzemecek(); resimcek1(); resimcek2(); resimcek3();
            }
               
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //********************************************************************************************************************************************************


        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            AnaForm goster = new AnaForm();
            goster.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rapor rapor = new rapor();
            rapor.ShowDialog();
        }

        private void tbarama_TextChanged(object sender, EventArgs e)
        {
            
        }

       


    }
}
