namespace Flujo_Contable
{
    partial class frm_Apartados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Apartados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_PrecioProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Juguete = new System.Windows.Forms.RadioButton();
            this.rb_Ropa = new System.Windows.Forms.RadioButton();
            this.mtxt_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_CantidadPagado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.mtxt_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_TipoApartado = new System.Windows.Forms.GroupBox();
            this.txt_Decripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Ubicacion = new System.Windows.Forms.Label();
            this.rb_15Dias = new System.Windows.Forms.RadioButton();
            this.rb_Mes = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_Tarjeta = new System.Windows.Forms.RadioButton();
            this.rb_Efectivo = new System.Windows.Forms.RadioButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Limpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grb_TipoApartado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txt_PrecioProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.mtxt_Telefono);
            this.groupBox1.Controls.Add(this.txt_CantidadPagado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.mtxt_Cedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // txt_PrecioProducto
            // 
            this.txt_PrecioProducto.Location = new System.Drawing.Point(158, 185);
            this.txt_PrecioProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_PrecioProducto.Name = "txt_PrecioProducto";
            this.txt_PrecioProducto.Size = new System.Drawing.Size(148, 26);
            this.txt_PrecioProducto.TabIndex = 6;
            this.txt_PrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Juguete);
            this.groupBox2.Controls.Add(this.rb_Ropa);
            this.groupBox2.Location = new System.Drawing.Point(9, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 55);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Apartado:";
            // 
            // rb_Juguete
            // 
            this.rb_Juguete.AutoSize = true;
            this.rb_Juguete.Location = new System.Drawing.Point(43, 19);
            this.rb_Juguete.Name = "rb_Juguete";
            this.rb_Juguete.Size = new System.Drawing.Size(87, 24);
            this.rb_Juguete.TabIndex = 4;
            this.rb_Juguete.TabStop = true;
            this.rb_Juguete.Text = "Juguete";
            this.rb_Juguete.UseVisualStyleBackColor = true;
            this.rb_Juguete.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_Ropa
            // 
            this.rb_Ropa.AutoSize = true;
            this.rb_Ropa.Location = new System.Drawing.Point(187, 19);
            this.rb_Ropa.Name = "rb_Ropa";
            this.rb_Ropa.Size = new System.Drawing.Size(66, 24);
            this.rb_Ropa.TabIndex = 5;
            this.rb_Ropa.TabStop = true;
            this.rb_Ropa.Text = "Ropa";
            this.rb_Ropa.UseVisualStyleBackColor = true;
            this.rb_Ropa.CheckedChanged += new System.EventHandler(this.rb_Ropa_CheckedChanged);
            // 
            // mtxt_Telefono
            // 
            this.mtxt_Telefono.Location = new System.Drawing.Point(144, 77);
            this.mtxt_Telefono.Mask = "####-####";
            this.mtxt_Telefono.Name = "mtxt_Telefono";
            this.mtxt_Telefono.Size = new System.Drawing.Size(154, 26);
            this.mtxt_Telefono.TabIndex = 3;
            this.mtxt_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_Telefono_KeyPress);
            // 
            // txt_CantidadPagado
            // 
            this.txt_CantidadPagado.Location = new System.Drawing.Point(158, 219);
            this.txt_CantidadPagado.Name = "txt_CantidadPagado";
            this.txt_CantidadPagado.Size = new System.Drawing.Size(148, 26);
            this.txt_CantidadPagado.TabIndex = 7;
            this.txt_CantidadPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadPagado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad Pagado:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(144, 47);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(154, 26);
            this.txt_Nombre.TabIndex = 2;
            // 
            // mtxt_Cedula
            // 
            this.mtxt_Cedula.Location = new System.Drawing.Point(144, 17);
            this.mtxt_Cedula.Mask = "#-####-####";
            this.mtxt_Cedula.Name = "mtxt_Cedula";
            this.mtxt_Cedula.Size = new System.Drawing.Size(154, 26);
            this.mtxt_Cedula.TabIndex = 1;
            this.mtxt_Cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_Cedula_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // grb_TipoApartado
            // 
            this.grb_TipoApartado.Controls.Add(this.txt_Decripcion);
            this.grb_TipoApartado.Controls.Add(this.label5);
            this.grb_TipoApartado.Enabled = false;
            this.grb_TipoApartado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TipoApartado.Location = new System.Drawing.Point(331, 52);
            this.grb_TipoApartado.Name = "grb_TipoApartado";
            this.grb_TipoApartado.Size = new System.Drawing.Size(329, 70);
            this.grb_TipoApartado.TabIndex = 4;
            this.grb_TipoApartado.TabStop = false;
            this.grb_TipoApartado.Text = "Descripción";
            // 
            // txt_Decripcion
            // 
            this.txt_Decripcion.Location = new System.Drawing.Point(110, 13);
            this.txt_Decripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Decripcion.Multiline = true;
            this.txt_Decripcion.Name = "txt_Decripcion";
            this.txt_Decripcion.Size = new System.Drawing.Size(210, 49);
            this.txt_Decripcion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Apartado:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Usuario);
            this.groupBox3.Controls.Add(this.lbl_Ubicacion);
            this.groupBox3.Controls.Add(this.rb_15Dias);
            this.groupBox3.Controls.Add(this.rb_Mes);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(331, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(329, 59);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo del Apartado";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(28, 52);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(0, 20);
            this.lbl_Usuario.TabIndex = 12;
            // 
            // lbl_Ubicacion
            // 
            this.lbl_Ubicacion.AutoSize = true;
            this.lbl_Ubicacion.Location = new System.Drawing.Point(149, 19);
            this.lbl_Ubicacion.Name = "lbl_Ubicacion";
            this.lbl_Ubicacion.Size = new System.Drawing.Size(0, 20);
            this.lbl_Ubicacion.TabIndex = 11;
            this.lbl_Ubicacion.Visible = false;
            // 
            // rb_15Dias
            // 
            this.rb_15Dias.AutoSize = true;
            this.rb_15Dias.Location = new System.Drawing.Point(211, 23);
            this.rb_15Dias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_15Dias.Name = "rb_15Dias";
            this.rb_15Dias.Size = new System.Drawing.Size(77, 24);
            this.rb_15Dias.TabIndex = 10;
            this.rb_15Dias.TabStop = true;
            this.rb_15Dias.Text = "15 Días";
            this.rb_15Dias.UseVisualStyleBackColor = true;
            // 
            // rb_Mes
            // 
            this.rb_Mes.AutoSize = true;
            this.rb_Mes.Location = new System.Drawing.Point(52, 23);
            this.rb_Mes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Mes.Name = "rb_Mes";
            this.rb_Mes.Size = new System.Drawing.Size(70, 24);
            this.rb_Mes.TabIndex = 9;
            this.rb_Mes.TabStop = true;
            this.rb_Mes.Text = "1 Mes";
            this.rb_Mes.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_Tarjeta);
            this.groupBox4.Controls.Add(this.rb_Efectivo);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(331, 202);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(329, 59);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de Pago";
            // 
            // rb_Tarjeta
            // 
            this.rb_Tarjeta.AutoSize = true;
            this.rb_Tarjeta.Location = new System.Drawing.Point(211, 23);
            this.rb_Tarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Tarjeta.Name = "rb_Tarjeta";
            this.rb_Tarjeta.Size = new System.Drawing.Size(75, 24);
            this.rb_Tarjeta.TabIndex = 1;
            this.rb_Tarjeta.TabStop = true;
            this.rb_Tarjeta.Text = "Tarjeta";
            this.rb_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // rb_Efectivo
            // 
            this.rb_Efectivo.AutoSize = true;
            this.rb_Efectivo.Location = new System.Drawing.Point(52, 25);
            this.rb_Efectivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Efectivo.Name = "rb_Efectivo";
            this.rb_Efectivo.Size = new System.Drawing.Size(88, 24);
            this.rb_Efectivo.TabIndex = 0;
            this.rb_Efectivo.TabStop = true;
            this.rb_Efectivo.Text = "Efectivo";
            this.rb_Efectivo.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 40);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(49, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Apartados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(638, 4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Agregar.BackColor = System.Drawing.Color.White;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.BorderRadius = 0;
            this.btn_Agregar.ButtonText = "Agregar";
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Agregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Iconimage")));
            this.btn_Agregar.Iconimage_right = null;
            this.btn_Agregar.Iconimage_right_Selected = null;
            this.btn_Agregar.Iconimage_Selected = null;
            this.btn_Agregar.IconMarginLeft = 0;
            this.btn_Agregar.IconMarginRight = 0;
            this.btn_Agregar.IconRightVisible = true;
            this.btn_Agregar.IconRightZoom = 0D;
            this.btn_Agregar.IconVisible = true;
            this.btn_Agregar.IconZoom = 90D;
            this.btn_Agregar.IsTab = false;
            this.btn_Agregar.Location = new System.Drawing.Point(335, 269);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Normalcolor = System.Drawing.Color.White;
            this.btn_Agregar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Agregar.selected = false;
            this.btn_Agregar.Size = new System.Drawing.Size(163, 74);
            this.btn_Agregar.TabIndex = 21;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Textcolor = System.Drawing.Color.Black;
            this.btn_Agregar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.BorderRadius = 0;
            this.btn_Limpiar.ButtonText = "Limpiar";
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Limpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Limpiar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Iconimage")));
            this.btn_Limpiar.Iconimage_right = null;
            this.btn_Limpiar.Iconimage_right_Selected = null;
            this.btn_Limpiar.Iconimage_Selected = null;
            this.btn_Limpiar.IconMarginLeft = 0;
            this.btn_Limpiar.IconMarginRight = 0;
            this.btn_Limpiar.IconRightVisible = true;
            this.btn_Limpiar.IconRightZoom = 0D;
            this.btn_Limpiar.IconVisible = true;
            this.btn_Limpiar.IconZoom = 90D;
            this.btn_Limpiar.IsTab = false;
            this.btn_Limpiar.Location = new System.Drawing.Point(503, 269);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Normalcolor = System.Drawing.Color.White;
            this.btn_Limpiar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Limpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Limpiar.selected = false;
            this.btn_Limpiar.Size = new System.Drawing.Size(163, 74);
            this.btn_Limpiar.TabIndex = 22;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.Textcolor = System.Drawing.Color.Black;
            this.btn_Limpiar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frm_Apartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 352);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grb_TipoApartado);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Apartados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grb_TipoApartado.ResumeLayout(false);
            this.grb_TipoApartado.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_Cedula;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CantidadPagado;
        private System.Windows.Forms.MaskedTextBox mtxt_Telefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Juguete;
        private System.Windows.Forms.RadioButton rb_Ropa;
        private System.Windows.Forms.GroupBox grb_TipoApartado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_15Dias;
        private System.Windows.Forms.RadioButton rb_Mes;
        private System.Windows.Forms.TextBox txt_PrecioProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Decripcion;
        public System.Windows.Forms.Label lbl_Ubicacion;
        public System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_Tarjeta;
        private System.Windows.Forms.RadioButton rb_Efectivo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Agregar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Limpiar;
    }
}