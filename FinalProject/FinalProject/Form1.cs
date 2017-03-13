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
    public partial class AnaForm : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb");

        DataSet ds = new DataSet();BindingSource bs = new BindingSource();OleDbCommand kmt = new OleDbCommand();

        Random rastgelesayi = new Random(); Random etmitavukmu = new Random(); Random pilavmimakarnami = new Random(); Random sutmuserbetmi = new Random();

        int makarnapilav = 5; int r = 0; int genely = 1;  int tatlisec = 9;int fotodegistir = 2;bool mesajicin = false;

        public static int kayitliyemeksayisi = 50;

        bool ozelmenuvarmi = false;

        BindingSource corbabs = new BindingSource(); BindingSource zeytinbs = new BindingSource();BindingSource pilavbs = new BindingSource(); BindingSource salatabs = new BindingSource(); BindingSource tatlibs = new BindingSource();

        //som=sizeözelmenü
        public static string somcorbaadi, somzeytinadi, somanayemekadi, sompilavadi, somsalataadi, somtatliadi;
        
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public AnaForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void btnyemekler_Click(object sender, EventArgs e)
        {
            Yemeklerim2 goster = new Yemeklerim2();
            goster.Show();
            this.Hide();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnyenitarif_Click(object sender, EventArgs e)
        {
            Yenitarifekle goster = new Yenitarifekle();
            goster.Show(); this.Hide();
        }

        int kayitliyemek() 
        {  string sec="select yemekadi from yemekadi";
            OleDbDataAdapter kayitlida=new OleDbDataAdapter(sec,baglan);
            if(ds.Tables["kayitliyemeksayisi"]!=null)ds.Tables["kayitliyemeksayisi"].Clear();
            kayitlida.Fill(ds,"kayitliyemeksayisi");
            return ds.Tables["kayitliyemeksayisi"].Rows.Count;
        }
        
     //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\   
        
        private void AnaForm_Load(object sender, EventArgs e)
        {
            kayitliyemeksayisi = 46 + kayitliyemek();
           pbasci.Image = Image.FromFile(Application.StartupPath + "\\asci\\1.gif");
           lblascimesaji.Text = "Ne yemek pişireceksin karar veremedin mi ?" + Environment.NewLine + "Yardımcı olmamı ister misiniz?"; lblascimesaji.Visible = false;
           grpgununmenusu.Visible = false;
           btnevet.Visible = false; ozelmenuvarmi = false;
        }

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        // r=rastgeleüretilen sayı...

        bool yemekvarmi()//et veya tavuk --ana yemek...
        {
            string sec = "select yemekadi.yemekadi from yemekadi where yemekadi.gyid="+genely+" and yemekadi.yemekid=" + r;
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["yemekvarmi"] != null) ds.Tables["yemekvarmi"].Clear(); da.Fill(ds,"yemekvarmi");
            if (ds.Tables["yemekvarmi"].Rows.Count > 0) { return true;  }
            else return false;
        }

       bool corbacek() 
       {
           
           string sec = "select yemekadi.yemekadi from yemekadi where yemekadi.gyid=" + 4 + " and yemekadi.yemekid=" + r;
           OleDbDataAdapter cda = new OleDbDataAdapter(sec, baglan);
           if (ds.Tables["corbacek"] != null) ds.Tables["corbacek"].Clear(); cda.Fill(ds,"corbacek");
           if (ds.Tables["corbacek"].Rows.Count > 0) { return true; }
           else return false;
       }
       bool zeytinyagli() 
       {

           string sec = "select yemekadi.yemekadi from yemekadi where yemekadi.gyid=" + 7 + " and yemekadi.yemekid=" + r;
           OleDbDataAdapter zda = new OleDbDataAdapter(sec, baglan);
           if (ds.Tables["zeytinyagli"] != null) ds.Tables["zeytinyagli"].Clear(); zda.Fill(ds, "zeytinyagli");
           if (ds.Tables["zeytinyagli"].Rows.Count > 0) { return true; }
           else return false;
       }

       bool pilavmakarna()
       {
           string sec = "select yemekadi.yemekadi from yemekadi where yemekadi.gyid=" + makarnapilav + " and yemekadi.yemekid=" + r;
           OleDbDataAdapter pmda = new OleDbDataAdapter(sec, baglan);
           if (ds.Tables["pilavmakarna"] != null) ds.Tables["pilavmakarna"].Clear(); pmda.Fill(ds, "pilavmakarna");
           if (ds.Tables["pilavmakarna"].Rows.Count > 0) { return true; }
           else return false;
       }
       bool salata()
       {
           string sec = "select yemekadi.yemekadi from yemekadi where yemekadi.gyid=" + 11 + " and yemekadi.yemekid=" + r;
           OleDbDataAdapter salatada = new OleDbDataAdapter(sec, baglan);
           if (ds.Tables["salata"] != null) ds.Tables["salata"].Clear(); salatada.Fill(ds, "salata");
           if (ds.Tables["salata"].Rows.Count > 0) { return true; }
           else return false;
       }
       bool tatli()
       {
           string sec = "select yemekadi.yemekadi from yemekadi where yemekadi.gyid=" + tatlisec + " and yemekadi.yemekid=" + r;
           OleDbDataAdapter tatlida = new OleDbDataAdapter(sec, baglan);
           if (ds.Tables["tatli"] != null) ds.Tables["tatli"].Clear(); tatlida.Fill(ds, "tatli");
           if (ds.Tables["tatli"].Rows.Count > 0) { return true; }
           else return false;
       }



       //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

       //*********************************************************************************************************************************************************

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

       private void pbasci_MouseEnter(object sender, EventArgs e)
       {
           btnevet.Visible = true; lblascimesaji.Visible = true;
           toolTip1.SetToolTip(pbasci, "Ne yemek pişireceksin karar veremedin mi ?Yardımcı olmamı ister misiniz?");
           
       }

       private void btnevet_Click(object sender, EventArgs e)
       {
           btnevet.Visible = false; btnevet.Enabled = btnyemekler.Enabled=btnyenitarif.Enabled=btnozelmenu.Enabled=false;
           toolTip1.Active = false; mesajicin = true;
           backgroundWorker1.RunWorkerAsync();
           timer1.Enabled = true;
           toolTip2.SetToolTip(pbasci, "Tamam, hemen sana bir menü hazırlıyorum");
           lblascimesaji.Text = "Tamam, hemen sana bir menü hazırlıyorum";
       }

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        
       //*********************************************************************************************************************************************************

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        
       private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
       {

           while (1 == 1)
           {

               r = rastgelesayi.Next(20, kayitliyemeksayisi);//veritabanında 22 ile başlıyor ilk yemek id
               corbacek();
               if (corbacek())
               {
                   corbabs.DataSource = ds.Tables["corbacek"]; label2.DataBindings.Clear();
                   label2.DataBindings.Add("Text", corbabs, "yemekadi");  somcorbaadi = label2.Text;
                   break;
               }
           }
           while (1 == 1)
           {

               r = rastgelesayi.Next(20, kayitliyemeksayisi);
               zeytinyagli();
               if (zeytinyagli())
               {
                   zeytinbs.DataSource = ds.Tables["zeytinyagli"]; label5.DataBindings.Clear();
                   label5.DataBindings.Add("Text", zeytinbs, "yemekadi");  somzeytinadi = label5.Text; 
                   break;
               }
           }
           while (1 == 1)
           {
               genely = etmitavukmu.Next(1, 3);
               r = rastgelesayi.Next(20, kayitliyemeksayisi);
               yemekvarmi();
               if (yemekvarmi())
               {
                   bs.DataSource = ds.Tables["yemekvarmi"]; label3.DataBindings.Clear();
                   label3.DataBindings.Add("Text", bs, "yemekadi");  somanayemekadi = label3.Text;
                   break;
               }
           }

           while (1 == 1)
           {
               makarnapilav = pilavmimakarnami.Next(5, 7);
               r = rastgelesayi.Next(20, kayitliyemeksayisi);
               pilavmakarna();
               if (pilavmakarna())
               {
                   pilavbs.DataSource = ds.Tables["pilavmakarna"]; label7.DataBindings.Clear();
                   label7.DataBindings.Add("Text", pilavbs, "yemekadi");  sompilavadi = label7.Text;
                   break;
               }
           }
           while (1 == 1)
           {

               r = rastgelesayi.Next(20, kayitliyemeksayisi);
               salata();
               if (salata())
               {
                   salatabs.DataSource = ds.Tables["salata"]; label6.DataBindings.Clear();
                   label6.DataBindings.Add("Text", salatabs, "yemekadi");  somsalataadi = label6.Text;
                   break;
               }
           }
           while (1 == 1)
           {
               tatlisec = sutmuserbetmi.Next(9, 11);
               r = rastgelesayi.Next(20, kayitliyemeksayisi);
               tatli();
               if (tatli()) { tatlibs.DataSource = ds.Tables["tatli"]; label8.DataBindings.Clear();
               label8.DataBindings.Add("Text", tatlibs, "yemekadi");  somtatliadi = label8.Text;
                   break;
               }

           }

       }

        

       private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
       {
           MessageBox.Show("İşte mükemmel menün hazır..."+Environment.NewLine+"Sana hazırlamakta başarılar diliyorum"+Environment.NewLine+"Afiyet olsun. OKTAY USTA","SENİN İÇİN ÖZEL MENÜ"); 
           timer1.Enabled = false;
           pbasci.Image = Image.FromFile(Application.StartupPath + "\\asci\\1.gif"); lblascimesaji.Text = "İşte Menün Hazır afiyet olsun...";
           toolTip2.Active = false; toolTip3.SetToolTip(pbasci,"Bu menüyü beğenmedin sanırım yeni menü ister misin?");
           grpgununmenusu.Visible = true;  
           btnevet.Enabled=btnyenitarif.Enabled=btnyemekler.Enabled = true;lblascimesaji.Visible = true; mesajicin = false;
           ozelmenuvarmi = true; 
           btnozelmenu.Enabled=true;
       }

       //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //*********************************************************************************************************************************************************

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        
       private void timer1_Tick(object sender, EventArgs e)
       {
           if (fotodegistir == 11) fotodegistir = 2;
           fotodegistir++; 
           pbasci.Image = Image.FromFile(Application.StartupPath + "\\asci\\"+fotodegistir+".gif");
           if (lblascimesaji.Text == "Tamam, hemen sana bir menü hazırlıyorum") lblascimesaji.Text = "Sana güzel bir başlangıç seçelim";
           else if (lblascimesaji.Text == "Sana güzel bir başlangıç seçelim") lblascimesaji.Text = "Evet birde mükemmel ana yemekler";
           else if (lblascimesaji.Text == "Evet birde mükemmel ana yemekler") lblascimesaji.Text = "Senin güzel tariflerinide katıyorum menümüze";
           else if (lblascimesaji.Text == "Senin güzel tariflerinide katıyorum menümüze") lblascimesaji.Text = "Tamam, hemen sana bir menü hazırlıyorum";

           if (lblascimesaji.Text == "İşte Menün Hazır afiyet olsun...") lblascimesaji.Text = "Demek bu menü hoşuna gitmedi :(";
           else if (lblascimesaji.Text == "Demek bu menü hoşuna gitmedi :(") lblascimesaji.Text = "Tamam, hemen sana bir menü hazırlıyorum";
       }

       //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

       //*********************************************************************************************************************************************************************
       private void AnaForm_MouseEnter(object sender, EventArgs e)
       {
           btnevet.Visible = false; lblascimesaji.Visible = mesajicin; 
       }

       private void btnozelmenu_Click(object sender, EventArgs e)
       {
           if (ozelmenuvarmi == true)
           {
               ozelmenu goster = new ozelmenu();
               goster.Show(); this.Hide();
           }
           else MessageBox.Show("Size Özel Menüyü Görmek için Oktay Ustadan yardım almalısnız...", "Uyarı");
       }

       

     

       

      
      
    }
}
