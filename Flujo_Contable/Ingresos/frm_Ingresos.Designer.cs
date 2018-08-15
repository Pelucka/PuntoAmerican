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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Original = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ganancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ingresos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Original)).BeginInit();
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
            chartArea1.Name = "ChartArea1";
            this.cha_Gastos.ChartAreas.Add(chartArea1);
            this.cha_Gastos.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.cha_Gastos.Legends.Add(legend1);
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
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Gastos";
            this.cha_Gastos.Series.Add(series1);
            this.cha_Gastos.Size = new System.Drawing.Size(452, 284);
            this.cha_Gastos.TabIndex = 17;
            this.cha_Gastos.Text = "Gastos de la Empresa";
            title1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Gastos de la Empresa";
            title1.Text = "Gastos";
            this.cha_Gastos.Titles.Add(title1);
            this.cha_Gastos.Click += new System.EventHandler(this.cha_Gastos_Click);
            // 
            // cha_Ganancia
            // 
            this.cha_Ganancia.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.cha_Ganancia.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.cha_Ganancia.Legends.Add(legend2);
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
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Ganancias";
            series2.YValuesPerPoint = 2;
            this.cha_Ganancia.Series.Add(series2);
            this.cha_Ganancia.Size = new System.Drawing.Size(555, 289);
            this.cha_Ganancia.TabIndex = 18;
            this.cha_Ganancia.Text = "Ganancia Total de la Empresa";
            title2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Ganancia Total";
            title2.Text = "Ganancias";
            this.cha_Ganancia.Titles.Add(title2);
            // 
            // cha_Ingresos
            // 
            this.cha_Ingresos.BackColor = System.Drawing.Color.Transparent;
            this.cha_Ingresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cha_Ingresos.BorderlineColor = System.Drawing.Color.Transparent;
            this.cha_Ingresos.BorderlineWidth = 0;
            this.cha_Ingresos.BorderSkin.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.cha_Ingresos.ChartAreas.Add(chartArea3);
            this.cha_Ingresos.Cursor = System.Windows.Forms.Cursors.Hand;
            legend3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.cha_Ingresos.Legends.Add(legend3);
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
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.White;
            series3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series3.LabelBorderWidth = 0;
            series3.Legend = "Legend1";
            series3.MarkerSize = 7;
            series3.Name = "Ingresos";
            this.cha_Ingresos.Series.Add(series3);
            this.cha_Ingresos.Size = new System.Drawing.Size(452, 284);
            this.cha_Ingresos.TabIndex = 19;
            this.cha_Ingresos.Text = "Gastos de la Empresa";
            title3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Ingresos de la Empresa";
            title3.Text = "Ingresos";
            this.cha_Ingresos.Titles.Add(title3);
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
            this.cbo_Mes.Location = new System.Drawing.Point(130, 473);
            this.cbo_Mes.Name = "cbo_Mes";
            this.cbo_Mes.Size = new System.Drawing.Size(189, 28);
            this.cbo_Mes.TabIndex = 22;
            this.cbo_Mes.Visible = false;
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.AutoSize = true;
            this.lbl_Mes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mes.Location = new System.Drawing.Point(42, 481);
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
            this.rb_Mes.Location = new System.Drawing.Point(132, 419);
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
            this.rb_Ano.Location = new System.Drawing.Point(246, 419);
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
            this.lbl_Ano.Location = new System.Drawing.Point(43, 531);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(43, 20);
            this.lbl_Ano.TabIndex = 26;
            this.lbl_Ano.Text = "Año:";
            this.lbl_Ano.Visible = false;
            // 
            // txt_Año
            // 
            this.txt_Año.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Año.Location = new System.Drawing.Point(130, 525);
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
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageActive = null;
            this.btn_Buscar.Location = new System.Drawing.Point(144, 569);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(55, 55);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Buscar.TabIndex = 32;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Zoom = 10;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Original
            // 
            this.btn_Original.BackColor = System.Drawing.Color.Transparent;
            this.btn_Original.Image = ((System.Drawing.Image)(resources.GetObject("btn_Original.Image")));
            this.btn_Original.ImageActive = null;
            this.btn_Original.Location = new System.Drawing.Point(247, 569);
            this.btn_Original.Name = "btn_Original";
            this.btn_Original.Size = new System.Drawing.Size(55, 55);
            this.btn_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Original.TabIndex = 33;
            this.btn_Original.TabStop = false;
            this.btn_Original.Zoom = 10;
            this.btn_Original.Click += new System.EventHandler(this.btn_Original_Click);
            // 
            // frm_Ingresos_Mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 642);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Original);
            this.Controls.Add(this.btn_Buscar);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Original)).EndInit();
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
        private Bunifu.Framework.UI.BunifuImageButton btn_Original;
        private Bunifu.Framework.UI.BunifuImageButton btn_Buscar;
    }
}