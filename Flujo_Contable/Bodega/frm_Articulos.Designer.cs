namespace Flujo_Contable.Bodega
{
    partial class frm_Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Articulos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.btn_Articulo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.Cod_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_CodArticulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Medida = new System.Windows.Forms.ComboBox();
            this.chk_Estado = new System.Windows.Forms.CheckBox();
            this.cbo_Impuesto = new System.Windows.Forms.ComboBox();
            this.cbo_Departamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 38);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(1065, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(24, 24);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Close.TabIndex = 22;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Impuesto:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(118, 61);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(339, 27);
            this.txt_Descripcion.TabIndex = 5;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(118, 145);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(339, 27);
            this.txt_Precio.TabIndex = 6;
            this.txt_Precio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Articulo
            // 
            this.btn_Articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_Articulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Articulo.BackgroundImage")));
            this.btn_Articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Articulo.FlatAppearance.BorderSize = 0;
            this.btn_Articulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(152)))), ((int)(((byte)(66)))));
            this.btn_Articulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(164)))), ((int)(((byte)(71)))));
            this.btn_Articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Articulo.Location = new System.Drawing.Point(6, 326);
            this.btn_Articulo.Name = "btn_Articulo";
            this.btn_Articulo.Size = new System.Drawing.Size(357, 85);
            this.btn_Articulo.TabIndex = 8;
            this.btn_Articulo.UseVisualStyleBackColor = false;
            this.btn_Articulo.Click += new System.EventHandler(this.btn_Articulo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Articulos);
            this.groupBox1.Location = new System.Drawing.Point(463, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 369);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Artículos";
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.AllowUserToAddRows = false;
            this.dgv_Articulos.AllowUserToDeleteRows = false;
            this.dgv_Articulos.AllowUserToResizeColumns = false;
            this.dgv_Articulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Articulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Articulos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Articulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Articulo,
            this.Medida,
            this.Descripcion,
            this.Precio,
            this.Impuesto,
            this.Activo});
            this.dgv_Articulos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Articulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Articulos.EnableHeadersVisualStyles = false;
            this.dgv_Articulos.GridColor = System.Drawing.Color.DimGray;
            this.dgv_Articulos.Location = new System.Drawing.Point(3, 23);
            this.dgv_Articulos.MultiSelect = false;
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Articulos.RowHeadersVisible = false;
            this.dgv_Articulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Articulos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Articulos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Articulos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.dgv_Articulos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Articulos.Size = new System.Drawing.Size(621, 343);
            this.dgv_Articulos.TabIndex = 16;
            this.dgv_Articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Consecutivos_CellContentClick);
            // 
            // Cod_Articulo
            // 
            this.Cod_Articulo.DataPropertyName = "Cod_Articulo";
            this.Cod_Articulo.HeaderText = "Id_Articulo";
            this.Cod_Articulo.Name = "Cod_Articulo";
            this.Cod_Articulo.Visible = false;
            // 
            // Medida
            // 
            this.Medida.DataPropertyName = "Unidad_Medida";
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Impuesto
            // 
            this.Impuesto.DataPropertyName = "Impuesto";
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Habilitar";
            this.Activo.Name = "Activo";
            this.Activo.Visible = false;
            // 
            // lbl_CodArticulo
            // 
            this.lbl_CodArticulo.AutoSize = true;
            this.lbl_CodArticulo.Location = new System.Drawing.Point(12, 286);
            this.lbl_CodArticulo.Name = "lbl_CodArticulo";
            this.lbl_CodArticulo.Size = new System.Drawing.Size(113, 21);
            this.lbl_CodArticulo.TabIndex = 10;
            this.lbl_CodArticulo.Text = "Cod_Articulo";
            this.lbl_CodArticulo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Medida:";
            // 
            // cbo_Medida
            // 
            this.cbo_Medida.FormattingEnabled = true;
            this.cbo_Medida.Items.AddRange(new object[] {
            "Unid",
            "kg",
            "t"});
            this.cbo_Medida.Location = new System.Drawing.Point(118, 101);
            this.cbo_Medida.Name = "cbo_Medida";
            this.cbo_Medida.Size = new System.Drawing.Size(339, 29);
            this.cbo_Medida.TabIndex = 12;
            // 
            // chk_Estado
            // 
            this.chk_Estado.AutoSize = true;
            this.chk_Estado.Enabled = false;
            this.chk_Estado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Estado.Location = new System.Drawing.Point(171, 282);
            this.chk_Estado.Name = "chk_Estado";
            this.chk_Estado.Size = new System.Drawing.Size(115, 29);
            this.chk_Estado.TabIndex = 15;
            this.chk_Estado.Text = "Habilitar";
            this.chk_Estado.UseVisualStyleBackColor = true;
            // 
            // cbo_Impuesto
            // 
            this.cbo_Impuesto.FormattingEnabled = true;
            this.cbo_Impuesto.Location = new System.Drawing.Point(118, 187);
            this.cbo_Impuesto.Name = "cbo_Impuesto";
            this.cbo_Impuesto.Size = new System.Drawing.Size(339, 29);
            this.cbo_Impuesto.TabIndex = 16;
            this.cbo_Impuesto.SelectedIndexChanged += new System.EventHandler(this.cbo_Impuesto_SelectedIndexChanged);
            // 
            // cbo_Departamento
            // 
            this.cbo_Departamento.FormattingEnabled = true;
            this.cbo_Departamento.Location = new System.Drawing.Point(151, 234);
            this.cbo_Departamento.Name = "cbo_Departamento";
            this.cbo_Departamento.Size = new System.Drawing.Size(306, 29);
            this.cbo_Departamento.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Departamento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btn_refrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.BackgroundImage")));
            this.btn_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refrescar.FlatAppearance.BorderSize = 0;
            this.btn_refrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            this.btn_refrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Location = new System.Drawing.Point(363, 326);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(94, 85);
            this.btn_refrescar.TabIndex = 19;
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // frm_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1097, 420);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.cbo_Departamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_Impuesto);
            this.Controls.Add(this.chk_Estado);
            this.Controls.Add(this.cbo_Medida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_CodArticulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Articulo);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Articulos";
            this.Load += new System.EventHandler(this.frm_Articulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_Articulo;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.Label lbl_CodArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Medida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.ComboBox cbo_Impuesto;
        private System.Windows.Forms.ComboBox cbo_Departamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_refrescar;
    }
}