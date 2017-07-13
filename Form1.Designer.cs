namespace InvestigacionDeOperaciones
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RInput = new System.Windows.Forms.TextBox();
            this.Years = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea4.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea4.IsSameFontSizeForAllAxes = true;
            chartArea4.Name = "ChartArea";
            this.Chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Chart.Legends.Add(legend4);
            this.Chart.Location = new System.Drawing.Point(148, 22);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.Chart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series19.ChartArea = "ChartArea";
            series19.Legend = "Legend1";
            series19.Name = "Inventario Inicial";
            series20.ChartArea = "ChartArea";
            series20.Legend = "Legend1";
            series20.Name = "Numero aleatorio";
            series21.ChartArea = "ChartArea";
            series21.Legend = "Legend1";
            series21.Name = "Demanda Ajustada";
            series22.ChartArea = "ChartArea";
            series22.Legend = "Legend1";
            series22.Name = "Inventario Final";
            series23.ChartArea = "ChartArea";
            series23.Legend = "Legend1";
            series23.Name = "Faltante";
            series24.ChartArea = "ChartArea";
            series24.Legend = "Legend1";
            series24.Name = "Inventario promedio";
            this.Chart.Series.Add(series19);
            this.Chart.Series.Add(series20);
            this.Chart.Series.Add(series21);
            this.Chart.Series.Add(series22);
            this.Chart.Series.Add(series23);
            this.Chart.Series.Add(series24);
            this.Chart.Size = new System.Drawing.Size(568, 316);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor de Q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de R";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RInput
            // 
            this.RInput.Location = new System.Drawing.Point(26, 115);
            this.RInput.Name = "RInput";
            this.RInput.Size = new System.Drawing.Size(100, 20);
            this.RInput.TabIndex = 4;
            this.RInput.TextChanged += new System.EventHandler(this.RInput_TextChanged);
            // 
            // Years
            // 
            this.Years.FormattingEnabled = true;
            this.Years.Items.AddRange(new object[] {
            "Año 1",
            "Año 2",
            "Año 3",
            "Año 4",
            "Año 5",
            "Año 6",
            "Año 7",
            "Año 8",
            "Año 9",
            "Año 10"});
            this.Years.Location = new System.Drawing.Point(26, 185);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(121, 21);
            this.Years.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.RInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox RInput;
        private System.Windows.Forms.ComboBox Years;
        private System.Windows.Forms.Label label3;
    }
}

