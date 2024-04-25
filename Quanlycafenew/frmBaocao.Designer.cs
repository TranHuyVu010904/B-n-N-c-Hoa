namespace Quanlycafenew
{
    partial class frmBaocao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaocao));
            this.tbHoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCoffeeDataSet1 = new Quanlycafenew.QLCoffeeDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbHoadonTableAdapter = new Quanlycafenew.QLCoffeeDataSet1TableAdapters.tbHoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCoffeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHoadonBindingSource
            // 
            this.tbHoadonBindingSource.DataMember = "tbHoadon";
            this.tbHoadonBindingSource.DataSource = this.QLCoffeeDataSet1;
            // 
            // QLCoffeeDataSet1
            // 
            this.QLCoffeeDataSet1.DataSetName = "QLCoffeeDataSet1";
            this.QLCoffeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbHoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quanlycafenew.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(992, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbHoadonTableAdapter
            // 
            this.tbHoadonTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1017, 561);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaocao";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.frmBaocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbHoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCoffeeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbHoadonBindingSource;
        private QLCoffeeDataSet1 QLCoffeeDataSet1;
        private QLCoffeeDataSet1TableAdapters.tbHoadonTableAdapter tbHoadonTableAdapter;
    }
}