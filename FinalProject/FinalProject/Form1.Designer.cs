namespace FinalProject
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btnyemekler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnyenitarif = new System.Windows.Forms.Button();
            this.grpgununmenusu = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbasci = new System.Windows.Forms.PictureBox();
            this.btnevet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpasci = new System.Windows.Forms.GroupBox();
            this.lblascimesaji = new System.Windows.Forms.Label();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnozelmenu = new System.Windows.Forms.Button();
            this.grpgununmenusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbasci)).BeginInit();
            this.grpasci.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnyemekler
            // 
            this.btnyemekler.BackColor = System.Drawing.Color.Transparent;
            this.btnyemekler.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnyemekler.FlatAppearance.BorderSize = 2;
            this.btnyemekler.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyemekler.ForeColor = System.Drawing.Color.Orange;
            this.btnyemekler.Location = new System.Drawing.Point(965, 319);
            this.btnyemekler.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnyemekler.Name = "btnyemekler";
            this.btnyemekler.Size = new System.Drawing.Size(378, 93);
            this.btnyemekler.TabIndex = 0;
            this.btnyemekler.Text = "Yemeklerim";
            this.btnyemekler.UseVisualStyleBackColor = false;
            this.btnyemekler.Click += new System.EventHandler(this.btnyemekler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(487, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 130);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hos Geldiniz";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnyenitarif
            // 
            this.btnyenitarif.Location = new System.Drawing.Point(965, 425);
            this.btnyenitarif.Margin = new System.Windows.Forms.Padding(8);
            this.btnyenitarif.Name = "btnyenitarif";
            this.btnyenitarif.Size = new System.Drawing.Size(378, 109);
            this.btnyenitarif.TabIndex = 2;
            this.btnyenitarif.Text = "Yeni Tarif Ekle";
            this.btnyenitarif.UseVisualStyleBackColor = true;
            this.btnyenitarif.Click += new System.EventHandler(this.btnyenitarif_Click);
            // 
            // grpgununmenusu
            // 
            this.grpgununmenusu.BackColor = System.Drawing.Color.Transparent;
            this.grpgununmenusu.Controls.Add(this.label8);
            this.grpgununmenusu.Controls.Add(this.label7);
            this.grpgununmenusu.Controls.Add(this.label6);
            this.grpgununmenusu.Controls.Add(this.label5);
            this.grpgununmenusu.Controls.Add(this.label4);
            this.grpgununmenusu.Controls.Add(this.label3);
            this.grpgununmenusu.Controls.Add(this.label2);
            this.grpgununmenusu.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpgununmenusu.ForeColor = System.Drawing.Color.Orange;
            this.grpgununmenusu.Location = new System.Drawing.Point(456, 134);
            this.grpgununmenusu.Name = "grpgununmenusu";
            this.grpgununmenusu.Size = new System.Drawing.Size(411, 420);
            this.grpgununmenusu.TabIndex = 4;
            this.grpgununmenusu.TabStop = false;
            this.grpgununmenusu.Text = "Senin Özel Menün";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tatlı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pilav/Makarna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salata/Meze";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zeytinyağlılar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-3, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ana Yemek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç";
            // 
            // pbasci
            // 
            this.pbasci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbasci.Location = new System.Drawing.Point(11, 33);
            this.pbasci.Name = "pbasci";
            this.pbasci.Size = new System.Drawing.Size(194, 144);
            this.pbasci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbasci.TabIndex = 6;
            this.pbasci.TabStop = false;
            this.pbasci.MouseEnter += new System.EventHandler(this.pbasci_MouseEnter);
            // 
            // btnevet
            // 
            this.btnevet.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnevet.Location = new System.Drawing.Point(125, 183);
            this.btnevet.Name = "btnevet";
            this.btnevet.Size = new System.Drawing.Size(80, 30);
            this.btnevet.TabIndex = 7;
            this.btnevet.Text = "EVET";
            this.btnevet.UseVisualStyleBackColor = true;
            this.btnevet.Click += new System.EventHandler(this.btnevet_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpasci
            // 
            this.grpasci.BackColor = System.Drawing.Color.Transparent;
            this.grpasci.Controls.Add(this.pbasci);
            this.grpasci.Controls.Add(this.btnevet);
            this.grpasci.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpasci.Location = new System.Drawing.Point(985, 21);
            this.grpasci.Name = "grpasci";
            this.grpasci.Size = new System.Drawing.Size(232, 221);
            this.grpasci.TabIndex = 8;
            this.grpasci.TabStop = false;
            this.grpasci.Text = "OKTAY USTA";
            // 
            // lblascimesaji
            // 
            this.lblascimesaji.AutoSize = true;
            this.lblascimesaji.BackColor = System.Drawing.Color.Transparent;
            this.lblascimesaji.Font = new System.Drawing.Font("Arial Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblascimesaji.ForeColor = System.Drawing.Color.Black;
            this.lblascimesaji.Location = new System.Drawing.Point(961, 258);
            this.lblascimesaji.Name = "lblascimesaji";
            this.lblascimesaji.Size = new System.Drawing.Size(0, 24);
            this.lblascimesaji.TabIndex = 9;
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            // 
            // btnozelmenu
            // 
            this.btnozelmenu.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnozelmenu.Location = new System.Drawing.Point(965, 568);
            this.btnozelmenu.Name = "btnozelmenu";
            this.btnozelmenu.Size = new System.Drawing.Size(378, 100);
            this.btnozelmenu.TabIndex = 10;
            this.btnozelmenu.Text = "Özel Menü Tarifleri";
            this.btnozelmenu.UseVisualStyleBackColor = true;
            this.btnozelmenu.Click += new System.EventHandler(this.btnozelmenu_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 52F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1360, 671);
            this.Controls.Add(this.btnozelmenu);
            this.Controls.Add(this.lblascimesaji);
            this.Controls.Add(this.grpasci);
            this.Controls.Add(this.grpgununmenusu);
            this.Controls.Add(this.btnyenitarif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnyemekler);
            this.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YemekUstam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.MouseEnter += new System.EventHandler(this.AnaForm_MouseEnter);
            this.grpgununmenusu.ResumeLayout(false);
            this.grpgununmenusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbasci)).EndInit();
            this.grpasci.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyemekler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyenitarif;
        private System.Windows.Forms.GroupBox grpgununmenusu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbasci;
        private System.Windows.Forms.Button btnevet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpasci;
        private System.Windows.Forms.Label lblascimesaji;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnozelmenu;

    }
}

