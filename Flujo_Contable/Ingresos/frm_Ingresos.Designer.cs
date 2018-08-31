namespace Flujo_Contable
{
    partial class frm_Ingresos_Mes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ingresos_Mes));
            this.lbl_AnoHoy = new System.Windows.Forms.Label();
            this.cha_Gastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cha_Ganancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cha_Ingresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbo_Mes = new System.Windows.Forms.ComboBox();
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.rb_Mes = new System.Windows.Forms.RadioButton();
            this.rb_Ano = new System.Windows.Forms.RadioButton();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.txt_Año = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Ubicacion = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmr_Timer = new System.Windows.Forms.Timer(this.components);
            this.btn_InicioCaja = new System.Windows.Forms.Button();
            this.btn_Apartados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ganancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ingresos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AnoHoy
            // 
            this.lbl_AnoHoy.AutoSize = true;
            this.lbl_AnoHoy.Location = new System.Drawing.Point(940, 292);
            this.lbl_AnoHoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AnoHoy.Name = "lbl_AnoHoy";
            this.lbl_AnoHoy.Size = new System.Drawing.Size(0, 18);
            this.lbl_AnoHoy.TabIndex = 0;
            this.lbl_AnoHoy.Visible = false;
            // 
            // cha_Gastos
            // 
            this.cha_Gastos.BackColor = System.Drawing.Color.Transparent;
            this.cha_Gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cha_Gastos.BorderlineColor = System.Drawing.Color.Transparent;
            this.cha_Gastos.BorderlineWidth = 0;
            chartArea10.Name = "ChartArea1";
            this.cha_Gastos.ChartAreas.Add(chartArea10);
            this.cha_Gastos.Cursor = System.Windows.Forms.Cursors.Hand;
            legend10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend10.IsTextAutoFit = false;
            legend10.Name = "Legend1";
            this.cha_Gastos.Legends.Add(legend10);
            this.cha_Gastos.Location = new System.Drawing.Point(526, 57);
            this.cha_Gastos.Margin = new System.Windows.Forms.Padding(4);
            this.cha_Gastos.Name = "cha_Gastos";
            this.cha_Gastos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.cha_Gastos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(102)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(85))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))))};
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.Legend = "Legend1";
            series10.Name = "Gastos";
            this.cha_Gastos.Series.Add(series10);
            this.cha_Gastos.Size = new System.Drawing.Size(452, 284);
            this.cha_Gastos.TabIndex = 17;
            this.cha_Gastos.Text = "Gastos de la Empresa";
            title10.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.Name = "Gastos de la Empresa";
            title10.Text = "Gastos";
            this.cha_Gastos.Titles.Add(title10);
            this.cha_Gastos.Click += new System.EventHandler(this.cha_Gastos_Click);
            // 
            // cha_Ganancia
            // 
            this.cha_Ganancia.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.cha_Ganancia.ChartAreas.Add(chartArea11);
            legend11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend11.IsTextAutoFit = false;
            legend11.Name = "Legend1";
            this.cha_Ganancia.Legends.Add(legend11);
            this.cha_Ganancia.Location = new System.Drawing.Point(430, 349);
            this.cha_Ganancia.Margin = new System.Windows.Forms.Padding(4);
            this.cha_Ganancia.Name = "cha_Ganancia";
            this.cha_Ganancia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.cha_Ganancia.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(102)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(85))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))))};
            series11.ChartArea = "ChartArea1";
            series11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.IsValueShownAsLabel = true;
            series11.Legend = "Legend1";
            series11.Name = "Ganancias";
            series11.YValuesPerPoint = 2;
            this.cha_Ganancia.Series.Add(series11);
            this.cha_Ganancia.Size = new System.Drawing.Size(555, 289);
            this.cha_Ganancia.TabIndex = 18;
            this.cha_Ganancia.Text = "Ganancia Total de la Empresa";
            title11.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.Name = "Ganancia Total";
            title11.Text = "Ganancias";
            this.cha_Ganancia.Titles.Add(title11);
            // 
            // cha_Ingresos
            // 
            this.cha_Ingresos.BackColor = System.Drawing.Color.Transparent;
            this.cha_Ingresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cha_Ingresos.BorderlineColor = System.Drawing.Color.Transparent;
            this.cha_Ingresos.BorderlineWidth = 0;
            this.cha_Ingresos.BorderSkin.BorderWidth = 0;
            chartArea12.Name = "ChartArea1";
            this.cha_Ingresos.ChartAreas.Add(chartArea12);
            this.cha_Ingresos.Cursor = System.Windows.Forms.Cursors.Hand;
            legend12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend12.IsTextAutoFit = false;
            legend12.Name = "Legend1";
            this.cha_Ingresos.Legends.Add(legend12);
            this.cha_Ingresos.Location = new System.Drawing.Point(13, 57);
            this.cha_Ingresos.Margin = new System.Windows.Forms.Padding(4);
            this.cha_Ingresos.Name = "cha_Ingresos";
            this.cha_Ingresos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.cha_Ingresos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(102)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(85))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))))};
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.Color = System.Drawing.Color.White;
            series12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series12.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series12.LabelBorderWidth = 0;
            series12.Legend = "Legend1";
            series12.MarkerSize = 7;
            series12.Name = "Ingresos";
            this.cha_Ingresos.Series.Add(series12);
            this.cha_Ingresos.Size = new System.Drawing.Size(452, 284);
            this.cha_Ingresos.TabIndex = 19;
            this.cha_Ingresos.Text = "Gastos de la Empresa";
            title12.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title12.Name = "Ingresos de la Empresa";
            title12.Text = "Ingresos";
            this.cha_Ingresos.Titles.Add(title12);
            this.cha_Ingresos.Click += new System.EventHandler(this.cha_Ingresos_Click);
            // 
            // cbo_Mes
            // 
            this.cbo_Mes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Mes.FormattingEnabled = true;
            this.cbo_Mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbo_Mes.Location = new System.Drawing.Point(130, 461);
            this.cbo_Mes.Name = "cbo_Mes";
            this.cbo_Mes.Size = new System.Drawing.Size(189, 28);
            this.cbo_Mes.TabIndex = 22;
            this.cbo_Mes.Visible = false;
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.AutoSize = true;
            this.lbl_Mes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mes.Location = new System.Drawing.Point(42, 467);
            this.lbl_Mes.Name = "lbl_Mes";
            this.lbl_Mes.Size = new System.Drawing.Size(44, 20);
            this.lbl_Mes.TabIndex = 23;
            this.lbl_Mes.Text = "Mes:";
            this.lbl_Mes.Visible = false;
            // 
            // rb_Mes
            // 
            this.rb_Mes.AutoSize = true;
            this.rb_Mes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Mes.Location = new System.Drawing.Point(132, 407);
            this.rb_Mes.Name = "rb_Mes";
            this.rb_Mes.Size = new System.Drawing.Size(58, 24);
            this.rb_Mes.TabIndex = 24;
            this.rb_Mes.TabStop = true;
            this.rb_Mes.Text = "Mes";
            this.rb_Mes.UseVisualStyleBackColor = true;
            this.rb_Mes.Visible = false;
            this.rb_Mes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Ano
            // 
            this.rb_Ano.AutoSize = true;
            this.rb_Ano.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Ano.Location = new System.Drawing.Point(246, 407);
            this.rb_Ano.Name = "rb_Ano";
            this.rb_Ano.Size = new System.Drawing.Size(57, 24);
            this.rb_Ano.TabIndex = 25;
            this.rb_Ano.TabStop = true;
            this.rb_Ano.Text = "Año";
            this.rb_Ano.UseVisualStyleBackColor = true;
            this.rb_Ano.Visible = false;
            this.rb_Ano.CheckedChanged += new System.EventHandler(this.rb_Ano_CheckedChanged);
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ano.Location = new System.Drawing.Point(43, 517);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(43, 20);
            this.lbl_Ano.TabIndex = 26;
            this.lbl_Ano.Text = "Año:";
            this.lbl_Ano.Visible = false;
            // 
            // txt_Año
            // 
            this.txt_Año.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Año.Location = new System.Drawing.Point(130, 513);
            this.txt_Año.Multiline = true;
            this.txt_Año.Name = "txt_Año";
            this.txt_Año.Size = new System.Drawing.Size(189, 26);
            this.txt_Año.TabIndex = 27;
            this.txt_Año.Visible = false;
            this.txt_Año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Año_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ubicación:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbo_Ubicacion
            // 
            this.cbo_Ubicacion.FormattingEnabled = true;
            this.cbo_Ubicacion.Location = new System.Drawing.Point(209, 240);
            this.cbo_Ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Ubicacion.Name = "cbo_Ubicacion";
            this.cbo_Ubicacion.Size = new System.Drawing.Size(212, 26);
            this.cbo_Ubicacion.TabIndex = 20;
            this.cbo_Ubicacion.Visible = false;
            this.cbo_Ubicacion.SelectedIndexChanged += new System.EventHandler(this.cbo_Ubicacion_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 40);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ingresos y Gastos";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(1002, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_InicioCaja
            // 
            this.btn_InicioCaja.BackColor = System.Drawing.Color.Transparent;
            this.btn_InicioCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InicioCaja.BackgroundImage")));
            this.btn_InicioCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_InicioCaja.FlatAppearance.BorderSize = 0;
            this.btn_InicioCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btn_InicioCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btn_InicioCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InicioCaja.Location = new System.Drawing.Point(6, 553);
            this.btn_InicioCaja.Name = "btn_InicioCaja";
            this.btn_InicioCaja.Size = new System.Drawing.Size(216, 85);
            this.btn_InicioCaja.TabIndex = 42;
            this.btn_InicioCaja.UseVisualStyleBackColor = false;
            this.btn_InicioCaja.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Apartados
            // 
            this.btn_Apartados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btn_Apartados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Apartados.BackgroundImage")));
            this.btn_Apartados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Apartados.FlatAppearance.BorderSize = 0;
            this.btn_Apartados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            this.btn_Apartados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btn_Apartados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apartados.Location = new System.Drawing.Point(223, 553);
            this.btn_Apartados.Name = "btn_Apartados";
            this.btn_Apartados.Size = new System.Drawing.Size(210, 85);
            this.btn_Apartados.TabIndex = 44;
            this.btn_Apartados.UseVisualStyleBackColor = false;
            this.btn_Apartados.Click += new System.EventHandler(this.btn_Original_Click);
            // 
            // frm_Ingresos_Mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 642);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Apartados);
            this.Controls.Add(this.btn_InicioCaja);
            this.Controls.Add(this.cha_Ingresos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Año);
            this.Controls.Add(this.lbl_Ano);
            this.Controls.Add(this.rb_Ano);
            this.Controls.Add(this.rb_Mes);
            this.Controls.Add(this.lbl_Mes);
            this.Controls.Add(this.cbo_Mes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Ubicacion);
            this.Controls.Add(this.cha_Ganancia);
            this.Controls.Add(this.cha_Gastos);
            this.Controls.Add(this.lbl_AnoHoy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Ingresos_Mes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos del Mes";
            this.Load += new System.EventHandler(this.frm_Ingresos_Mes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cha_Gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ganancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ingresos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AnoHoy;
        private System.Windows.Forms.DataVisualization.Charting.Chart cha_Gastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart cha_Ganancia;
        private System.Windows.Forms.DataVisualization.Charting.Chart cha_Ingresos;
        private System.Windows.Forms.ComboBox cbo_Mes;
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.RadioButton rb_Mes;
        private System.Windows.Forms.RadioButton rb_Ano;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.TextBox txt_Año;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Ubicacion;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private System.Windows.Forms.Timer tmr_Timer;
        private System.Windows.Forms.Button btn_InicioCaja;
        private System.Windows.Forms.Button btn_Apartados;
    }
}