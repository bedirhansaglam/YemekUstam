namespace FinalProject
{
    partial class rapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.veritabaniDataSet = new FinalProject.veritabaniDataSet();
            this.yemekadiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekadiTableAdapter = new FinalProject.veritabaniDataSetTableAdapters.yemekadiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekadiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.yemekadiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(757, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // veritabaniDataSet
            // 
            this.veritabaniDataSet.DataSetName = "veritabaniDataSet";
            this.veritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yemekadiBindingSource
            // 
            this.yemekadiBindingSource.DataMember = "yemekadi";
            this.yemekadiBindingSource.DataSource = this.veritabaniDataSet;
            // 
            // yemekadiTableAdapter
            // 
            this.yemekadiTableAdapter.ClearBeforeFill = true;
            // 
            // rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 587);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekadiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource yemekadiBindingSource;
        private veritabaniDataSet veritabaniDataSet;
        private veritabaniDataSetTableAdapters.yemekadiTableAdapter yemekadiTableAdapter;
    }
}