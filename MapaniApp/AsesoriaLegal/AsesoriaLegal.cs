using AnthStat.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class AsesoriaLegal : Form
    {
        public AsesoriaLegal()
        {
            InitializeComponent();
        }

        private void AsesoriaLegal_Load(object sender, EventArgs e)
        {
            var who2006 = new AnthStat.Statistics.WHO2006();

            double ageDays = 73.00;
            double bmi = 8.50;
            double z = 0.0;

            if (who2006.TryCalculateZScore(indicator: Indicator.WeightForLength, measurement1: bmi, measurement2: ageDays, sex: Sex.Female, z: ref z))
            {
                double p = StatisticsHelper.CalculatePercentile(z);
                Console.WriteLine($"{ageDays} month old male, BMI = {bmi}, z-score = {z},");
            }

        }
    }
}
