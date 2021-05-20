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
    public partial class EvolutivoPediatria : Form
    {   ClaseEnfermeria Pediatria = new ClaseEnfermeria();
        private LogicLayer _LogicLayer = new LogicLayer();
        public EvolutivoPediatria()
        {
            InitializeComponent();
        }

        private void EvolutivoPediatria_Load(object sender, EventArgs e)
        {
            
        }
        public void Data(ClaseEnfermeria Data)
        {
            textBox1.Text = Data.Observacion;
            textBox2.Text = Data.Patologia;
            textBox3.Text = Data.Antecedentes;
        }
        
        public void GetCita(ClaseEnfermeria Cita)
        {
            Pediatria = Cita;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pediatria.Antecedentes = textBox1.Text;
            Pediatria.Patologia = textBox2.Text;
            Pediatria.Observacion = textBox3.Text;
            _LogicLayer.InsertCitaPediatria(Pediatria);
            this.Close();
        }
    }
}
