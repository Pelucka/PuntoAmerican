namespace Flujo_Contable.Otros
{
    partial class frm_Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mensaje));
            this.pic_Check = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.tmr_Tiempo = new System.Windows.Forms.Timer(this.components);
            this.tmr_Tiempo2 = new System.Windows.Forms.Timer(this.components);
            this.pic_Lock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lock)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Check
            // 
            this.pic_Check.BackColor = System.Drawing.Color.White;
            this.pic_Check.Image = ((System.Drawing.Image)(resources.GetObject("pic_Check.Image")));
            this.pic_Check.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Check.InitialImage")));
            this.pic_Check.Location = new System.Drawing.Point(18, -4);
            this.pic_Check.Name = "pic_Check";
            this.pic_Check.Size = new System.Drawing.Size(142, 152);
            this.pic_Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Check.TabIndex = 0;
            this.pic_Check.TabStop = false;
            this.pic_Check.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensaje.Location = new System.Drawing.Point(218, 60);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Mensaje.Size = new System.Drawing.Size(144, 33);
            this.lbl_Mensaje.TabIndex = 1;
            this.lbl_Mensaje.Text = "Eliminado";
            this.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_Tiempo
            // 
            this.tmr_Tiempo.Interval = 22;
            this.tmr_Tiempo.Tick += new System.EventHandler(this.tmr_Tiempo_Tick);
            // 
            // tmr_Tiempo2
            // 
            this.tmr_Tiempo2.Interval = 1250;
            this.tmr_Tiempo2.Tick += new System.EventHandler(this.tmr_Tiempo2_Tick);
            // 
            // pic_Lock
            // 
            this.pic_Lock.Image = ((System.Drawing.Image)(resources.GetObject("pic_Lock.Image")));
            this.pic_Lock.Location = new System.Drawing.Point(18, -4);
            this.pic_Lock.Name = "pic_Lock";
            this.pic_Lock.Size = new System.Drawing.Size(142, 152);
            this.pic_Lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Lock.TabIndex = 2;
            this.pic_Lock.TabStop = false;
            this.pic_Lock.Visible = false;
            // 
            // frm_Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 155);
            this.ControlBox = false;
            this.Controls.Add(this.pic_Lock);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.pic_Check);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1395, 850);
            this.Name = "frm_Mensaje";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_Mensaje";
            this.Load += new System.EventHandler(this.frm_Mensaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Timer tmr_Tiempo;
        private System.Windows.Forms.Timer tmr_Tiempo2;
        public System.Windows.Forms.PictureBox pic_Lock;
        public System.Windows.Forms.PictureBox pic_Check;
    }
}