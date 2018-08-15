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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ingresos_Mes));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbl_AnoHoy = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cha_Gastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cha_Ganancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cha_Ingresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbo_Ubicacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Mes = new System.Windows.Forms.ComboBox();
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.rb_Mes = new System.Windows.Forms.RadioButton();
            this.rb_Ano = new System.Windows.Forms.RadioButton();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.txt_Año = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.pib_Top = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ganancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha_Ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AnoHoy
            // 
            this.lbl_AnoHoy.AutoSize = true;
            this.lbl_AnoHoy.Location = new System.Drawing.Point(985, 166);
            this.lbl_AnoHoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AnoHoy.Name = "lbl_AnoHoy";
            this.lbl_AnoHoy.Size = new System.Drawing.Size(0, 18);
            this.lbl_AnoHoy.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.Location = new System.Drawing.Point(999, 2);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(37, 37);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cha_Gastos
            // 
            this.cha_Gastos.BackColor = System.Drawing.Color.Transparent;
            this.cha_Gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cha_Gastos.BorderlineColor = System.Drawing.Color.Transparent;
            this.cha_Gastos.BorderlineWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.cha_Gastos.ChartAreas.Add(chartArea4);
            this.cha_Gastos.Cursor = System.Windows.Forms.Cursors.No;
            legend4.Name = "Legend1";
            this.cha_Gastos.Legends.Add(legend4);
            this.cha_Gastos.Location = new System.Drawing.Point(525, 57);
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
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Gastos";
            this.cha_Gastos.Series.Add(series4);
            this.cha_Gastos.Size = new System.Drawing.Size(500, 343);
            this.cha_Gastos.TabIndex = 17;
            this.cha_Gastos.Text = "Gastos de la Empresa";
            title4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Gastos de la Empresa";
            title4.Text = "Gastos";
            this.cha_Gastos.Titles.Add(title4);
            // 
            // cha_Ganancia
            // 
            this.cha_Ganancia.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.cha_Ganancia.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.cha_Ganancia.Legends.Add(legend5);
            this.cha_Ganancia.Location = new System.Drawing.Point(399, 408);
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
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Ganancias";
            series5.YValuesPerPoint = 2;
            this.cha_Ganancia.Series.Add(series5);
            this.cha_Ganancia.Size = new System.Drawing.Size(626, 344);
            this.cha_Ganancia.TabIndex = 18;
            this.cha_Ganancia.Text = "Ganancia Total de la Empresa";
            title5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Ganancia Total";
            title5.Text = "Ganancias";
            this.cha_Ganancia.Titles.Add(title5);
            // 
            // cha_Ingresos
            // 
            this.cha_Ingresos.BackColor = System.Drawing.Color.Transparent;
            this.cha_Ingresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cha_Ingresos.BorderlineColor = System.Drawing.Color.Transparent;
            this.cha_Ingresos.BorderlineWidth = 0;
            this.cha_Ingresos.BorderSkin.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.cha_Ingresos.ChartAreas.Add(chartArea6);
            this.cha_Ingresos.Cursor = System.Windows.Forms.Cursors.No;
            legend6.Name = "Legend1";
            this.cha_Ingresos.Legends.Add(legend6);
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
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Color = System.Drawing.Color.White;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series6.LabelBorderWidth = 0;
            series6.Legend = "Legend1";
            series6.MarkerSize = 7;
            series6.Name = "Ingresos";
            this.cha_Ingresos.Series.Add(series6);
            this.cha_Ingresos.Size = new System.Drawing.Size(500, 343);
            this.cha_Ingresos.TabIndex = 19;
            this.cha_Ingresos.Text = "Gastos de la Empresa";
            title6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Ingresos de la Empresa";
            title6.Text = "Ingresos";
            this.cha_Ingresos.Titles.Add(title6);
            // 
            // cbo_Ubicacion
            // 
            this.cbo_Ubicacion.FormattingEnabled = true;
            this.cbo_Ubicacion.Location = new System.Drawing.Point(111, 466);
            this.cbo_Ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Ubicacion.Name = "cbo_Ubicacion";
            this.cbo_Ubicacion.Size = new System.Drawing.Size(212, 26);
            this.cbo_Ubicacion.TabIndex = 20;
            this.cbo_Ubicacion.SelectedIndexChanged += new System.EventHandler(this.cbo_Ubicacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 469);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ubicación:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbo_Mes
            // 
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
            this.cbo_Mes.Location = new System.Drawing.Point(136, 582);
            this.cbo_Mes.Name = "cbo_Mes";
            this.cbo_Mes.Size = new System.Drawing.Size(189, 26);
            this.cbo_Mes.TabIndex = 22;
            this.cbo_Mes.Visible = false;
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.AutoSize = true;
            this.lbl_Mes.Location = new System.Drawing.Point(45, 585);
            this.lbl_Mes.Name = "lbl_Mes";
            this.lbl_Mes.Size = new System.Drawing.Size(41, 18);
            this.lbl_Mes.TabIndex = 23;
            this.lbl_Mes.Text = "Mes:";
            this.lbl_Mes.Visible = false;
            // 
            // rb_Mes
            // 
            this.rb_Mes.AutoSize = true;
            this.rb_Mes.Location = new System.Drawing.Point(122, 522);
            this.rb_Mes.Name = "rb_Mes";
            this.rb_Mes.Size = new System.Drawing.Size(55, 22);
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
            this.rb_Ano.Location = new System.Drawing.Point(252, 522);
            this.rb_Ano.Name = "rb_Ano";
            this.rb_Ano.Size = new System.Drawing.Size(52, 22);
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
            this.lbl_Ano.Location = new System.Drawing.Point(65, 585);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(38, 18);
            this.lbl_Ano.TabIndex = 26;
            this.lbl_Ano.Text = "Año:";
            this.lbl_Ano.Visible = false;
            // 
            // txt_Año
            // 
            this.txt_Año.Location = new System.Drawing.Point(111, 582);
            this.txt_Año.Multiline = true;
            this.txt_Año.Name = "txt_Año";
            this.txt_Año.Size = new System.Drawing.Size(201, 26);
            this.txt_Año.TabIndex = 27;
            this.txt_Año.Visible = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.White;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(143)))), ((int)(((byte)(218)))));
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(143)))), ((int)(((byte)(218)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.Location = new System.Drawing.Point(331, 488);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(103, 90);
            this.btn_Buscar.TabIndex = 28;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // pib_Top
            // 
            this.pib_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pib_Top.Location = new System.Drawing.Point(-3, 0);
            this.pib_Top.Name = "pib_Top";
            this.pib_Top.Size = new System.Drawing.Size(1041, 40);
            this.pib_Top.TabIndex = 29;
            this.pib_Top.TabStop = false;
            this.pib_Top.Click += new System.EventHandler(this.pib_Top_Click);
            // 
            // frm_Ingresos_Mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 756);
            this.ControlBox = false;
            this.Controls.Add(this.pib_Top);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Año);
            this.Controls.Add(this.lbl_Ano);
            this.Controls.Add(this.rb_Ano);
            this.Controls.Add(this.rb_Mes);
            this.Controls.Add(this.lbl_Mes);
            this.Controls.Add(this.cbo_Mes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Ubicacion);
            this.Controls.Add(this.cha_Ingresos);
            this.Controls.Add(this.cha_Ganancia);
            this.Controls.Add(this.cha_Gastos);
            this.Controls.Add(this.btn_Cancelar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pib_Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AnoHoy;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataVisualization.Charting.Chart cha_Gastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart cha_Ganancia;
        private System.Windows.Forms.DataVisualization.Charting.Chart cha_Ingresos;
        private System.Windows.Forms.ComboBox cbo_Ubicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Mes;
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.RadioButton rb_Mes;
        private System.Windows.Forms.RadioButton rb_Ano;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.TextBox txt_Año;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.PictureBox pib_Top;
    }
}