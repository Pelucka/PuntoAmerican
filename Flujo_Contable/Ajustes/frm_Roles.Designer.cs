namespace Flujo_Contable.Ajustes
{
    partial class frm_Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Roles));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Rol = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_Admin = new System.Windows.Forms.CheckBox();
            this.chk_IngresosyGastos = new System.Windows.Forms.CheckBox();
            this.chk_Traslados = new System.Windows.Forms.CheckBox();
            this.chk_Ajustes = new System.Windows.Forms.CheckBox();
            this.chk_Usuarios = new System.Windows.Forms.CheckBox();
            this.chk_Caja = new System.Windows.Forms.CheckBox();
            this.chk_Inventario = new System.Windows.Forms.CheckBox();
            this.chk_Control = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Roles = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajustes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresosyGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traslados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Rol);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(407, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // txt_Rol
            // 
            this.txt_Rol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Rol.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Rol.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Rol.HintText = "";
            this.txt_Rol.isPassword = false;
            this.txt_Rol.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Rol.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.txt_Rol.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Rol.LineThickness = 3;
            this.txt_Rol.Location = new System.Drawing.Point(17, 35);
            this.txt_Rol.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rol.Name = "txt_Rol";
            this.txt_Rol.Size = new System.Drawing.Size(382, 31);
            this.txt_Rol.TabIndex = 1;
            this.txt_Rol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_Admin);
            this.groupBox3.Controls.Add(this.chk_IngresosyGastos);
            this.groupBox3.Controls.Add(this.chk_Traslados);
            this.groupBox3.Controls.Add(this.chk_Ajustes);
            this.groupBox3.Controls.Add(this.chk_Usuarios);
            this.groupBox3.Controls.Add(this.chk_Caja);
            this.groupBox3.Controls.Add(this.chk_Inventario);
            this.groupBox3.Controls.Add(this.chk_Control);
            this.groupBox3.Location = new System.Drawing.Point(14, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 264);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permisos";
            // 
            // chk_Admin
            // 
            this.chk_Admin.AutoSize = true;
            this.chk_Admin.Checked = true;
            this.chk_Admin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Admin.Location = new System.Drawing.Point(126, 34);
            this.chk_Admin.Name = "chk_Admin";
            this.chk_Admin.Size = new System.Drawing.Size(135, 24);
            this.chk_Admin.TabIndex = 16;
            this.chk_Admin.Text = "Administración";
            this.chk_Admin.UseVisualStyleBackColor = true;
            // 
            // chk_IngresosyGastos
            // 
            this.chk_IngresosyGastos.AutoSize = true;
            this.chk_IngresosyGastos.Checked = true;
            this.chk_IngresosyGastos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IngresosyGastos.Location = new System.Drawing.Point(126, 142);
            this.chk_IngresosyGastos.Name = "chk_IngresosyGastos";
            this.chk_IngresosyGastos.Size = new System.Drawing.Size(155, 24);
            this.chk_IngresosyGastos.TabIndex = 12;
            this.chk_IngresosyGastos.Text = "Ingresos y Gastos";
            this.chk_IngresosyGastos.UseVisualStyleBackColor = true;
            // 
            // chk_Traslados
            // 
            this.chk_Traslados.AutoSize = true;
            this.chk_Traslados.Checked = true;
            this.chk_Traslados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Traslados.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.chk_Traslados.Location = new System.Drawing.Point(126, 228);
            this.chk_Traslados.Name = "chk_Traslados";
            this.chk_Traslados.Size = new System.Drawing.Size(93, 24);
            this.chk_Traslados.TabIndex = 12;
            this.chk_Traslados.Text = "Traslados";
            this.chk_Traslados.UseVisualStyleBackColor = true;
            // 
            // chk_Ajustes
            // 
            this.chk_Ajustes.AutoSize = true;
            this.chk_Ajustes.Checked = true;
            this.chk_Ajustes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Ajustes.Location = new System.Drawing.Point(126, 58);
            this.chk_Ajustes.Name = "chk_Ajustes";
            this.chk_Ajustes.Size = new System.Drawing.Size(78, 24);
            this.chk_Ajustes.TabIndex = 15;
            this.chk_Ajustes.Text = "Ajustes";
            this.chk_Ajustes.UseVisualStyleBackColor = true;
            // 
            // chk_Usuarios
            // 
            this.chk_Usuarios.AutoSize = true;
            this.chk_Usuarios.Checked = true;
            this.chk_Usuarios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Usuarios.Location = new System.Drawing.Point(126, 198);
            this.chk_Usuarios.Name = "chk_Usuarios";
            this.chk_Usuarios.Size = new System.Drawing.Size(88, 24);
            this.chk_Usuarios.TabIndex = 10;
            this.chk_Usuarios.Text = "Usuarios";
            this.chk_Usuarios.UseVisualStyleBackColor = true;
            // 
            // chk_Caja
            // 
            this.chk_Caja.AutoSize = true;
            this.chk_Caja.Checked = true;
            this.chk_Caja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Caja.Location = new System.Drawing.Point(126, 86);
            this.chk_Caja.Name = "chk_Caja";
            this.chk_Caja.Size = new System.Drawing.Size(63, 24);
            this.chk_Caja.TabIndex = 14;
            this.chk_Caja.Text = "Caja";
            this.chk_Caja.UseVisualStyleBackColor = true;
            // 
            // chk_Inventario
            // 
            this.chk_Inventario.AutoSize = true;
            this.chk_Inventario.Checked = true;
            this.chk_Inventario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Inventario.Location = new System.Drawing.Point(126, 170);
            this.chk_Inventario.Name = "chk_Inventario";
            this.chk_Inventario.Size = new System.Drawing.Size(104, 24);
            this.chk_Inventario.TabIndex = 11;
            this.chk_Inventario.Text = "Inventario";
            this.chk_Inventario.UseVisualStyleBackColor = true;
            // 
            // chk_Control
            // 
            this.chk_Control.AutoSize = true;
            this.chk_Control.Checked = true;
            this.chk_Control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Control.Location = new System.Drawing.Point(126, 114);
            this.chk_Control.Name = "chk_Control";
            this.chk_Control.Size = new System.Drawing.Size(82, 24);
            this.chk_Control.TabIndex = 13;
            this.chk_Control.Text = "Control";
            this.chk_Control.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Roles);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(424, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 451);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Roles";
            // 
            // dgv_Roles
            // 
            this.dgv_Roles.AllowUserToAddRows = false;
            this.dgv_Roles.AllowUserToDeleteRows = false;
            this.dgv_Roles.AllowUserToResizeColumns = false;
            this.dgv_Roles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Roles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Roles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Roles.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Roles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Roles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Roles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Roles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Administracion,
            this.Ajustes,
            this.Caja,
            this.Control,
            this.IngresosyGastos,
            this.Inventario,
            this.Usuarios,
            this.Traslados});
            this.dgv_Roles.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Roles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Roles.EnableHeadersVisualStyles = false;
            this.dgv_Roles.GridColor = System.Drawing.Color.Gray;
            this.dgv_Roles.Location = new System.Drawing.Point(3, 22);
            this.dgv_Roles.MultiSelect = false;
            this.dgv_Roles.Name = "dgv_Roles";
            this.dgv_Roles.ReadOnly = true;
            this.dgv_Roles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Roles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Roles.RowHeadersVisible = false;
            this.dgv_Roles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Roles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Roles.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Roles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Roles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Roles.Size = new System.Drawing.Size(299, 426);
            this.dgv_Roles.TabIndex = 2;
            this.dgv_Roles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Consecutivos_CellContentClick);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Administracion
            // 
            this.Administracion.DataPropertyName = "Administracion";
            this.Administracion.HeaderText = "Administracion";
            this.Administracion.Name = "Administracion";
            this.Administracion.ReadOnly = true;
            this.Administracion.Visible = false;
            this.Administracion.Width = 141;
            // 
            // Ajustes
            // 
            this.Ajustes.DataPropertyName = "Ajustes";
            this.Ajustes.HeaderText = "Ajustes";
            this.Ajustes.Name = "Ajustes";
            this.Ajustes.ReadOnly = true;
            this.Ajustes.Visible = false;
            this.Ajustes.Width = 84;
            // 
            // Caja
            // 
            this.Caja.DataPropertyName = "Caja";
            this.Caja.HeaderText = "Caja";
            this.Caja.Name = "Caja";
            this.Caja.ReadOnly = true;
            this.Caja.Visible = false;
            this.Caja.Width = 69;
            // 
            // Control
            // 
            this.Control.DataPropertyName = "Control";
            this.Control.HeaderText = "Control";
            this.Control.Name = "Control";
            this.Control.ReadOnly = true;
            this.Control.Visible = false;
            this.Control.Width = 88;
            // 
            // IngresosyGastos
            // 
            this.IngresosyGastos.DataPropertyName = "IngresosyGastos";
            this.IngresosyGastos.HeaderText = "IngresosyGastos";
            this.IngresosyGastos.Name = "IngresosyGastos";
            this.IngresosyGastos.ReadOnly = true;
            this.IngresosyGastos.Visible = false;
            this.IngresosyGastos.Width = 153;
            // 
            // Inventario
            // 
            this.Inventario.DataPropertyName = "Inventario";
            this.Inventario.HeaderText = "Inventario";
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            this.Inventario.Visible = false;
            this.Inventario.Width = 110;
            // 
            // Usuarios
            // 
            this.Usuarios.DataPropertyName = "Usuarios";
            this.Usuarios.HeaderText = "Usuarios";
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            this.Usuarios.Visible = false;
            this.Usuarios.Width = 94;
            // 
            // Traslados
            // 
            this.Traslados.DataPropertyName = "Traslados";
            this.Traslados.HeaderText = "Traslados";
            this.Traslados.Name = "Traslados";
            this.Traslados.ReadOnly = true;
            this.Traslados.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Traslados.Visible = false;
            this.Traslados.Width = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 40);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Roles";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(708, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 11;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(152)))), ((int)(((byte)(66)))));
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(164)))), ((int)(((byte)(71)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(12, 410);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(314, 85);
            this.btn_Agregar.TabIndex = 13;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btn_Refrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.BackgroundImage")));
            this.btn_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Refrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btn_Refrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(178)))));
            this.btn_Refrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refrescar.Location = new System.Drawing.Point(326, 410);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(94, 85);
            this.btn_Refrescar.TabIndex = 15;
            this.btn_Refrescar.UseVisualStyleBackColor = false;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // frm_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.frm_Roles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Roles;
        private System.Windows.Forms.CheckBox chk_Ajustes;
        private System.Windows.Forms.CheckBox chk_Caja;
        private System.Windows.Forms.CheckBox chk_Control;
        private System.Windows.Forms.CheckBox chk_IngresosyGastos;
        private System.Windows.Forms.CheckBox chk_Inventario;
        private System.Windows.Forms.CheckBox chk_Usuarios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_Admin;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Rol;
        private System.Windows.Forms.CheckBox chk_Traslados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ajustes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresosyGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traslados;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}