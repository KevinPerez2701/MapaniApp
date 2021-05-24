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
            txtEvolutivo.Text = Data.Observacion;
            txtAntecedentes.Text = Data.Patologia;
            txtPatologias.Text = Data.Antecedentes;
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
            Pediatria.Antecedentes = txtAntecedentes.Text;
            Pediatria.Patologia = txtPatologias.Text;
            Pediatria.Observacion = txtEvolutivo.Text;
            _LogicLayer.InsertCitaPediatria(Pediatria);
            this.Close();
        }
        public void HideButton()
        {
            BtnSave.Visible = false;
            txtAntecedentes.ReadOnly = true;
            txtPatologias.ReadOnly = true;
            txtEvolutivo.ReadOnly = true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
