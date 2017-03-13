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
    public partial class ozelmenu : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb");

        DataSet ds = new DataSet(); 

        BindingSource hazirlanisbs = new BindingSource(); BindingSource resimbs = new BindingSource();BindingSource bs = new BindingSource();

        string corba, zeytinyagli, anayemek, pilav, salata, tatli;

        public ozelmenu()
        {
            InitializeComponent();
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        private void ozelmenu_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("12.jpg");
            corba = AnaForm.somcorbaadi; zeytinyagli = AnaForm.somzeytinadi; anayemek = AnaForm.somanayemekadi; pilav = AnaForm.sompilavadi; salata = AnaForm.somsalataadi; tatli = AnaForm.somtatliadi;
            cbyemekler.Items.Add(corba); cbyemekler.Items.Add(zeytinyagli); cbyemekler.Items.Add(anayemek); cbyemekler.Items.Add(pilav); cbyemekler.Items.Add(salata); cbyemekler.Items.Add(tatli);
            lblresimyolu.Visible =textBox1.Visible= false;
        }

        private void cbyemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            yemekidcek(); hazirlaniscek(); malzemecek(); servismalzemecek(); resimcek();

        }

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //*********************************************************************************************************************************************************

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        void yemekidcek()
        {
            string yemekcek = "select yemekadi.yemekid from yemekadi where yemekadi='"+cbyemekler.SelectedItem+"'";
            OleDbDataAdapter yemekda = new OleDbDataAdapter(yemekcek, baglan);
            if (ds.Tables["yemekid"] != null) ds.Tables["yemekid"].Clear(); yemekda.Fill(ds, "yemekid"); bs.DataSource = ds.Tables["yemekid"]; textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", bs, "yemekid");
        }
        void hazirlaniscek()
        { string sec = "select hazirlanis.hazirlanis from hazirlanis where hazirlanis.yemekid=" + textBox1.Text;
        OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
        if (ds.Tables["hazirlanis"] != null) ds.Tables["hazirlanis"].Clear(); da.Fill(ds, "hazirlanis"); hazirlanisbs.DataSource = ds.Tables["hazirlanis"];
        tbhazirlanis.DataBindings.Clear(); tbhazirlanis.DataBindings.Add("Text", hazirlanisbs, "hazirlanis");
        }

        void malzemecek()
        {
            string sec = "select malzemeler.malzemead from malzemeler where malzemeler.yemekid="+textBox1.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(sec,baglan);
            if (ds.Tables["malzemeler"] != null) ds.Tables["malzemeler"].Clear(); da.Fill(ds, "malzemeler");
            lbmalzeme.DataSource = ds.Tables["malzemeler"]; lbmalzeme.DisplayMember = "malzemead";
        }
        void servismalzemecek()
        {
            string sec = "select servismalzeme.servismalzeme from servismalzeme where servismalzeme.yemekid="+textBox1.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["smalzeme"] != null) ds.Tables["smalzeme"].Clear(); da.Fill(ds, "smalzeme");
            lbservismalzeme.DataSource = ds.Tables["smalzeme"]; lbservismalzeme.DisplayMember = "servismalzeme";
        }
        void resimcek()
        {  string sec="select resimler.resim from resimler where resimler.resimadi='"+cbyemekler.SelectedItem+"'";
        OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
        if (ds.Tables["resim"] != null) ds.Tables["resim"].Clear(); da.Fill(ds, "resim");
        resimbs.DataSource = ds.Tables["resim"]; lblresimyolu.DataBindings.Clear(); lblresimyolu.DataBindings.Add("Text", resimbs, "resim");
        this.BackgroundImage = Image.FromFile(lblresimyolu.Text); pbyemek.Image = Image.FromFile(lblresimyolu.Text);
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //*********************************************************************************************************************************************************

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            AnaForm goster = new AnaForm();
            goster.Show(); this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
       

       

    }
}
