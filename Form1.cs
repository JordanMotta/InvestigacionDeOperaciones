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
            for (int n = 0; n < Chart.Series.Count; n++)
            {
                for (int i = 0; i < 12; i++)
                {
                    Chart.Series[n].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(i, 5));
                }    
            }
            Chart.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            update();
            showData();
        }

        private void Years_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Item selected: " + Years.Text);
        }

        private void RInput_TextChanged(object sender, EventArgs e)
        {
            update();
            showData();
        }

        private void showData()
        {
            
        }

        private void update()
        {
            
        }

        private List<Table> getTables()
        {
            return null;
        }
    }
}
