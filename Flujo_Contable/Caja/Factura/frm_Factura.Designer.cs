namespace Flujo_Contable.Caja.Factura
{
    partial class frm_Factura
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
            this.rpv_Factura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpv_Factura
            // 
            this.rpv_Factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_Factura.LocalReport.ReportEmbeddedResource = "Flujo_Contable.Caja.Factura.Reporte.rdlc";
            this.rpv_Factura.Location = new System.Drawing.Point(0, 0);
            this.rpv_Factura.Name = "rpv_Factura";
            this.rpv_Factura.ServerReport.BearerToken = null;
            this.rpv_Factura.Size = new System.Drawing.Size(884, 761);
            this.rpv_Factura.TabIndex = 0;
            // 
            // frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.rpv_Factura);
            this.Name = "frm_Factura";
            this.Text = "frm_Factura";
            this.Load += new System.EventHandler(this.frm_Factura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpv_Factura;
    }
}