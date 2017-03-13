namespace FinalProject
{
    partial class ozelmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ozelmenu));
            this.cbyemekler = new System.Windows.Forms.ComboBox();
            this.lbmalzeme = new System.Windows.Forms.ListBox();
            this.lbservismalzeme = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbhazirlanis = new System.Windows.Forms.TextBox();
            this.lblresimyolu = new System.Windows.Forms.Label();
            this.pbyemek = new System.Windows.Forms.PictureBox();
            this.lblyemekler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpislemler = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbyemek)).BeginInit();
            this.grpislemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbyemekler
            // 
            this.cbyemekler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbyemekler.FormattingEnabled = true;
            this.cbyemekler.Location = new System.Drawing.Point(40, 78);
            this.cbyemekler.Name = "cbyemekler";
            this.cbyemekler.Size = new System.Drawing.Size(330, 24);
            this.cbyemekler.TabIndex = 0;
            this.cbyemekler.SelectedIndexChanged += new System.EventHandler(this.cbyemekler_SelectedIndexChanged);
            // 
            // lbmalzeme
            // 
            this.lbmalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbmalzeme.FormattingEnabled = true;
            this.lbmalzeme.ItemHeight = 16;
            this.lbmalzeme.Location = new System.Drawing.Point(100, 283);
            this.lbmalzeme.Name = "lbmalzeme";
            this.lbmalzeme.Size = new System.Drawing.Size(280, 564);
            this.lbmalzeme.TabIndex = 1;
            // 
            // lbservismalzeme
            // 
            this.lbservismalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbservismalzeme.FormattingEnabled = true;
            this.lbservismalzeme.ItemHeight = 16;
            this.lbservismalzeme.Location = new System.Drawing.Point(462, 283);
            this.lbservismalzeme.Name = "lbservismalzeme";
            this.lbservismalzeme.Size = new System.Drawing.Size(305, 564);
            this.lbservismalzeme.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // tbhazirlanis
            // 
            this.tbhazirlanis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbhazirlanis.Location = new System.Drawing.Point(820, 277);
            this.tbhazirlanis.Multiline = true;
            this.tbhazirlanis.Name = "tbhazirlanis";
            this.tbhazirlanis.Size = new System.Drawing.Size(338, 575);
            this.tbhazirlanis.TabIndex = 7;
            // 
            // lblresimyolu
            // 
            this.lblresimyolu.AutoSize = true;
            this.lblresimyolu.Location = new System.Drawing.Point(228, 19);
            this.lblresimyolu.Name = "lblresimyolu";
            this.lblresimyolu.Size = new System.Drawing.Size(46, 17);
            this.lblresimyolu.TabIndex = 8;
            this.lblresimyolu.Text = "label1";
            // 
            // pbyemek
            // 
            this.pbyemek.Location = new System.Drawing.Point(410, 12);
            this.pbyemek.Name = "pbyemek";
            this.pbyemek.Size = new System.Drawing.Size(404, 227);
            this.pbyemek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbyemek.TabIndex = 9;
            this.pbyemek.TabStop = false;
            // 
            // lblyemekler
            // 
            this.lblyemekler.AutoSize = true;
            this.lblyemekler.BackColor = System.Drawing.Color.Black;
            this.lblyemekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyemekler.ForeColor = System.Drawing.Color.White;
            this.lblyemekler.Location = new System.Drawing.Point(35, 50);
            this.lblyemekler.Name = "lblyemekler";
            this.lblyemekler.Size = new System.Drawing.Size(153, 25);
            this.lblyemekler.TabIndex = 10;
            this.lblyemekler.Text = "Özel Yemekler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "MALZEMELER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(459, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "SERVİS MALZEME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(817, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "HAZIRLANIŞ";
            // 
            // grpislemler
            // 
            this.grpislemler.BackColor = System.Drawing.Color.Transparent;
            this.grpislemler.Controls.Add(this.btncikis);
            this.grpislemler.Controls.Add(this.btnanasayfa);
            this.grpislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpislemler.Location = new System.Drawing.Point(1013, 29);
            this.grpislemler.Name = "grpislemler";
            this.grpislemler.Size = new System.Drawing.Size(145, 180);
            this.grpislemler.TabIndex = 14;
            this.grpislemler.TabStop = false;
            this.grpislemler.Text = "İşlemler";
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(6, 103);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(126, 53);
            this.btncikis.TabIndex = 1;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanasayfa.Location = new System.Drawing.Point(6, 31);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(126, 52);
            this.btnanasayfa.TabIndex = 0;
            this.btnanasayfa.Text = "AnaSayfa";
            this.btnanasayfa.UseVisualStyleBackColor = true;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // ozelmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 864);
            this.ControlBox = false;
            this.Controls.Add(this.grpislemler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblyemekler);
            this.Controls.Add(this.pbyemek);
            this.Controls.Add(this.lblresimyolu);
            this.Controls.Add(this.tbhazirlanis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbservismalzeme);
            this.Controls.Add(this.lbmalzeme);
            this.Controls.Add(this.cbyemekler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ozelmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size Özel Menü";
            this.Load += new System.EventHandler(this.ozelmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbyemek)).EndInit();
            this.grpislemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbyemekler;
        private System.Windows.Forms.ListBox lbmalzeme;
        private System.Windows.Forms.ListBox lbservismalzeme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbhazirlanis;
        private System.Windows.Forms.Label lblresimyolu;
        private System.Windows.Forms.PictureBox pbyemek;
        private System.Windows.Forms.Label lblyemekler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpislemler;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnanasayfa;
    }
}