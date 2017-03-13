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
    public partial class Yenitarifekle4 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbCommand komut=new OleDbCommand();

        public Yenitarifekle4()
        {
            InitializeComponent();
        }

        private void Yenitarifekle4_Load(object sender, EventArgs e)
        {
           
            this.BackgroundImage = Image.FromFile("12.jpg");
            if(baglan.State==ConnectionState.Closed) baglan.Open();
            malzemecek(); servismalzemecek(); hazirlaniscek(); label4.Visible = false;
            labelyemekturu.Text = Yenitarifekle2.yemekturutut;
            lblyemekadi.Text = Yenitarifekle2.yemekaditut;

        }

        void resimkaydet1()
        {
            komut.Connection = baglan;
            komut.CommandText = "insert into resimler(yemekid,resim,resimadi) values(@yemekid,@resim,@resimadi)";
            komut.Parameters.AddWithValue("@yemekid", Yenitarifekle3.yemekid);
            komut.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@resimadi", Yenitarifekle2.yemekaditut.ToString());
            komut.ExecuteNonQuery();
           

        }
        void resimkaydet2()
        {
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglan;
            komut2.CommandText = "insert into resimler(yemekid,resim,resimadi) values(@yemekid,@resim,@resimadi)";
            komut2.Parameters.AddWithValue("@yemekid", Yenitarifekle3.yemekid);
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@resimadi", Yenitarifekle2.yemekaditut.ToString() + "2");
            komut2.ExecuteNonQuery();

        }
        void resimkaydet3()
        {
            OleDbCommand komut3 = new OleDbCommand();
            komut3.Connection = baglan;
            komut3.CommandText = "insert into resimler(yemekid,resim,resimadi) values(@yemekid,@resim,@resimadi)";
            komut3.Parameters.AddWithValue("@yemekid", Yenitarifekle3.yemekid);
            komut3.Parameters.AddWithValue("@resim", pictureBox3.ImageLocation);
            komut3.Parameters.AddWithValue("@resimadi", Yenitarifekle2.yemekaditut.ToString() + "3");
            komut3.ExecuteNonQuery();
            
            
        }

       void malzemecek()
        {

            string sec = "select malzemead,malzemeid from malzemeler where malzemeler.yemekid=" + Yenitarifekle3.yemekid + "";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["malzemeler"] != null) ds.Tables["malzemeler"].Clear(); da.Fill(ds, "malzemeler");
            lbmalzemeler.ValueMember = "malzemeid";
            lbmalzemeler.DisplayMember = "malzemead"; lbmalzemeler.DataSource = ds.Tables["malzemeler"];
        }
        void servismalzemecek()
        {

            string sec = "select servismalzeme,servismalzemeid from servismalzeme where yemekid=" + Yenitarifekle3.yemekid;
            OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
            if (ds.Tables["servismalzeme"] != null) ds.Tables["servismalzeme"].Clear(); da.Fill(ds, "servismalzeme");
            lbservismalzeme.ValueMember = "servismalzemeid";
            lbservismalzeme.DisplayMember = "servismalzeme"; lbservismalzeme.DataSource = ds.Tables["servismalzeme"];
        }
        void hazirlaniscek()
        {
            string sec = "select hazirlanis.hazirlanis from hazirlanis where hazirlanis.yemekid="+Yenitarifekle3.yemekid;
            OleDbDataAdapter hazirlanisadapter = new OleDbDataAdapter(sec,baglan);
            if (ds.Tables["hazirlanis"] != null) ds.Tables["hazirlanis"].Clear(); hazirlanisadapter.Fill(ds, "hazirlanis");
            BindingSource hazirlanisbs = new BindingSource(); hazirlanisbs.DataSource = ds.Tables["hazirlanis"];
            tbhazirlanis.DataBindings.Add("Text", hazirlanisbs, "hazirlanis");
        }

        void yemeksil()
        { OleDbCommand yemeksil = new OleDbCommand();
        yemeksil.Connection = baglan;
        yemeksil.CommandText = "delete from yemekadi where yemekadi.yemekid="+Yenitarifekle3.yemekid;
        yemeksil.ExecuteNonQuery();
        }
        private void btnresimsec1_Click(object sender, EventArgs e)
        {
            if (rdbtnresim1.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = openFileDialog1.SafeFileName;
                }
            }
            else if (rdbtnresim2.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.ImageLocation = openFileDialog1.SafeFileName;
                }
            }
            else if (rdbtnresim3.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.ImageLocation = openFileDialog1.SafeFileName;
                }
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.ImageLocation == null) { MessageBox.Show("Lütfen 1 numaralı resim bloğuna resim ekleyiniz..", "Hata"); }
            else if (pictureBox2.ImageLocation == null) { MessageBox.Show("Lütfen 2 numaralı resim bloğuna resim ekleyiniz..", "Hata"); }
            else if (pictureBox3.ImageLocation == null) { MessageBox.Show("Lütfen 3 numaralı resim bloğuna resim ekleyiniz..", "Hata"); }
            else { resimkaydet1(); resimkaydet2(); resimkaydet3(); MessageBox.Show("Kayıt Eklendi"); AnaForm goster = new AnaForm(); goster.Show(); this.Hide(); }

        }

        private void btnresimsec1_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void btnresimsec1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            yemeksil(); AnaForm goster = new AnaForm(); goster.Show(); this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            yemeksil(); Application.Exit();
        }

      
    }
}
