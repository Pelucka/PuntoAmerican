namespace Flujo_Contable.Otros
{
    partial class frm_Cargando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cargando));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cpb_Cargando = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cpb_Cargando
            // 
            this.cpb_Cargando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpb_Cargando.animated = true;
            this.cpb_Cargando.animationIterval = 1;
            this.cpb_Cargando.animationSpeed = 1;
            this.cpb_Cargando.BackColor = System.Drawing.Color.Transparent;
            this.cpb_Cargando.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpb_Cargando.BackgroundImage")));
            this.cpb_Cargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpb_Cargando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpb_Cargando.LabelVisible = false;
            this.cpb_Cargando.LineProgressThickness = 10;
            this.cpb_Cargando.LineThickness = 8;
            this.cpb_Cargando.Location = new System.Drawing.Point(19, 18);
            this.cpb_Cargando.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpb_Cargando.MaxValue = 100;
            this.cpb_Cargando.Name = "cpb_Cargando";
            this.cpb_Cargando.ProgressBackColor = System.Drawing.Color.Transparent;
            this.cpb_Cargando.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.cpb_Cargando.Size = new System.Drawing.Size(101, 101);
            this.cpb_Cargando.TabIndex = 33;
            this.cpb_Cargando.Value = 50;
            // 
            // frm_Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(140, 140);
            this.Controls.Add(this.cpb_Cargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Cargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpb_Cargando;
    }
}