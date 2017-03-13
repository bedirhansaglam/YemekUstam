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
    public partial class Yenitarifekle3 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbCommand kmt = new OleDbCommand();
        public static int yemekid;
        public static string yemekadi;
        public Yenitarifekle3()
        {
            InitializeComponent();
        }

        private void Yenitarifekle3_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("12.jpg"); yemekadi = Yenitarifekle2.yemekaditut;
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            lblyemekturu.Text= Yenitarifekle2.yemekturutut;
            lblyemekadi.Text = Yenitarifekle2.yemekaditut; yemekidcagir();
            tbyemekid.DataBindings.Add("Text", bs, "yemekid");
            
        }

         void yemekidcagir()
        {
            string sec = "select yemekid from yemekadi where yemekadi='" + yemekadi+ "'";
           
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["yemekid"] != null) ds.Tables["yemekid"].Clear();
            da.Fill(ds, "yemekid"); bs.DataSource = ds.Tables["yemekid"];
        }

       
        void servismalzemecek()
        {
            
            string sec = "select servismalzeme,servismalzemeid from servismalzeme where yemekid=" + yemekid;
          OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
          if (ds.Tables["servismalzeme"] != null) ds.Tables["servismalzeme"].Clear(); da.Fill(ds, "servismalzeme");
          lbservismalz.ValueMember = "servismalzemeid";
          lbservismalz.DisplayMember = "servismalzeme"; lbservismalz.DataSource = ds.Tables["servismalzeme"];
        }
        void malzemekaydet()
        {
            OleDbCommand kmt1 = new OleDbCommand();
            kmt1.Connection = baglan;
            kmt1.CommandText = "insert into malzemeler(yemekid,malzemead) values(@yemekid,@malzemead)";
            kmt1.Parameters.AddWithValue("@yemekid", yemekid);
            kmt1.Parameters.AddWithValue("@malzemead", tbmalzemeler.Text);
            kmt1.ExecuteNonQuery();
            
        }
       void malzemecek()
        {
            string sec = "select malzemead,malzemeid from malzemeler where malzemeler.yemekid=" + yemekid + "";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["malzemeler"] != null) ds.Tables["malzemeler"].Clear(); da.Fill(ds, "malzemeler");
            lbmalzemeler.ValueMember = "malzemeid";
            lbmalzemeler.DisplayMember = "malzemead"; lbmalzemeler.DataSource = ds.Tables["malzemeler"];
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            yemekid = int.Parse(tbyemekid.Text);
            if (tbmalzemeler.Text == "") MessageBox.Show("Lütfen Malzeme ismi giriniz");
            else
            {
                if (rbtnmalzemeler.Checked == false & rbtnservis.Checked == false) { MessageBox.Show("Lütfen malzeme ekleyeceğiniz bölümü seçiniz", "Hata"); }
                else if (rbtnmalzemeler.Checked == true)
                {
                    malzemekaydet();
                    malzemecek();
                }
                else if (rbtnservis.Checked == true)
                {
                    servismalzemekaydet();
                    servismalzemecek();
                }
            }
         tbmalzemeler.Text="";tbmalzemeler.Focus();
        }

        void servismalzemekaydet()
        {
            OleDbCommand kmt3 = new OleDbCommand();
            kmt3.Connection = baglan;
            kmt3.CommandText = "insert into servismalzeme(yemekid,servismalzeme) values(@yemekid,@servismalzeme)";
            kmt3.Parameters.AddWithValue("@yemekid", yemekid);
            kmt3.Parameters.AddWithValue("@servismalzeme", tbmalzemeler.Text);
            kmt3.ExecuteNonQuery();
        }
        void malzemesil()
        {
            OleDbCommand kmt7 = new OleDbCommand();
            kmt7.Connection = baglan;
            kmt7.CommandText = "delete from malzemeler where malzemeid=" + lbmalzemeler.SelectedValue;
            kmt7.ExecuteNonQuery();
        }
        void servismalzemesil()
        {
            kmt.Connection = baglan;
            kmt.CommandText = "delete from servismalzeme where servismalzemeid=" + lbservismalz.SelectedValue;
            kmt.ExecuteNonQuery();
        }

        void hazirlaniskaydet()
        {
            kmt.Connection = baglan;
            kmt.CommandText = "insert into hazirlanis(yemekid,hazirlanis) values(@yemekid,@hazirlanis)";
            kmt.Parameters.AddWithValue("@yemekid", yemekid);
            kmt.Parameters.AddWithValue("@hazirlanis", tbhazirlanis.Text);
            kmt.ExecuteNonQuery();
        }
        void yemeksil()
        {
            OleDbCommand sil = new OleDbCommand();
            sil.Connection=baglan;
            sil.CommandText="delete from yemekadi where yemekid="+yemekid;
            sil.ExecuteNonQuery();
        
        }

     

        private void btnsil_Click(object sender, EventArgs e)
        {
            yemekid = int.Parse(tbyemekid.Text.ToString());
            if (rbtnmalzemeler.Checked)
            {
                malzemesil(); malzemecek();
            }
            else if (rbtnservis.Checked)
            { servismalzemesil(); servismalzemecek(); }
        }

        bool malzemevarmi()
        {
            string sec = "select malzemeler.malzemead from malzemeler where malzemeler.yemekid=" + yemekid;
            OleDbDataAdapter yemekda = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["malzemevarmi"] != null) ds.Tables["malzemevarmi"].Clear(); yemekda.Fill(ds, "malzemevarmi");
            if (ds.Tables["malzemevarmi"].Rows.Count > 0) { return true; }
            else return false;
        }

        private void btntamam_Click(object sender, EventArgs e)
        {
            yemekid = int.Parse(tbyemekid.Text.ToString());
            if (tbhazirlanis.Text == "") { MessageBox.Show("Lütfen Yemeğiniz için bir hazırlanış giriniz..", "HATA"); }
            else if (malzemevarmi() == false) { MessageBox.Show("Lütfen Yemeğiniz için malzeme giriniz...","HATA"); }
            else
            {
                hazirlaniskaydet(); MessageBox.Show("Kayıt Başarılı, Son adıma geçiliyor", "Kayıt");
                Yenitarifekle4 gec = new Yenitarifekle4(); gec.Show(); this.Hide();
            }
        }

        private void lbmalzemeler_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbmalzemeler, "Yukarıdaki metin kutusundan malzeme ismini giriniz ve ekle butonuna tıklayınız");
        }

        private void lbservismalz_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbservismalz, "Yukarıdaki metin kutusundan malzeme ismini giriniz ve ekle butonuna tıklayınız");
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            yemekid = int.Parse(tbyemekid.Text.ToString());
            yemeksil(); AnaForm goster = new AnaForm(); goster.Show(); this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            yemekid = int.Parse(tbyemekid.Text.ToString());
            yemeksil(); Application.Exit();
        }

        private void tbmalzemeler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { btnekle_Click(sender, e); }
        }

      
    }
}
