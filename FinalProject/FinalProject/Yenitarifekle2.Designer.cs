namespace FinalProject
{
    partial class Yenitarifekle2
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
            this.gpislemler = new System.Windows.Forms.GroupBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnkayit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbyemekadi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblyemekturu = new System.Windows.Forms.Label();
            this.tbyemekturu = new System.Windows.Forms.TextBox();
            this.gpislemler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpislemler
            // 
            this.gpislemler.Controls.Add(this.btniptal);
            this.gpislemler.Controls.Add(this.btncikis);
            this.gpislemler.Controls.Add(this.btnkayit);
            this.gpislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpislemler.ForeColor = System.Drawing.Color.Red;
            this.gpislemler.Location = new System.Drawing.Point(2, 326);
            this.gpislemler.Name = "gpislemler";
            this.gpislemler.Size = new System.Drawing.Size(621, 119);
            this.gpislemler.TabIndex = 6;
            this.gpislemler.TabStop = false;
            this.gpislemler.Text = "İşlemler";
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.White;
            this.btniptal.Image = global::FinalProject.Properties.Resources.cancel;
            this.btniptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btniptal.Location = new System.Drawing.Point(269, 21);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(139, 92);
            this.btniptal.TabIndex = 4;
            this.btniptal.Text = "İptal";
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.White;
            this.btncikis.Image = global::FinalProject.Properties.Resources.çıkış;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncikis.Location = new System.Drawing.Point(68, 21);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(139, 92);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "Çıkış";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.Color.White;
            this.btnkayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkayit.Image = global::FinalProject.Properties.Resources.ileri_butonu;
            this.btnkayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnkayit.Location = new System.Drawing.Point(476, 21);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(139, 92);
            this.btnkayit.TabIndex = 2;
            this.btnkayit.Text = "Sonraki Adım";
            this.btnkayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::FinalProject.Properties.Resources.shef2;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbyemekadi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(342, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 321);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yemek Adı";
            // 
            // tbyemekadi
            // 
            this.tbyemekadi.Location = new System.Drawing.Point(47, 267);
            this.tbyemekadi.Name = "tbyemekadi";
            this.tbyemekadi.Size = new System.Drawing.Size(185, 22);
            this.tbyemekadi.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::FinalProject.Properties.Resources.shef2;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblyemekturu);
            this.groupBox1.Controls.Add(this.tbyemekturu);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 321);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblyemekturu
            // 
            this.lblyemekturu.AutoSize = true;
            this.lblyemekturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyemekturu.ForeColor = System.Drawing.Color.Red;
            this.lblyemekturu.Location = new System.Drawing.Point(46, 234);
            this.lblyemekturu.Name = "lblyemekturu";
            this.lblyemekturu.Size = new System.Drawing.Size(100, 17);
            this.lblyemekturu.TabIndex = 0;
            this.lblyemekturu.Text = "Yemek Türü:";
            // 
            // tbyemekturu
            // 
            this.tbyemekturu.BackColor = System.Drawing.Color.Black;
            this.tbyemekturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbyemekturu.ForeColor = System.Drawing.Color.Red;
            this.tbyemekturu.Location = new System.Drawing.Point(49, 263);
            this.tbyemekturu.Name = "tbyemekturu";
            this.tbyemekturu.Size = new System.Drawing.Size(229, 26);
            this.tbyemekturu.TabIndex = 1;
            // 
            // Yenitarifekle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 484);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpislemler);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Yenitarifekle2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Tarif Ekle";
            this.Load += new System.EventHandler(this.Yenitarifekle2_Load);
            this.gpislemler.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblyemekturu;
        private System.Windows.Forms.TextBox tbyemekturu;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbyemekadi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpislemler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btncikis;
    }
}