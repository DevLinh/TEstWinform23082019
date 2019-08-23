namespace Test1
{
    partial class rp
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSV = new Test1.dsSV();
            this.SinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SinhVienTableAdapter = new Test1.dsSVTableAdapters.SinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSV";
            reportDataSource1.Value = this.SinhVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test1.rpSV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1013, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsSV
            // 
            this.dsSV.DataSetName = "dsSV";
            this.dsSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SinhVienBindingSource
            // 
            this.SinhVienBindingSource.DataMember = "SinhVien";
            this.SinhVienBindingSource.DataSource = this.dsSV;
            // 
            // SinhVienTableAdapter
            // 
            this.SinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 507);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rp";
            this.Text = "rp";
            this.Load += new System.EventHandler(this.rp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SinhVienBindingSource;
        private dsSV dsSV;
        private dsSVTableAdapters.SinhVienTableAdapter SinhVienTableAdapter;
    }
}