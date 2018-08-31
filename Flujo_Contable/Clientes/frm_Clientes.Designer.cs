namespace Flujo_Contable.Clientes
{
    partial class frm_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_Consulta = new System.Windows.Forms.MaskedTextBox();
            this.btn_Identificador = new System.Windows.Forms.Button();
            this.btn_Telefono = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msk_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_Identificacion = new System.Windows.Forms.ComboBox();
            this.grb_DatosCliente = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_UbicacionExacta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Barrio = new System.Windows.Forms.ComboBox();
            this.cbo_Distrito = new System.Windows.Forms.ComboBox();
            this.cbo_Canton = new System.Windows.Forms.ComboBox();
            this.cbo_Provincia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.msk_Identificacion = new System.Windows.Forms.MaskedTextBox();
            this.cbo_Identif = new System.Windows.Forms.ComboBox();
            this.lbl_IDCliente = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.grb_DatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 36);
            this.panel1.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(1088, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(24, 24);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Close.TabIndex = 21;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Clientes\r\n";
            // 
            // msk_Consulta
            // 
            this.msk_Consulta.Enabled = false;
            this.msk_Consulta.Location = new System.Drawing.Point(262, 56);
            this.msk_Consulta.Name = "msk_Consulta";
            this.msk_Consulta.Size = new System.Drawing.Size(518, 27);
            this.msk_Consulta.TabIndex = 6;
            // 
            // btn_Identificador
            // 
            this.btn_Identificador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btn_Identificador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Identificador.BackgroundImage")));
            this.btn_Identificador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Identificador.Enabled = false;
            this.btn_Identificador.FlatAppearance.BorderSize = 0;
            this.btn_Identificador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.btn_Identificador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btn_Identificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Identificador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Identificador.ForeColor = System.Drawing.Color.White;
            this.btn_Identificador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Identificador.Location = new System.Drawing.Point(786, 43);
            this.btn_Identificador.Name = "btn_Identificador";
            this.btn_Identificador.Size = new System.Drawing.Size(164, 54);
            this.btn_Identificador.TabIndex = 7;
            this.btn_Identificador.UseVisualStyleBackColor = false;
            this.btn_Identificador.Click += new System.EventHandler(this.btn_Identificador_Click);
            // 
            // btn_Telefono
            // 
            this.btn_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btn_Telefono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Telefono.BackgroundImage")));
            this.btn_Telefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Telefono.Enabled = false;
            this.btn_Telefono.FlatAppearance.BorderSize = 0;
            this.btn_Telefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(161)))));
            this.btn_Telefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(118)))), ((int)(((byte)(177)))));
            this.btn_Telefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Telefono.ForeColor = System.Drawing.Color.White;
            this.btn_Telefono.Location = new System.Drawing.Point(950, 43);
            this.btn_Telefono.Name = "btn_Telefono";
            this.btn_Telefono.Size = new System.Drawing.Size(164, 54);
            this.btn_Telefono.TabIndex = 8;
            this.btn_Telefono.UseVisualStyleBackColor = false;
            this.btn_Telefono.Click += new System.EventHandler(this.btn_Telefono_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefono:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(152)))), ((int)(((byte)(66)))));
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(164)))), ((int)(((byte)(71)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(144, 524);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(135, 85);
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btn_Seleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Seleccionar.BackgroundImage")));
            this.btn_Seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Seleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Seleccionar.FlatAppearance.BorderSize = 0;
            this.btn_Seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            this.btn_Seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btn_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Seleccionar.Location = new System.Drawing.Point(9, 524);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(135, 85);
            this.btn_Seleccionar.TabIndex = 13;
            this.btn_Seleccionar.UseVisualStyleBackColor = false;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Identificación:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(137, 23);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(261, 27);
            this.txt_Nombre.TabIndex = 15;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(137, 337);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(261, 27);
            this.txt_Correo.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 6);
            this.panel2.TabIndex = 30;
            // 
            // msk_Telefono
            // 
            this.msk_Telefono.Location = new System.Drawing.Point(137, 370);
            this.msk_Telefono.Mask = "####-####";
            this.msk_Telefono.Name = "msk_Telefono";
            this.msk_Telefono.Size = new System.Drawing.Size(261, 27);
            this.msk_Telefono.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_Clientes);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(419, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 503);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AllowUserToResizeColumns = false;
            this.dgv_Clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Clientes.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Identificacion,
            this.Nombre,
            this.Correo,
            this.Telefono,
            this.Tipo_Identificacion});
            this.dgv_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Clientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Clientes.EnableHeadersVisualStyles = false;
            this.dgv_Clientes.GridColor = System.Drawing.Color.DimGray;
            this.dgv_Clientes.Location = new System.Drawing.Point(3, 22);
            this.dgv_Clientes.MultiSelect = false;
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Clientes.RowHeadersVisible = false;
            this.dgv_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Clientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Clientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Clientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clientes.Size = new System.Drawing.Size(692, 478);
            this.dgv_Clientes.TabIndex = 2;
            this.dgv_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clientes_CellContentClick);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.DataPropertyName = "Id_Cliente";
            this.Id_Cliente.HeaderText = "Id_Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            this.Id_Cliente.Visible = false;
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Tipo_Identificacion
            // 
            this.Tipo_Identificacion.DataPropertyName = "Tipo_Identificacion";
            this.Tipo_Identificacion.HeaderText = "Tipo_Identificacion";
            this.Tipo_Identificacion.Name = "Tipo_Identificacion";
            this.Tipo_Identificacion.ReadOnly = true;
            this.Tipo_Identificacion.Visible = false;
            // 
            // cbo_Identificacion
            // 
            this.cbo_Identificacion.FormattingEnabled = true;
            this.cbo_Identificacion.Items.AddRange(new object[] {
            "Telefono",
            "Fisica",
            "Juridica",
            "NITE",
            "DIMEX"});
            this.cbo_Identificacion.Location = new System.Drawing.Point(10, 56);
            this.cbo_Identificacion.Name = "cbo_Identificacion";
            this.cbo_Identificacion.Size = new System.Drawing.Size(157, 29);
            this.cbo_Identificacion.TabIndex = 31;
            this.cbo_Identificacion.SelectionChangeCommitted += new System.EventHandler(this.cbo_Identificacion_SelectionChangeCommitted);
            this.cbo_Identificacion.SelectedValueChanged += new System.EventHandler(this.cbo_Identificacion_SelectedValueChanged);
            // 
            // grb_DatosCliente
            // 
            this.grb_DatosCliente.Controls.Add(this.label10);
            this.grb_DatosCliente.Controls.Add(this.txt_UbicacionExacta);
            this.grb_DatosCliente.Controls.Add(this.label8);
            this.grb_DatosCliente.Controls.Add(this.cbo_Barrio);
            this.grb_DatosCliente.Controls.Add(this.cbo_Distrito);
            this.grb_DatosCliente.Controls.Add(this.cbo_Canton);
            this.grb_DatosCliente.Controls.Add(this.cbo_Provincia);
            this.grb_DatosCliente.Controls.Add(this.label7);
            this.grb_DatosCliente.Controls.Add(this.label9);
            this.grb_DatosCliente.Controls.Add(this.label11);
            this.grb_DatosCliente.Controls.Add(this.label12);
            this.grb_DatosCliente.Controls.Add(this.msk_Identificacion);
            this.grb_DatosCliente.Controls.Add(this.cbo_Identif);
            this.grb_DatosCliente.Controls.Add(this.lbl_IDCliente);
            this.grb_DatosCliente.Controls.Add(this.txt_Nombre);
            this.grb_DatosCliente.Controls.Add(this.txt_Correo);
            this.grb_DatosCliente.Controls.Add(this.msk_Telefono);
            this.grb_DatosCliente.Controls.Add(this.label5);
            this.grb_DatosCliente.Controls.Add(this.label2);
            this.grb_DatosCliente.Controls.Add(this.label3);
            this.grb_DatosCliente.Controls.Add(this.label4);
            this.grb_DatosCliente.Location = new System.Drawing.Point(12, 112);
            this.grb_DatosCliente.Name = "grb_DatosCliente";
            this.grb_DatosCliente.Size = new System.Drawing.Size(404, 411);
            this.grb_DatosCliente.TabIndex = 32;
            this.grb_DatosCliente.TabStop = false;
            this.grb_DatosCliente.Text = "Datos Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "de Ubicación:";
            // 
            // txt_UbicacionExacta
            // 
            this.txt_UbicacionExacta.Enabled = false;
            this.txt_UbicacionExacta.Location = new System.Drawing.Point(137, 246);
            this.txt_UbicacionExacta.Multiline = true;
            this.txt_UbicacionExacta.Name = "txt_UbicacionExacta";
            this.txt_UbicacionExacta.Size = new System.Drawing.Size(261, 85);
            this.txt_UbicacionExacta.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Descripción";
            // 
            // cbo_Barrio
            // 
            this.cbo_Barrio.Enabled = false;
            this.cbo_Barrio.FormattingEnabled = true;
            this.cbo_Barrio.Location = new System.Drawing.Point(137, 212);
            this.cbo_Barrio.Name = "cbo_Barrio";
            this.cbo_Barrio.Size = new System.Drawing.Size(261, 29);
            this.cbo_Barrio.TabIndex = 31;
            this.cbo_Barrio.SelectionChangeCommitted += new System.EventHandler(this.cbo_Barrio_SelectionChangeCommitted);
            // 
            // cbo_Distrito
            // 
            this.cbo_Distrito.Enabled = false;
            this.cbo_Distrito.FormattingEnabled = true;
            this.cbo_Distrito.Location = new System.Drawing.Point(137, 172);
            this.cbo_Distrito.Name = "cbo_Distrito";
            this.cbo_Distrito.Size = new System.Drawing.Size(261, 29);
            this.cbo_Distrito.TabIndex = 30;
            this.cbo_Distrito.SelectionChangeCommitted += new System.EventHandler(this.cbo_Distrito_SelectionChangeCommitted);
            // 
            // cbo_Canton
            // 
            this.cbo_Canton.Enabled = false;
            this.cbo_Canton.FormattingEnabled = true;
            this.cbo_Canton.Location = new System.Drawing.Point(137, 134);
            this.cbo_Canton.Name = "cbo_Canton";
            this.cbo_Canton.Size = new System.Drawing.Size(261, 29);
            this.cbo_Canton.TabIndex = 29;
            this.cbo_Canton.SelectionChangeCommitted += new System.EventHandler(this.cbo_Canton_SelectionChangeCommitted);
            // 
            // cbo_Provincia
            // 
            this.cbo_Provincia.FormattingEnabled = true;
            this.cbo_Provincia.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbo_Provincia.Location = new System.Drawing.Point(137, 93);
            this.cbo_Provincia.Name = "cbo_Provincia";
            this.cbo_Provincia.Size = new System.Drawing.Size(261, 29);
            this.cbo_Provincia.TabIndex = 28;
            this.cbo_Provincia.SelectionChangeCommitted += new System.EventHandler(this.cbo_Provincia_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Barrio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Distrito:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Canton:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "Provincia:";
            // 
            // msk_Identificacion
            // 
            this.msk_Identificacion.Location = new System.Drawing.Point(264, 59);
            this.msk_Identificacion.Name = "msk_Identificacion";
            this.msk_Identificacion.Size = new System.Drawing.Size(134, 27);
            this.msk_Identificacion.TabIndex = 23;
            // 
            // cbo_Identif
            // 
            this.cbo_Identif.FormattingEnabled = true;
            this.cbo_Identif.Location = new System.Drawing.Point(137, 58);
            this.cbo_Identif.Name = "cbo_Identif";
            this.cbo_Identif.Size = new System.Drawing.Size(121, 29);
            this.cbo_Identif.TabIndex = 22;
            // 
            // lbl_IDCliente
            // 
            this.lbl_IDCliente.AutoSize = true;
            this.lbl_IDCliente.Location = new System.Drawing.Point(91, 26);
            this.lbl_IDCliente.Name = "lbl_IDCliente";
            this.lbl_IDCliente.Size = new System.Drawing.Size(19, 21);
            this.lbl_IDCliente.TabIndex = 21;
            this.lbl_IDCliente.Text = "0";
            this.lbl_IDCliente.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel4.Location = new System.Drawing.Point(3, 621);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1119, 3);
            this.panel4.TabIndex = 22;
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_Refrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.BackgroundImage")));
            this.btn_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Refrescar.FlatAppearance.BorderSize = 0;
            this.btn_Refrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btn_Refrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refrescar.Location = new System.Drawing.Point(279, 524);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(134, 85);
            this.btn_Refrescar.TabIndex = 33;
            this.btn_Refrescar.UseVisualStyleBackColor = false;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel3.Location = new System.Drawing.Point(-7, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 592);
            this.panel3.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel5.Location = new System.Drawing.Point(1119, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 599);
            this.panel5.TabIndex = 35;
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1123, 625);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.grb_DatosCliente);
            this.Controls.Add(this.cbo_Identificacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Telefono);
            this.Controls.Add(this.btn_Identificador);
            this.Controls.Add(this.msk_Consulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frm_Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.grb_DatosCliente.ResumeLayout(false);
            this.grb_DatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox msk_Consulta;
        private System.Windows.Forms.Button btn_Telefono;
        private System.Windows.Forms.Button btn_Identificador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox msk_Telefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.ComboBox cbo_Identificacion;
        private System.Windows.Forms.GroupBox grb_DatosCliente;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Label lbl_IDCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbo_Identif;
        private System.Windows.Forms.MaskedTextBox msk_Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Identificacion;
        public System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_UbicacionExacta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Barrio;
        private System.Windows.Forms.ComboBox cbo_Distrito;
        private System.Windows.Forms.ComboBox cbo_Canton;
        private System.Windows.Forms.ComboBox cbo_Provincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}