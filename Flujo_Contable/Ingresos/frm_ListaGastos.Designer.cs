namespace Flujo_Contable.Ingresos
{
    partial class frm_ListaGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListaGastos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_Gastos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_TipoGasto = new System.Windows.Forms.ComboBox();
            this.cbo_Ubicacion = new System.Windows.Forms.ComboBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.rb_Ubicacion = new System.Windows.Forms.RadioButton();
            this.rb_Fecha = new System.Windows.Forms.RadioButton();
            this.rb_TipoGasto = new System.Windows.Forms.RadioButton();
            this.dtp_Fecha2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Refrescar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gastos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refrescar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgv_Gastos
            // 
            this.dgv_Gastos.AllowUserToAddRows = false;
            this.dgv_Gastos.AllowUserToDeleteRows = false;
            this.dgv_Gastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Gastos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Gastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Gastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Gastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Gastos.Location = new System.Drawing.Point(12, 219);
            this.dgv_Gastos.Name = "dgv_Gastos";
            this.dgv_Gastos.ReadOnly = true;
            this.dgv_Gastos.Size = new System.Drawing.Size(603, 395);
            this.dgv_Gastos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 40);
            this.panel1.TabIndex = 32;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(593, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(30, 30);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 21;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lista de Gastos";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(993, 8);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(37, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ubicación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipo de Gasto:";
            // 
            // cbo_TipoGasto
            // 
            this.cbo_TipoGasto.Enabled = false;
            this.cbo_TipoGasto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TipoGasto.FormattingEnabled = true;
            this.cbo_TipoGasto.Items.AddRange(new object[] {
            "Por Luz",
            "Por Agua",
            "Por Inventario",
            "Varios"});
            this.cbo_TipoGasto.Location = new System.Drawing.Point(185, 160);
            this.cbo_TipoGasto.Name = "cbo_TipoGasto";
            this.cbo_TipoGasto.Size = new System.Drawing.Size(234, 25);
            this.cbo_TipoGasto.TabIndex = 36;
            // 
            // cbo_Ubicacion
            // 
            this.cbo_Ubicacion.Enabled = false;
            this.cbo_Ubicacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Ubicacion.FormattingEnabled = true;
            this.cbo_Ubicacion.Location = new System.Drawing.Point(185, 75);
            this.cbo_Ubicacion.Name = "cbo_Ubicacion";
            this.cbo_Ubicacion.Size = new System.Drawing.Size(234, 25);
            this.cbo_Ubicacion.TabIndex = 37;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fecha.Enabled = false;
            this.dtp_Fecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(185, 116);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(94, 23);
            this.dtp_Fecha.TabIndex = 38;
            // 
            // rb_Ubicacion
            // 
            this.rb_Ubicacion.AutoSize = true;
            this.rb_Ubicacion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Ubicacion.Location = new System.Drawing.Point(33, 79);
            this.rb_Ubicacion.Name = "rb_Ubicacion";
            this.rb_Ubicacion.Size = new System.Drawing.Size(14, 13);
            this.rb_Ubicacion.TabIndex = 39;
            this.rb_Ubicacion.TabStop = true;
            this.rb_Ubicacion.UseVisualStyleBackColor = true;
            this.rb_Ubicacion.CheckedChanged += new System.EventHandler(this.rb_Ubicacion_CheckedChanged);
            // 
            // rb_Fecha
            // 
            this.rb_Fecha.AutoSize = true;
            this.rb_Fecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Fecha.Location = new System.Drawing.Point(33, 121);
            this.rb_Fecha.Name = "rb_Fecha";
            this.rb_Fecha.Size = new System.Drawing.Size(14, 13);
            this.rb_Fecha.TabIndex = 40;
            this.rb_Fecha.TabStop = true;
            this.rb_Fecha.UseVisualStyleBackColor = true;
            this.rb_Fecha.CheckedChanged += new System.EventHandler(this.rb_Fecha_CheckedChanged);
            // 
            // rb_TipoGasto
            // 
            this.rb_TipoGasto.AutoSize = true;
            this.rb_TipoGasto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TipoGasto.Location = new System.Drawing.Point(33, 167);
            this.rb_TipoGasto.Name = "rb_TipoGasto";
            this.rb_TipoGasto.Size = new System.Drawing.Size(14, 13);
            this.rb_TipoGasto.TabIndex = 41;
            this.rb_TipoGasto.TabStop = true;
            this.rb_TipoGasto.UseVisualStyleBackColor = true;
            this.rb_TipoGasto.CheckedChanged += new System.EventHandler(this.rb_TipoGasto_CheckedChanged);
            // 
            // dtp_Fecha2
            // 
            this.dtp_Fecha2.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fecha2.Enabled = false;
            this.dtp_Fecha2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha2.Location = new System.Drawing.Point(325, 116);
            this.dtp_Fecha2.Name = "dtp_Fecha2";
            this.dtp_Fecha2.Size = new System.Drawing.Size(94, 23);
            this.dtp_Fecha2.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "y";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageActive = null;
            this.btn_Buscar.Location = new System.Drawing.Point(463, 98);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(55, 55);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Buscar.TabIndex = 46;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Zoom = 10;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.Image")));
            this.btn_Refrescar.ImageActive = null;
            this.btn_Refrescar.Location = new System.Drawing.Point(533, 98);
            this.btn_Refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(55, 55);
            this.btn_Refrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Refrescar.TabIndex = 47;
            this.btn_Refrescar.TabStop = false;
            this.btn_Refrescar.Zoom = 10;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // frm_ListaGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 626);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_Fecha2);
            this.Controls.Add(this.rb_TipoGasto);
            this.Controls.Add(this.rb_Fecha);
            this.Controls.Add(this.rb_Ubicacion);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.cbo_Ubicacion);
            this.Controls.Add(this.cbo_TipoGasto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Gastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ListaGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ListaGastos";
            this.Load += new System.EventHandler(this.frm_ListaGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gastos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dgv_Gastos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Ubicacion;
        private System.Windows.Forms.ComboBox cbo_TipoGasto;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.RadioButton rb_TipoGasto;
        private System.Windows.Forms.RadioButton rb_Fecha;
        private System.Windows.Forms.RadioButton rb_Ubicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_Fecha2;
        private Bunifu.Framework.UI.BunifuImageButton btn_Refrescar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Buscar;
    }
}