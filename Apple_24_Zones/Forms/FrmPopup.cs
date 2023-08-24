using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Apple_24_Zones.Forms
{
    public partial class FrmPopup : Form
    {
        public FrmPopup()
        {
            InitializeComponent();
        }

        private void ChartMain_CustomizeLegend(object sender, CustomizeLegendEventArgs e)
        {
            e.LegendItems.Clear();
            foreach (var series in this.ChartMain.Series)
            {
                var legendItem = new LegendItem();
                legendItem.SeriesName = series.Name;
                legendItem.ImageStyle = LegendImageStyle.Rectangle;
                legendItem.BorderColor = Color.Transparent;
                legendItem.Name = series.Name + "_legend_item";

                int i = legendItem.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
                legendItem.Cells.Add(LegendCellType.Text, series.Name, ContentAlignment.MiddleCenter);

                if (series.Enabled)
                    legendItem.Color = series.Color;
                else
                    legendItem.Color = Color.FromArgb(100, series.Color);
                e.LegendItems.Add(legendItem);
            }

            foreach (LegendItem lit in e.LegendItems)
            {
                var cells = lit.Cells;
                cells[0].Margins = new Margins(30, 0, 0, 0);
                cells[1].Margins = new Margins(30, 0, 0, 200);
            }

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void zone2label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void zone2label1_Click(object sender, EventArgs e)
        {

        }

        private void zone2label2_Click(object sender, EventArgs e)
        {

        }

        private void zone2label3_Click(object sender, EventArgs e)
        {

        }

        private void zone2label4_Click(object sender, EventArgs e)
        {

        }

        private void zone2label5_Click(object sender, EventArgs e)
        {

        }

        private void zone2label6_Click(object sender, EventArgs e)
        {

        }

        private void zone2label7_Click(object sender, EventArgs e)
        {

        }

        private void zone2label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void zone2label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void zone2label8_Click(object sender, EventArgs e)
        {

        }

        private void zone2label9_Click(object sender, EventArgs e)
        {

        }
    }
}
