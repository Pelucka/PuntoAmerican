namespace Flujo_Contable.Ajustes
{
    partial class frm_Formulario_Entrega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Formulario_Entrega));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Entregas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id_Envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Distribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula_Distribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa_Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Hora_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Hora_Llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion_Llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Sacos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sacos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Sucursal = new System.Windows.Forms.Label();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.btn_Aceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entregas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Entregas);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(721, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entregas";
            // 
            // dgv_Entregas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Entregas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Entregas.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Entregas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Entregas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Entregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Envio,
            this.Usuario,
            this.Nombre_Distribuidor,
            this.Cedula_Distribuidor,
            this.Placa_Vehiculo,
            this.Fecha_Hora_Salida,
            this.Fecha_Hora_Llegada,
            this.Ubicacion_Salida,
            this.Ubicacion_Llegada,
            this.Cantidad_Sacos,
            this.Sacos,
            this.Descripcion_Envio,
            this.Estado_Envio});
            this.dgv_Entregas.DoubleBuffered = true;
            this.dgv_Entregas.EnableHeadersVisualStyles = false;
            this.dgv_Entregas.GridColor = System.Drawing.Color.Gray;
            this.dgv_Entregas.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dgv_Entregas.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Entregas.Location = new System.Drawing.Point(5, 27);
            this.dgv_Entregas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Entregas.Name = "dgv_Entregas";
            this.dgv_Entregas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Entregas.RowTemplate.Height = 24;
            this.dgv_Entregas.Size = new System.Drawing.Size(709, 341);
            this.dgv_Entregas.TabIndex = 0;
            // 
            // Id_Envio
            // 
            this.Id_Envio.DataPropertyName = "Id_Envio";
            this.Id_Envio.HeaderText = "Id_Envio";
            this.Id_Envio.Name = "Id_Envio";
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Nombre_Distribuidor
            // 
            this.Nombre_Distribuidor.DataPropertyName = "Nombre_Distribuidor";
            this.Nombre_Distribuidor.HeaderText = "Nombre_Distribuidor";
            this.Nombre_Distribuidor.Name = "Nombre_Distribuidor";
            // 
            // Cedula_Distribuidor
            // 
            this.Cedula_Distribuidor.DataPropertyName = "Cedula_Distribuidor";
            this.Cedula_Distribuidor.HeaderText = "Cedula_Distribuidor";
            this.Cedula_Distribuidor.Name = "Cedula_Distribuidor";
            // 
            // Placa_Vehiculo
            // 
            this.Placa_Vehiculo.DataPropertyName = "Placa_Vehiculo";
            this.Placa_Vehiculo.HeaderText = "Placa_Vehiculo";
            this.Placa_Vehiculo.Name = "Placa_Vehiculo";
            // 
            // Fecha_Hora_Salida
            // 
            this.Fecha_Hora_Salida.DataPropertyName = "Fecha_Hora_Salida";
            this.Fecha_Hora_Salida.HeaderText = "Fecha_Hora_Salida";
            this.Fecha_Hora_Salida.Name = "Fecha_Hora_Salida";
            // 
            // Fecha_Hora_Llegada
            // 
            this.Fecha_Hora_Llegada.DataPropertyName = "Fecha_Hora_Llegada";
            this.Fecha_Hora_Llegada.HeaderText = "Fecha_Hora_Llegada";
            this.Fecha_Hora_Llegada.Name = "Fecha_Hora_Llegada";
            // 
            // Ubicacion_Salida
            // 
            this.Ubicacion_Salida.DataPropertyName = "Ubicacion_Salida";
            this.Ubicacion_Salida.HeaderText = "Ubicacion_Salida";
            this.Ubicacion_Salida.Name = "Ubicacion_Salida";
            // 
            // Ubicacion_Llegada
            // 
            this.Ubicacion_Llegada.DataPropertyName = "Ubicacion_Llegada";
            this.Ubicacion_Llegada.HeaderText = "Ubicacion_Llegada";
            this.Ubicacion_Llegada.Name = "Ubicacion_Llegada";
            // 
            // Cantidad_Sacos
            // 
            this.Cantidad_Sacos.DataPropertyName = "Cantidad_Sacos";
            this.Cantidad_Sacos.HeaderText = "Cantidad_Sacos";
            this.Cantidad_Sacos.Name = "Cantidad_Sacos";
            // 
            // Sacos
            // 
            this.Sacos.DataPropertyName = "Sacos";
            this.Sacos.HeaderText = "Sacos";
            this.Sacos.Name = "Sacos";
            // 
            // Descripcion_Envio
            // 
            this.Descripcion_Envio.DataPropertyName = "Descripcion_Envio";
            this.Descripcion_Envio.HeaderText = "Descripcion_Envio";
            this.Descripcion_Envio.Name = "Descripcion_Envio";
            // 
            // Estado_Envio
            // 
            this.Estado_Envio.DataPropertyName = "Estado_Envio";
            this.Estado_Envio.HeaderText = "Estado_Envio";
            this.Estado_Envio.Name = "Estado_Envio";
            // 
            // lb_Sucursal
            // 
            this.lb_Sucursal.AutoSize = true;
            this.lb_Sucursal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sucursal.Location = new System.Drawing.Point(536, 490);
            this.lb_Sucursal.Name = "lb_Sucursal";
            this.lb_Sucursal.Size = new System.Drawing.Size(65, 19);
            this.lb_Sucursal.TabIndex = 3;
            this.lb_Sucursal.Text = "Sucursal";
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Usuario.Location = new System.Drawing.Point(657, 490);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(58, 19);
            this.lb_Usuario.TabIndex = 4;
            this.lb_Usuario.Text = "Usuario";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Aceptar.BackColor = System.Drawing.Color.White;
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.BorderRadius = 0;
            this.btn_Aceptar.ButtonText = "Aceptar";
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Aceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.Iconimage")));
            this.btn_Aceptar.Iconimage_right = null;
            this.btn_Aceptar.Iconimage_right_Selected = null;
            this.btn_Aceptar.Iconimage_Selected = null;
            this.btn_Aceptar.IconMarginLeft = 0;
            this.btn_Aceptar.IconMarginRight = 0;
            this.btn_Aceptar.IconRightVisible = true;
            this.btn_Aceptar.IconRightZoom = 0D;
            this.btn_Aceptar.IconVisible = true;
            this.btn_Aceptar.IconZoom = 50D;
            this.btn_Aceptar.IsTab = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(25, 455);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Normalcolor = System.Drawing.Color.White;
            this.btn_Aceptar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Aceptar.selected = false;
            this.btn_Aceptar.Size = new System.Drawing.Size(184, 44);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Aceptar.Textcolor = System.Drawing.Color.Black;
            this.btn_Aceptar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.BorderRadius = 0;
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Iconimage")));
            this.btn_Cancelar.Iconimage_right = null;
            this.btn_Cancelar.Iconimage_right_Selected = null;
            this.btn_Cancelar.Iconimage_Selected = null;
            this.btn_Cancelar.IconMarginLeft = 0;
            this.btn_Cancelar.IconMarginRight = 0;
            this.btn_Cancelar.IconRightVisible = true;
            this.btn_Cancelar.IconRightZoom = 0D;
            this.btn_Cancelar.IconVisible = true;
            this.btn_Cancelar.IconZoom = 50D;
            this.btn_Cancelar.IsTab = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(235, 455);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Normalcolor = System.Drawing.Color.White;
            this.btn_Cancelar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cancelar.selected = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(180, 44);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Textcolor = System.Drawing.Color.Black;
            this.btn_Cancelar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 49);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Entregas";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(697, 5);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 41);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Formulario_Entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.lb_Sucursal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Formulario_Entrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Formulario_Entrega";
            this.Load += new System.EventHandler(this.frm_Formulario_Entrega_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entregas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lb_Sucursal;
        public System.Windows.Forms.Label lb_Usuario;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Entregas;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Aceptar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Distribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula_Distribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa_Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Hora_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Hora_Llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion_Llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Sacos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sacos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Envio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
    }
}