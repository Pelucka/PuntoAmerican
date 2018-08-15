namespace Flujo_Contable
{
    partial class frm_ListaApartado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListaApartado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Apartados = new System.Windows.Forms.DataGridView();
            this.Id_Apartados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoApartado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Ubicacion = new System.Windows.Forms.Label();
            this.msk_CedulaBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Nombre = new System.Windows.Forms.RadioButton();
            this.rb_Cedula = new System.Windows.Forms.RadioButton();
            this.txt_NombreBuscar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IdApartado = new System.Windows.Forms.TextBox();
            this.txt_PrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_Apartado = new System.Windows.Forms.GroupBox();
            this.rb_Ropa = new System.Windows.Forms.RadioButton();
            this.rb_Jueguete = new System.Windows.Forms.RadioButton();
            this.mtxt_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CantidadPagado = new System.Windows.Forms.TextBox();
            this.mtxt_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_Tarjeta = new System.Windows.Forms.RadioButton();
            this.rb_Efectivo = new System.Windows.Forms.RadioButton();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lb_Descripcion = new System.Windows.Forms.Label();
            this.txt_DineroPagadoFinal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_FaltadePagar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Pagar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Apartados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grb_Apartado.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Apartados);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Apartados";
            // 
            // dgv_Apartados
            // 
            this.dgv_Apartados.AllowUserToAddRows = false;
            this.dgv_Apartados.AllowUserToDeleteRows = false;
            this.dgv_Apartados.AllowUserToResizeColumns = false;
            this.dgv_Apartados.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Apartados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Apartados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Apartados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Apartados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Apartados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Apartados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Apartados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Apartados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Apartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Apartados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Apartados,
            this.Cedula,
            this.Nombre,
            this.Telefono,
            this.TipoApartado,
            this.Descripcion,
            this.PrecioProducto,
            this.CantidadPagado,
            this.FechaInicial,
            this.FechaFinal});
            this.dgv_Apartados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Apartados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Apartados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Apartados.EnableHeadersVisualStyles = false;
            this.dgv_Apartados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.dgv_Apartados.Location = new System.Drawing.Point(3, 22);
            this.dgv_Apartados.MultiSelect = false;
            this.dgv_Apartados.Name = "dgv_Apartados";
            this.dgv_Apartados.ReadOnly = true;
            this.dgv_Apartados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Apartados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Apartados.RowHeadersVisible = false;
            this.dgv_Apartados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Apartados.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Apartados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Apartados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Apartados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Apartados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Apartados.Size = new System.Drawing.Size(998, 369);
            this.dgv_Apartados.TabIndex = 3;
            this.dgv_Apartados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Apartados_CellContentClick);
            // 
            // Id_Apartados
            // 
            this.Id_Apartados.DataPropertyName = "Id_Apartados";
            this.Id_Apartados.HeaderText = "Id_Apartados";
            this.Id_Apartados.Name = "Id_Apartados";
            this.Id_Apartados.ReadOnly = true;
            this.Id_Apartados.Visible = false;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // TipoApartado
            // 
            this.TipoApartado.DataPropertyName = "TipoApartado";
            this.TipoApartado.HeaderText = "TipoApartado";
            this.TipoApartado.Name = "TipoApartado";
            this.TipoApartado.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.DataPropertyName = "PrecioProducto";
            this.PrecioProducto.HeaderText = "PrecioProducto";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            // 
            // CantidadPagado
            // 
            this.CantidadPagado.DataPropertyName = "CantidadPagado";
            this.CantidadPagado.HeaderText = "CantidadPagado";
            this.CantidadPagado.Name = "CantidadPagado";
            this.CantidadPagado.ReadOnly = true;
            // 
            // FechaInicial
            // 
            this.FechaInicial.DataPropertyName = "FechaInicial";
            this.FechaInicial.HeaderText = "FechaInicial";
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.ReadOnly = true;
            // 
            // FechaFinal
            // 
            this.FechaFinal.DataPropertyName = "FechaFinal";
            this.FechaFinal.HeaderText = "FechaFinal";
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Limpiar);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.lbl_Ubicacion);
            this.groupBox2.Controls.Add(this.msk_CedulaBusqueda);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rb_Nombre);
            this.groupBox2.Controls.Add(this.rb_Cedula);
            this.groupBox2.Controls.Add(this.txt_NombreBuscar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de Apartado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Image")));
            this.btn_Limpiar.ImageActive = null;
            this.btn_Limpiar.Location = new System.Drawing.Point(911, 36);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(55, 55);
            this.btn_Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.TabStop = false;
            this.btn_Limpiar.Zoom = 10;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageActive = null;
            this.btn_Buscar.Location = new System.Drawing.Point(814, 36);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(55, 55);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Buscar.TabIndex = 8;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Zoom = 10;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_Ubicacion
            // 
            this.lbl_Ubicacion.AutoSize = true;
            this.lbl_Ubicacion.Location = new System.Drawing.Point(161, 84);
            this.lbl_Ubicacion.Name = "lbl_Ubicacion";
            this.lbl_Ubicacion.Size = new System.Drawing.Size(17, 20);
            this.lbl_Ubicacion.TabIndex = 7;
            this.lbl_Ubicacion.Text = "0";
            this.lbl_Ubicacion.Visible = false;
            // 
            // msk_CedulaBusqueda
            // 
            this.msk_CedulaBusqueda.Location = new System.Drawing.Point(154, 50);
            this.msk_CedulaBusqueda.Mask = "#-####-####";
            this.msk_CedulaBusqueda.Name = "msk_CedulaBusqueda";
            this.msk_CedulaBusqueda.Size = new System.Drawing.Size(622, 26);
            this.msk_CedulaBusqueda.TabIndex = 3;
            this.msk_CedulaBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_CedulaBusqueda.Visible = false;
            this.msk_CedulaBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_CedulaBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busqueda:";
            // 
            // rb_Nombre
            // 
            this.rb_Nombre.AutoSize = true;
            this.rb_Nombre.Location = new System.Drawing.Point(24, 67);
            this.rb_Nombre.Name = "rb_Nombre";
            this.rb_Nombre.Size = new System.Drawing.Size(86, 24);
            this.rb_Nombre.TabIndex = 3;
            this.rb_Nombre.TabStop = true;
            this.rb_Nombre.Text = "Nombre";
            this.rb_Nombre.UseVisualStyleBackColor = true;
            this.rb_Nombre.CheckedChanged += new System.EventHandler(this.rb_Nombre_CheckedChanged);
            // 
            // rb_Cedula
            // 
            this.rb_Cedula.AutoSize = true;
            this.rb_Cedula.Location = new System.Drawing.Point(24, 29);
            this.rb_Cedula.Name = "rb_Cedula";
            this.rb_Cedula.Size = new System.Drawing.Size(81, 24);
            this.rb_Cedula.TabIndex = 2;
            this.rb_Cedula.TabStop = true;
            this.rb_Cedula.Text = "Cedula";
            this.rb_Cedula.UseVisualStyleBackColor = true;
            this.rb_Cedula.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txt_NombreBuscar
            // 
            this.txt_NombreBuscar.Location = new System.Drawing.Point(154, 50);
            this.txt_NombreBuscar.Name = "txt_NombreBuscar";
            this.txt_NombreBuscar.Size = new System.Drawing.Size(622, 26);
            this.txt_NombreBuscar.TabIndex = 1;
            this.txt_NombreBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NombreBuscar.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_IdApartado);
            this.groupBox3.Controls.Add(this.txt_PrecioProducto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.grb_Apartado);
            this.groupBox3.Controls.Add(this.mtxt_Cedula);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_CantidadPagado);
            this.groupBox3.Controls.Add(this.mtxt_Telefono);
            this.groupBox3.Controls.Add(this.txt_Nombre);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1031, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 269);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Apartado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Id:";
            // 
            // txt_IdApartado
            // 
            this.txt_IdApartado.Enabled = false;
            this.txt_IdApartado.Location = new System.Drawing.Point(164, 22);
            this.txt_IdApartado.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdApartado.Name = "txt_IdApartado";
            this.txt_IdApartado.Size = new System.Drawing.Size(151, 26);
            this.txt_IdApartado.TabIndex = 18;
            // 
            // txt_PrecioProducto
            // 
            this.txt_PrecioProducto.Enabled = false;
            this.txt_PrecioProducto.Location = new System.Drawing.Point(164, 210);
            this.txt_PrecioProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrecioProducto.Name = "txt_PrecioProducto";
            this.txt_PrecioProducto.Size = new System.Drawing.Size(151, 26);
            this.txt_PrecioProducto.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio Producto:";
            // 
            // grb_Apartado
            // 
            this.grb_Apartado.Controls.Add(this.rb_Ropa);
            this.grb_Apartado.Controls.Add(this.rb_Jueguete);
            this.grb_Apartado.Enabled = false;
            this.grb_Apartado.Location = new System.Drawing.Point(6, 142);
            this.grb_Apartado.Name = "grb_Apartado";
            this.grb_Apartado.Size = new System.Drawing.Size(309, 58);
            this.grb_Apartado.TabIndex = 15;
            this.grb_Apartado.TabStop = false;
            this.grb_Apartado.Text = "Tipo de Apartado:";
            // 
            // rb_Ropa
            // 
            this.rb_Ropa.AutoSize = true;
            this.rb_Ropa.Location = new System.Drawing.Point(193, 23);
            this.rb_Ropa.Name = "rb_Ropa";
            this.rb_Ropa.Size = new System.Drawing.Size(66, 24);
            this.rb_Ropa.TabIndex = 1;
            this.rb_Ropa.TabStop = true;
            this.rb_Ropa.Text = "Ropa";
            this.rb_Ropa.UseVisualStyleBackColor = true;
            // 
            // rb_Jueguete
            // 
            this.rb_Jueguete.AutoSize = true;
            this.rb_Jueguete.Location = new System.Drawing.Point(39, 23);
            this.rb_Jueguete.Name = "rb_Jueguete";
            this.rb_Jueguete.Size = new System.Drawing.Size(97, 24);
            this.rb_Jueguete.TabIndex = 0;
            this.rb_Jueguete.TabStop = true;
            this.rb_Jueguete.Text = "Jueguete";
            this.rb_Jueguete.UseVisualStyleBackColor = true;
            // 
            // mtxt_Cedula
            // 
            this.mtxt_Cedula.Enabled = false;
            this.mtxt_Cedula.Location = new System.Drawing.Point(164, 50);
            this.mtxt_Cedula.Mask = "#-####-####";
            this.mtxt_Cedula.Name = "mtxt_Cedula";
            this.mtxt_Cedula.Size = new System.Drawing.Size(151, 26);
            this.mtxt_Cedula.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cantidad Pagado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // txt_CantidadPagado
            // 
            this.txt_CantidadPagado.Enabled = false;
            this.txt_CantidadPagado.Location = new System.Drawing.Point(164, 238);
            this.txt_CantidadPagado.Name = "txt_CantidadPagado";
            this.txt_CantidadPagado.Size = new System.Drawing.Size(151, 26);
            this.txt_CantidadPagado.TabIndex = 7;
            // 
            // mtxt_Telefono
            // 
            this.mtxt_Telefono.Enabled = false;
            this.mtxt_Telefono.Location = new System.Drawing.Point(164, 108);
            this.mtxt_Telefono.Mask = "####-####";
            this.mtxt_Telefono.Name = "mtxt_Telefono";
            this.mtxt_Telefono.Size = new System.Drawing.Size(151, 26);
            this.mtxt_Telefono.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(164, 78);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(151, 26);
            this.txt_Nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cedula:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_Tarjeta);
            this.groupBox4.Controls.Add(this.rb_Efectivo);
            this.groupBox4.Controls.Add(this.lbl_Usuario);
            this.groupBox4.Controls.Add(this.lb_Descripcion);
            this.groupBox4.Controls.Add(this.txt_DineroPagadoFinal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lbl_FaltadePagar);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1031, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 151);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pago Final";
            // 
            // rb_Tarjeta
            // 
            this.rb_Tarjeta.AutoSize = true;
            this.rb_Tarjeta.Location = new System.Drawing.Point(163, 26);
            this.rb_Tarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Tarjeta.Name = "rb_Tarjeta";
            this.rb_Tarjeta.Size = new System.Drawing.Size(75, 24);
            this.rb_Tarjeta.TabIndex = 9;
            this.rb_Tarjeta.TabStop = true;
            this.rb_Tarjeta.Text = "Tarjeta";
            this.rb_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // rb_Efectivo
            // 
            this.rb_Efectivo.AutoSize = true;
            this.rb_Efectivo.Location = new System.Drawing.Point(42, 28);
            this.rb_Efectivo.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Efectivo.Name = "rb_Efectivo";
            this.rb_Efectivo.Size = new System.Drawing.Size(88, 24);
            this.rb_Efectivo.TabIndex = 8;
            this.rb_Efectivo.TabStop = true;
            this.rb_Efectivo.Text = "Efectivo";
            this.rb_Efectivo.UseVisualStyleBackColor = true;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(197, 28);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(0, 20);
            this.lbl_Usuario.TabIndex = 7;
            // 
            // lb_Descripcion
            // 
            this.lb_Descripcion.AutoSize = true;
            this.lb_Descripcion.Location = new System.Drawing.Point(110, 24);
            this.lb_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Descripcion.Name = "lb_Descripcion";
            this.lb_Descripcion.Size = new System.Drawing.Size(0, 20);
            this.lb_Descripcion.TabIndex = 6;
            this.lb_Descripcion.Visible = false;
            // 
            // txt_DineroPagadoFinal
            // 
            this.txt_DineroPagadoFinal.Location = new System.Drawing.Point(164, 107);
            this.txt_DineroPagadoFinal.Name = "txt_DineroPagadoFinal";
            this.txt_DineroPagadoFinal.Size = new System.Drawing.Size(151, 26);
            this.txt_DineroPagadoFinal.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Dinero Pagado:";
            // 
            // lbl_FaltadePagar
            // 
            this.lbl_FaltadePagar.AutoSize = true;
            this.lbl_FaltadePagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FaltadePagar.Location = new System.Drawing.Point(211, 67);
            this.lbl_FaltadePagar.Name = "lbl_FaltadePagar";
            this.lbl_FaltadePagar.Size = new System.Drawing.Size(19, 20);
            this.lbl_FaltadePagar.TabIndex = 2;
            this.lbl_FaltadePagar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Faltante a Pagar:";
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
            this.panel1.Size = new System.Drawing.Size(1366, 40);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(54, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lista de Apartados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(1330, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Pagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Pagar.BackColor = System.Drawing.Color.White;
            this.btn_Pagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pagar.BorderRadius = 0;
            this.btn_Pagar.ButtonText = "Aceptar";
            this.btn_Pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pagar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Pagar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Pagar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Pagar.Iconimage")));
            this.btn_Pagar.Iconimage_right = null;
            this.btn_Pagar.Iconimage_right_Selected = null;
            this.btn_Pagar.Iconimage_Selected = null;
            this.btn_Pagar.IconMarginLeft = 0;
            this.btn_Pagar.IconMarginRight = 0;
            this.btn_Pagar.IconRightVisible = true;
            this.btn_Pagar.IconRightZoom = 0D;
            this.btn_Pagar.IconVisible = true;
            this.btn_Pagar.IconZoom = 90D;
            this.btn_Pagar.IsTab = false;
            this.btn_Pagar.Location = new System.Drawing.Point(1080, 490);
            this.btn_Pagar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Normalcolor = System.Drawing.Color.White;
            this.btn_Pagar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Pagar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Pagar.selected = false;
            this.btn_Pagar.Size = new System.Drawing.Size(235, 66);
            this.btn_Pagar.TabIndex = 6;
            this.btn_Pagar.Text = "Aceptar";
            this.btn_Pagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Pagar.Textcolor = System.Drawing.Color.Black;
            this.btn_Pagar.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Pagar.Click += new System.EventHandler(this.btn_Pagar_Click_1);
            // 
            // frm_ListaApartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 579);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Pagar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ListaApartado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Apartados";
            this.Load += new System.EventHandler(this.frm_ListaApartado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Apartados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grb_Apartado.ResumeLayout(false);
            this.grb_Apartado.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_NombreBuscar;
        private System.Windows.Forms.RadioButton rb_Nombre;
        private System.Windows.Forms.RadioButton rb_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_CedulaBusqueda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.MaskedTextBox mtxt_Telefono;
        private System.Windows.Forms.TextBox txt_CantidadPagado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxt_Cedula;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_FaltadePagar;
        private System.Windows.Forms.TextBox txt_DineroPagadoFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grb_Apartado;
        private System.Windows.Forms.RadioButton rb_Ropa;
        private System.Windows.Forms.RadioButton rb_Jueguete;
        private System.Windows.Forms.DataGridView dgv_Apartados;
        private System.Windows.Forms.TextBox txt_PrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IdApartado;
        public System.Windows.Forms.Label lbl_Ubicacion;
        private System.Windows.Forms.Label lb_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Apartados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoApartado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        public System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.RadioButton rb_Tarjeta;
        private System.Windows.Forms.RadioButton rb_Efectivo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Pagar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Limpiar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Buscar;
    }
}