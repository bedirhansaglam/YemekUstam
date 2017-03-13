namespace FinalProject
{
    partial class Yenitarifekle
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
            this.cbkilitle = new System.Windows.Forms.CheckBox();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbyemekturleri = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbkilitle
            // 
            this.cbkilitle.AutoSize = true;
            this.cbkilitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbkilitle.ForeColor = System.Drawing.Color.White;
            this.cbkilitle.Location = new System.Drawing.Point(7, 534);
            this.cbkilitle.Name = "cbkilitle";
            this.cbkilitle.Size = new System.Drawing.Size(154, 19);
            this.cbkilitle.TabIndex = 1;
            this.cbkilitle.Text = "Seçimi onaylıyorum";
            this.cbkilitle.UseVisualStyleBackColor = true;
            this.cbkilitle.CheckedChanged += new System.EventHandler(this.cbkilitle_CheckedChanged);
            // 
            // btnsonraki
            // 
            this.btnsonraki.Image = global::FinalProject.Properties.Resources.ileri_butonu;
            this.btnsonraki.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsonraki.Location = new System.Drawing.Point(7, 573);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(108, 72);
            this.btnsonraki.TabIndex = 2;
            this.btnsonraki.Text = "Sonraki Adım";
            this.btnsonraki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::FinalProject.Properties.Resources.shef;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lbyemekturleri);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 667);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YEMEK TÜRLERİ";
            // 
            // lbyemekturleri
            // 
            this.lbyemekturleri.BackColor = System.Drawing.Color.Black;
            this.lbyemekturleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbyemekturleri.ForeColor = System.Drawing.Color.White;
            this.lbyemekturleri.FormattingEnabled = true;
            this.lbyemekturleri.ItemHeight = 26;
            this.lbyemekturleri.Location = new System.Drawing.Point(61, 313);
            this.lbyemekturleri.Name = "lbyemekturleri";
            this.lbyemekturleri.Size = new System.Drawing.Size(324, 316);
            this.lbyemekturleri.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnsonraki);
            this.groupBox2.Controls.Add(this.cbkilitle);
            this.groupBox2.Location = new System.Drawing.Point(439, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 645);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 256);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Uyarı : Lütfen önce, ekleyeceğiniz yemek türünü seçiniz. Sonra seçimi onaylıyorum" +
    " bölümünü seçiniz ve sonraki adım butonuna tıklayınız...";
            // 
            // Yenitarifekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Yenitarifekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Tarif Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yenitarifekle_FormClosing);
            this.Load += new System.EventHandler(this.Yenitarifekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbyemekturleri;
        private System.Windows.Forms.CheckBox cbkilitle;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;

    }
}