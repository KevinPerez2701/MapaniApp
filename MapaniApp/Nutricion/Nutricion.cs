using RDotNet;
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
    public partial class Nutricion : Form
    {
        public Nutricion()
        {
            InitializeComponent();
        }

        private void Nutricion_Load(object sender, EventArgs e)
        {                        
        }

        private void BtnHistorialNutricional_Click(object sender, EventArgs e)
        {
            HistorialNutricional Historial = new HistorialNutricional();
            Historial.ShowDialog(this);
        }
    }
}
