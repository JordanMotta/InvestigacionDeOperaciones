using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InvestigacionDeOperaciones
{
    public partial class Form1 : Form
    {
        List<Table> tables;
        public Form1()
        {
            InitializeComponent();
            tables = new List<Table>();
            for (int i = 0; i < 10; i++)
            {
                Chart.Series[0].Points.Add(new double[] {12});
                Chart.Series[1].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 12));
                Chart.Series[1].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 10));
                Chart.Series[1].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 3));
                Chart.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void RInput_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void update()
        {
            foreach (Table table in tables)
            {
                for (int month = 0; month < 12; month++)
                {

                }
            }
        }

        private List<Table> getTables()
        {
            return null;
        }
    }
}
