namespace Flujo_Contable.Ajustes
{
    partial class frm_Ubicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ubicaciones));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Ubicaciones = new System.Windows.Forms.DataGridView();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_dueño = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msk_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UbicacionExacta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Barrio = new System.Windows.Forms.ComboBox();
            this.cbo_Distrito = new System.Windows.Forms.ComboBox();
            this.cbo_Canton = new System.Windows.Forms.ComboBox();
            this.cbo_Provincia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Prefijo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ubicaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Ubicaciones);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(382, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 560);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Ubicaciones";
            // 
            // dgv_Ubicaciones
            // 
            this.dgv_Ubicaciones.AllowUserToAddRows = false;
            this.dgv_Ubicaciones.AllowUserToDeleteRows = false;
            this.dgv_Ubicaciones.AllowUserToResizeColumns = false;
            this.dgv_Ubicaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Ubicaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Ubicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ubicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Ubicaciones.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Ubicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Ubicaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Ubicaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ubicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Ubicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Ubicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sucursal,
            this.Prefijo,
            this.Secuencia});
            this.dgv_Ubicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ubicaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Ubicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Ubicaciones.EnableHeadersVisualStyles = false;
            this.dgv_Ubicaciones.GridColor = System.Drawing.Color.DimGray;
            this.dgv_Ubicaciones.Location = new System.Drawing.Point(3, 22);
            this.dgv_Ubicaciones.MultiSelect = false;
            this.dgv_Ubicaciones.Name = "dgv_Ubicaciones";
            this.dgv_Ubicaciones.ReadOnly = true;
            this.dgv_Ubicaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ubicaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Ubicaciones.RowHeadersVisible = false;
            this.dgv_Ubicaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Ubicaciones.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Ubicaciones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Ubicaciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Ubicaciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Ubicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ubicaciones.Size = new System.Drawing.Size(402, 535);
            this.dgv_Ubicaciones.TabIndex = 2;
            this.dgv_Ubicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ubicaciones_CellContentClick);
            this.dgv_Ubicaciones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ubicaciones_CellEndEdit);
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sucursal.DataPropertyName = "Descripcion";
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // Prefijo
            // 
            this.Prefijo.DataPropertyName = "Prefijo";
            this.Prefijo.HeaderText = "Prefijo";
            this.Prefijo.Name = "Prefijo";
            this.Prefijo.ReadOnly = true;
            // 
            // Secuencia
            // 
            this.Secuencia.DataPropertyName = "Secuencia";
            this.Secuencia.HeaderText = "Secuencia";
            this.Secuencia.Name = "Secuencia";
            this.Secuencia.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_dueño);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.msk_Telefono);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_UbicacionExacta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_Barrio);
            this.groupBox1.Controls.Add(this.cbo_Distrito);
            this.groupBox1.Controls.Add(this.cbo_Canton);
            this.groupBox1.Controls.Add(this.cbo_Provincia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Prefijo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 468);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicación";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbo_dueño
            // 
            this.cbo_dueño.FormattingEnabled = true;
            this.cbo_dueño.Location = new System.Drawing.Point(138, 415);
            this.cbo_dueño.Name = "cbo_dueño";
            this.cbo_dueño.Size = new System.Drawing.Size(220, 28);
            this.cbo_dueño.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Dueño:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "de Ubicación:";
            // 
            // msk_Telefono
            // 
            this.msk_Telefono.Location = new System.Drawing.Point(138, 362);
            this.msk_Telefono.Mask = "####-####";
            this.msk_Telefono.Name = "msk_Telefono";
            this.msk_Telefono.Size = new System.Drawing.Size(220, 26);
            this.msk_Telefono.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefono:";
            // 
            // txt_UbicacionExacta
            // 
            this.txt_UbicacionExacta.Enabled = false;
            this.txt_UbicacionExacta.Location = new System.Drawing.Point(138, 268);
            this.txt_UbicacionExacta.Multiline = true;
            this.txt_UbicacionExacta.Name = "txt_UbicacionExacta";
            this.txt_UbicacionExacta.Size = new System.Drawing.Size(220, 85);
            this.txt_UbicacionExacta.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descripción";
            // 
            // cbo_Barrio
            // 
            this.cbo_Barrio.Enabled = false;
            this.cbo_Barrio.FormattingEnabled = true;
            this.cbo_Barrio.Location = new System.Drawing.Point(138, 234);
            this.cbo_Barrio.Name = "cbo_Barrio";
            this.cbo_Barrio.Size = new System.Drawing.Size(220, 28);
            this.cbo_Barrio.TabIndex = 13;
            this.cbo_Barrio.SelectionChangeCommitted += new System.EventHandler(this.cbo_Barrio_SelectionChangeCommitted);
            // 
            // cbo_Distrito
            // 
            this.cbo_Distrito.Enabled = false;
            this.cbo_Distrito.FormattingEnabled = true;
            this.cbo_Distrito.Location = new System.Drawing.Point(138, 194);
            this.cbo_Distrito.Name = "cbo_Distrito";
            this.cbo_Distrito.Size = new System.Drawing.Size(220, 28);
            this.cbo_Distrito.TabIndex = 12;
            this.cbo_Distrito.SelectionChangeCommitted += new System.EventHandler(this.cbo_Distrito_SelectionChangeCommitted);
            // 
            // cbo_Canton
            // 
            this.cbo_Canton.Enabled = false;
            this.cbo_Canton.FormattingEnabled = true;
            this.cbo_Canton.Location = new System.Drawing.Point(138, 156);
            this.cbo_Canton.Name = "cbo_Canton";
            this.cbo_Canton.Size = new System.Drawing.Size(220, 28);
            this.cbo_Canton.TabIndex = 11;
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
            this.cbo_Provincia.Location = new System.Drawing.Point(138, 115);
            this.cbo_Provincia.Name = "cbo_Provincia";
            this.cbo_Provincia.Size = new System.Drawing.Size(220, 28);
            this.cbo_Provincia.TabIndex = 10;
            this.cbo_Provincia.SelectedIndexChanged += new System.EventHandler(this.cbo_Provincia_SelectedIndexChanged);
            this.cbo_Provincia.SelectionChangeCommitted += new System.EventHandler(this.cbo_Provincia_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Barrio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Distrito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Canton:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Provincia:";
            // 
            // txt_Prefijo
            // 
            this.txt_Prefijo.Location = new System.Drawing.Point(138, 75);
            this.txt_Prefijo.Name = "txt_Prefijo";
            this.txt_Prefijo.Size = new System.Drawing.Size(220, 26);
            this.txt_Prefijo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prefijo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sucursal:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(138, 28);
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(220, 27);
            this.txt_Nombre.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 40);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(8, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ubicaciones";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(768, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
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
            this.btn_Agregar.Location = new System.Drawing.Point(13, 527);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(365, 85);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // frm_Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 634);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Ubicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicaciones";
            this.Load += new System.EventHandler(this.frm_Ubicaciones_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ubicaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Ubicaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Prefijo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secuencia;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cbo_Barrio;
        private System.Windows.Forms.ComboBox cbo_Distrito;
        private System.Windows.Forms.ComboBox cbo_Canton;
        private System.Windows.Forms.ComboBox cbo_Provincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_UbicacionExacta;
        private System.Windows.Forms.MaskedTextBox msk_Telefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_dueño;
    }
}