namespace FinalProject
{
    partial class Yenitarifekle3
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
            this.components = new System.ComponentModel.Container();
            this.lblyemekturu = new System.Windows.Forms.Label();
            this.lblyemekadi = new System.Windows.Forms.Label();
            this.tbyemekid = new System.Windows.Forms.TextBox();
            this.grpyemekadi = new System.Windows.Forms.GroupBox();
            this.grpmalzemeler = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbmalzemeler = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.rbtnservis = new System.Windows.Forms.RadioButton();
            this.rbtnmalzemeler = new System.Windows.Forms.RadioButton();
            this.lbservismalz = new System.Windows.Forms.ListBox();
            this.lbmalzemeler = new System.Windows.Forms.ListBox();
            this.grphazirlanis = new System.Windows.Forms.GroupBox();
            this.tbhazirlanis = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btntamam = new System.Windows.Forms.Button();
            this.grpyemekadi.SuspendLayout();
            this.grpmalzemeler.SuspendLayout();
            this.grphazirlanis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblyemekturu
            // 
            this.lblyemekturu.AutoSize = true;
            this.lblyemekturu.Location = new System.Drawing.Point(22, 27);
            this.lblyemekturu.Name = "lblyemekturu";
            this.lblyemekturu.Size = new System.Drawing.Size(64, 25);
            this.lblyemekturu.TabIndex = 0;
            this.lblyemekturu.Text = "label1";
            // 
            // lblyemekadi
            // 
            this.lblyemekadi.AutoSize = true;
            this.lblyemekadi.Location = new System.Drawing.Point(22, 55);
            this.lblyemekadi.Name = "lblyemekadi";
            this.lblyemekadi.Size = new System.Drawing.Size(64, 25);
            this.lblyemekadi.TabIndex = 1;
            this.lblyemekadi.Text = "label2";
            // 
            // tbyemekid
            // 
            this.tbyemekid.Location = new System.Drawing.Point(1247, 49);
            this.tbyemekid.Name = "tbyemekid";
            this.tbyemekid.Size = new System.Drawing.Size(100, 22);
            this.tbyemekid.TabIndex = 2;
            // 
            // grpyemekadi
            // 
            this.grpyemekadi.BackColor = System.Drawing.Color.Transparent;
            this.grpyemekadi.Controls.Add(this.lblyemekturu);
            this.grpyemekadi.Controls.Add(this.lblyemekadi);
            this.grpyemekadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpyemekadi.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpyemekadi.Location = new System.Drawing.Point(394, 35);
            this.grpyemekadi.Name = "grpyemekadi";
            this.grpyemekadi.Size = new System.Drawing.Size(317, 88);
            this.grpyemekadi.TabIndex = 3;
            this.grpyemekadi.TabStop = false;
            this.grpyemekadi.Text = "Yemek Türü - Yemek Adı";
            // 
            // grpmalzemeler
            // 
            this.grpmalzemeler.BackColor = System.Drawing.Color.Transparent;
            this.grpmalzemeler.Controls.Add(this.label1);
            this.grpmalzemeler.Controls.Add(this.tbmalzemeler);
            this.grpmalzemeler.Controls.Add(this.btnsil);
            this.grpmalzemeler.Controls.Add(this.btnekle);
            this.grpmalzemeler.Controls.Add(this.rbtnservis);
            this.grpmalzemeler.Controls.Add(this.rbtnmalzemeler);
            this.grpmalzemeler.Controls.Add(this.lbservismalz);
            this.grpmalzemeler.Controls.Add(this.lbmalzemeler);
            this.grpmalzemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpmalzemeler.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpmalzemeler.Location = new System.Drawing.Point(394, 129);
            this.grpmalzemeler.Name = "grpmalzemeler";
            this.grpmalzemeler.Size = new System.Drawing.Size(504, 480);
            this.grpmalzemeler.TabIndex = 4;
            this.grpmalzemeler.TabStop = false;
            this.grpmalzemeler.Text = "Malzemeler - Servis Malzemeleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Malzeme girişi:";
            // 
            // tbmalzemeler
            // 
            this.tbmalzemeler.Location = new System.Drawing.Point(7, 58);
            this.tbmalzemeler.Name = "tbmalzemeler";
            this.tbmalzemeler.Size = new System.Drawing.Size(178, 26);
            this.tbmalzemeler.TabIndex = 7;
            this.tbmalzemeler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbmalzemeler_KeyDown);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(396, 201);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 29);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Çıkart";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnekle.Location = new System.Drawing.Point(396, 153);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 30);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // rbtnservis
            // 
            this.rbtnservis.AutoSize = true;
            this.rbtnservis.Location = new System.Drawing.Point(200, 100);
            this.rbtnservis.Name = "rbtnservis";
            this.rbtnservis.Size = new System.Drawing.Size(191, 24);
            this.rbtnservis.TabIndex = 4;
            this.rbtnservis.TabStop = true;
            this.rbtnservis.Text = "Servis Malzemeleri";
            this.rbtnservis.UseVisualStyleBackColor = true;
            // 
            // rbtnmalzemeler
            // 
            this.rbtnmalzemeler.AutoSize = true;
            this.rbtnmalzemeler.Location = new System.Drawing.Point(6, 100);
            this.rbtnmalzemeler.Name = "rbtnmalzemeler";
            this.rbtnmalzemeler.Size = new System.Drawing.Size(127, 24);
            this.rbtnmalzemeler.TabIndex = 3;
            this.rbtnmalzemeler.TabStop = true;
            this.rbtnmalzemeler.Text = "Malzemeler";
            this.rbtnmalzemeler.UseVisualStyleBackColor = true;
            // 
            // lbservismalz
            // 
            this.lbservismalz.FormattingEnabled = true;
            this.lbservismalz.ItemHeight = 20;
            this.lbservismalz.Location = new System.Drawing.Point(200, 127);
            this.lbservismalz.Name = "lbservismalz";
            this.lbservismalz.Size = new System.Drawing.Size(151, 344);
            this.lbservismalz.TabIndex = 2;
            this.lbservismalz.MouseEnter += new System.EventHandler(this.lbservismalz_MouseEnter);
            // 
            // lbmalzemeler
            // 
            this.lbmalzemeler.FormattingEnabled = true;
            this.lbmalzemeler.ItemHeight = 20;
            this.lbmalzemeler.Location = new System.Drawing.Point(6, 127);
            this.lbmalzemeler.Name = "lbmalzemeler";
            this.lbmalzemeler.Size = new System.Drawing.Size(159, 344);
            this.lbmalzemeler.TabIndex = 1;
            this.lbmalzemeler.MouseEnter += new System.EventHandler(this.lbmalzemeler_MouseEnter);
            // 
            // grphazirlanis
            // 
            this.grphazirlanis.BackColor = System.Drawing.Color.Transparent;
            this.grphazirlanis.Controls.Add(this.tbhazirlanis);
            this.grphazirlanis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grphazirlanis.ForeColor = System.Drawing.Color.DarkOrange;
            this.grphazirlanis.Location = new System.Drawing.Point(904, 129);
            this.grphazirlanis.Name = "grphazirlanis";
            this.grphazirlanis.Size = new System.Drawing.Size(328, 480);
            this.grphazirlanis.TabIndex = 5;
            this.grphazirlanis.TabStop = false;
            this.grphazirlanis.Text = "Hazırlanış";
            // 
            // tbhazirlanis
            // 
            this.tbhazirlanis.Location = new System.Drawing.Point(6, 27);
            this.tbhazirlanis.Multiline = true;
            this.tbhazirlanis.Name = "tbhazirlanis";
            this.tbhazirlanis.Size = new System.Drawing.Size(316, 444);
            this.tbhazirlanis.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btniptal);
            this.groupBox1.Controls.Add(this.btncikis);
            this.groupBox1.Controls.Add(this.btntamam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(688, 615);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.White;
            this.btniptal.Image = global::FinalProject.Properties.Resources.btniptal;
            this.btniptal.Location = new System.Drawing.Point(216, 23);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(123, 87);
            this.btniptal.TabIndex = 8;
            this.btniptal.Text = "İptal";
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.White;
            this.btncikis.Image = global::FinalProject.Properties.Resources.btncikis;
            this.btncikis.Location = new System.Drawing.Point(28, 23);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(118, 87);
            this.btncikis.TabIndex = 7;
            this.btncikis.Text = "Çıkış";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btntamam
            // 
            this.btntamam.BackColor = System.Drawing.Color.White;
            this.btntamam.Image = global::FinalProject.Properties.Resources.btnsonraki;
            this.btntamam.Location = new System.Drawing.Point(396, 23);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(115, 87);
            this.btntamam.TabIndex = 6;
            this.btntamam.Text = "Sonraki";
            this.btntamam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntamam.UseVisualStyleBackColor = false;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // Yenitarifekle3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 768);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbyemekid);
            this.Controls.Add(this.grphazirlanis);
            this.Controls.Add(this.grpmalzemeler);
            this.Controls.Add(this.grpyemekadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Yenitarifekle3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Tarif Ekle";
            this.Load += new System.EventHandler(this.Yenitarifekle3_Load);
            this.grpyemekadi.ResumeLayout(false);
            this.grpyemekadi.PerformLayout();
            this.grpmalzemeler.ResumeLayout(false);
            this.grpmalzemeler.PerformLayout();
            this.grphazirlanis.ResumeLayout(false);
            this.grphazirlanis.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblyemekturu;
        private System.Windows.Forms.Label lblyemekadi;
        private System.Windows.Forms.TextBox tbyemekid;
        private System.Windows.Forms.GroupBox grpyemekadi;
        private System.Windows.Forms.GroupBox grpmalzemeler;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.RadioButton rbtnservis;
        private System.Windows.Forms.RadioButton rbtnmalzemeler;
        private System.Windows.Forms.ListBox lbservismalz;
        private System.Windows.Forms.ListBox lbmalzemeler;
        private System.Windows.Forms.GroupBox grphazirlanis;
        private System.Windows.Forms.TextBox tbhazirlanis;
        private System.Windows.Forms.Button btntamam;
        private System.Windows.Forms.TextBox tbmalzemeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btncikis;
    }
}