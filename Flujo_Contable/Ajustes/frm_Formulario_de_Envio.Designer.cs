namespace Flujo_Contable.Ajustes
{
    partial class frm_Formulario_de_Envio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Formulario_de_Envio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msk_Cedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Placa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Sucursales = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Quitar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgv_Inventario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id_Saco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeSaco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_InventarioEnvio = new System.Windows.Forms.DataGridView();
            this.Id_Saco1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeSaco1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.lb_Sucursal = new System.Windows.Forms.Label();
            this.txt_Prueba = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Limpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InventarioEnvio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msk_Cedula);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(338, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Distribuidor";
            // 
            // msk_Cedula
            // 
            this.msk_Cedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msk_Cedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msk_Cedula.HintForeColor = System.Drawing.Color.Empty;
            this.msk_Cedula.HintText = "Cedula Distribuidor";
            this.msk_Cedula.isPassword = false;
            this.msk_Cedula.LineFocusedColor = System.Drawing.Color.Blue;
            this.msk_Cedula.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.msk_Cedula.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.msk_Cedula.LineThickness = 3;
            this.msk_Cedula.Location = new System.Drawing.Point(14, 74);
            this.msk_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msk_Cedula.Name = "msk_Cedula";
            this.msk_Cedula.Size = new System.Drawing.Size(302, 31);
            this.msk_Cedula.TabIndex = 4;
            this.msk_Cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.msk_Cedula.OnValueChanged += new System.EventHandler(this.msk_Cedula_OnValueChanged);
            this.msk_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_Cedula_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Nombre.HintText = "Nombre Distribuidor";
            this.txt_Nombre.isPassword = false;
            this.txt_Nombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.txt_Nombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineThickness = 3;
            this.txt_Nombre.Location = new System.Drawing.Point(14, 27);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(299, 31);
            this.txt_Nombre.TabIndex = 3;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Placa);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(378, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(321, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Vehículo";
            // 
            // txt_Placa
            // 
            this.txt_Placa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Placa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Placa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Placa.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Placa.HintText = "Placa";
            this.txt_Placa.isPassword = false;
            this.txt_Placa.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Placa.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.txt_Placa.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Placa.LineThickness = 3;
            this.txt_Placa.Location = new System.Drawing.Point(17, 44);
            this.txt_Placa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(293, 31);
            this.txt_Placa.TabIndex = 5;
            this.txt_Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sucursal a enviar:";
            // 
            // cbo_Sucursales
            // 
            this.cbo_Sucursales.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Sucursales.FormattingEnabled = true;
            this.cbo_Sucursales.Location = new System.Drawing.Point(167, 26);
            this.cbo_Sucursales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_Sucursales.Name = "cbo_Sucursales";
            this.cbo_Sucursales.Size = new System.Drawing.Size(147, 27);
            this.cbo_Sucursales.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Descripcion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbo_Sucursales);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(669, 68);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otros Datos";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(445, 16);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(215, 48);
            this.txt_Descripcion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripción:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Quitar);
            this.groupBox4.Controls.Add(this.btn_Agregar);
            this.groupBox4.Controls.Add(this.dgv_Inventario);
            this.groupBox4.Controls.Add(this.dgv_InventarioEnvio);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(30, 272);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(832, 256);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inventario";
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Quitar.Image")));
            this.btn_Quitar.ImageActive = null;
            this.btn_Quitar.Location = new System.Drawing.Point(400, 165);
            this.btn_Quitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(24, 26);
            this.btn_Quitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Quitar.TabIndex = 8;
            this.btn_Quitar.TabStop = false;
            this.btn_Quitar.Zoom = 10;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageActive = null;
            this.btn_Agregar.Location = new System.Drawing.Point(400, 92);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(24, 26);
            this.btn_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.TabStop = false;
            this.btn_Agregar.Zoom = 10;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgv_Inventario
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Inventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Inventario.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Inventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Saco,
            this.Descripcion,
            this.Ubicacion,
            this.Login,
            this.Fecha,
            this.TipodeSaco});
            this.dgv_Inventario.DoubleBuffered = true;
            this.dgv_Inventario.EnableHeadersVisualStyles = false;
            this.dgv_Inventario.GridColor = System.Drawing.Color.Gray;
            this.dgv_Inventario.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dgv_Inventario.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Inventario.Location = new System.Drawing.Point(6, 22);
            this.dgv_Inventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Inventario.RowTemplate.Height = 24;
            this.dgv_Inventario.Size = new System.Drawing.Size(370, 229);
            this.dgv_Inventario.TabIndex = 4;
            // 
            // Id_Saco
            // 
            this.Id_Saco.DataPropertyName = "Id_Saco";
            this.Id_Saco.HeaderText = "Id_Saco";
            this.Id_Saco.Name = "Id_Saco";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // TipodeSaco
            // 
            this.TipodeSaco.DataPropertyName = "TipodeSaco";
            this.TipodeSaco.HeaderText = "TipodeSaco";
            this.TipodeSaco.Name = "TipodeSaco";
            // 
            // dgv_InventarioEnvio
            // 
            this.dgv_InventarioEnvio.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_InventarioEnvio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InventarioEnvio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Saco1,
            this.Descripcion1,
            this.Ubicacion1,
            this.Login1,
            this.Fecha1,
            this.TipodeSaco1});
            this.dgv_InventarioEnvio.GridColor = System.Drawing.Color.Gray;
            this.dgv_InventarioEnvio.Location = new System.Drawing.Point(445, 22);
            this.dgv_InventarioEnvio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_InventarioEnvio.Name = "dgv_InventarioEnvio";
            this.dgv_InventarioEnvio.RowTemplate.Height = 24;
            this.dgv_InventarioEnvio.Size = new System.Drawing.Size(382, 229);
            this.dgv_InventarioEnvio.TabIndex = 1;
            // 
            // Id_Saco1
            // 
            this.Id_Saco1.HeaderText = "Id_Saco";
            this.Id_Saco1.Name = "Id_Saco1";
            // 
            // Descripcion1
            // 
            this.Descripcion1.HeaderText = "Descripcion";
            this.Descripcion1.Name = "Descripcion1";
            // 
            // Ubicacion1
            // 
            this.Ubicacion1.HeaderText = "Ubicacion";
            this.Ubicacion1.Name = "Ubicacion1";
            // 
            // Login1
            // 
            this.Login1.HeaderText = "Login";
            this.Login1.Name = "Login1";
            // 
            // Fecha1
            // 
            this.Fecha1.HeaderText = "Fecha";
            this.Fecha1.Name = "Fecha1";
            // 
            // TipodeSaco1
            // 
            this.TipodeSaco1.HeaderText = "TipodeSaco";
            this.TipodeSaco1.Name = "TipodeSaco1";
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Usuario.Location = new System.Drawing.Point(815, 534);
            this.lb_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(47, 16);
            this.lb_Usuario.TabIndex = 11;
            this.lb_Usuario.Text = "Usuario";
            // 
            // lb_Sucursal
            // 
            this.lb_Sucursal.AutoSize = true;
            this.lb_Sucursal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sucursal.Location = new System.Drawing.Point(717, 534);
            this.lb_Sucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Sucursal.Name = "lb_Sucursal";
            this.lb_Sucursal.Size = new System.Drawing.Size(52, 16);
            this.lb_Sucursal.TabIndex = 12;
            this.lb_Sucursal.Text = "Sucursal";
            // 
            // txt_Prueba
            // 
            this.txt_Prueba.Location = new System.Drawing.Point(378, 534);
            this.txt_Prueba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Prueba.Name = "txt_Prueba";
            this.txt_Prueba.Size = new System.Drawing.Size(122, 20);
            this.txt_Prueba.TabIndex = 13;
            this.txt_Prueba.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 40);
            this.panel1.TabIndex = 14;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(858, 4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 16;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Envios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Enviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Enviar.BackColor = System.Drawing.Color.White;
            this.btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Enviar.BorderRadius = 0;
            this.btn_Enviar.ButtonText = "Enviar";
            this.btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enviar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Enviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Enviar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Enviar.Iconimage")));
            this.btn_Enviar.Iconimage_right = null;
            this.btn_Enviar.Iconimage_right_Selected = null;
            this.btn_Enviar.Iconimage_Selected = null;
            this.btn_Enviar.IconMarginLeft = 0;
            this.btn_Enviar.IconMarginRight = 0;
            this.btn_Enviar.IconRightVisible = true;
            this.btn_Enviar.IconRightZoom = 0D;
            this.btn_Enviar.IconVisible = true;
            this.btn_Enviar.IconZoom = 90D;
            this.btn_Enviar.IsTab = false;
            this.btn_Enviar.Location = new System.Drawing.Point(720, 89);
            this.btn_Enviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Normalcolor = System.Drawing.Color.White;
            this.btn_Enviar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Enviar.selected = false;
            this.btn_Enviar.Size = new System.Drawing.Size(142, 48);
            this.btn_Enviar.TabIndex = 15;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Enviar.Textcolor = System.Drawing.Color.Black;
            this.btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
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
            this.btn_Limpiar.Location = new System.Drawing.Point(720, 174);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Normalcolor = System.Drawing.Color.White;
            this.btn_Limpiar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Limpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Limpiar.selected = false;
            this.btn_Limpiar.Size = new System.Drawing.Size(142, 51);
            this.btn_Limpiar.TabIndex = 16;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.Textcolor = System.Drawing.Color.Black;
            this.btn_Limpiar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frm_Formulario_de_Envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 560);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Prueba);
            this.Controls.Add(this.lb_Sucursal);
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Formulario_de_Envio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Envío";
            this.Load += new System.EventHandler(this.frm_Formulario_de_Envio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InventarioEnvio)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Sucursales;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_InventarioEnvio;
        public System.Windows.Forms.Label lb_Usuario;
        public System.Windows.Forms.Label lb_Sucursal;
        private System.Windows.Forms.TextBox txt_Prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Saco1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeSaco1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Inventario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox msk_Cedula;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Placa;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Enviar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Saco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeSaco;
        private Bunifu.Framework.UI.BunifuImageButton btn_Quitar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Agregar;
    }
}