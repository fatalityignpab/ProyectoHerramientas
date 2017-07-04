namespace Proyecto_BD_HA_V2
{
    partial class ControlReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlReporte));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FactReport2 = new Proyecto_BD_HA_V2.FactReport();
            this.FactReport1 = new Proyecto_BD_HA_V2.FactReport();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.FactReport2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(771, 489);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load_1);
            // 
            // FactReport1
            // 
            this.FactReport1.InitReport += new System.EventHandler(this.FactReport1_InitReport);
            // 
            // ControlReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 490);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlReporte";
            this.Text = "ControlReporte";
            this.Load += new System.EventHandler(this.ControlReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FactReport FactReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private FactReport FactReport2;
    }
}