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
    public partial class ConfirmarCita : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public ConfirmarCita()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void BtnAgregarCita_Click(object sender, EventArgs e)
        {
            ConfirmDate();
           
        }
        private void ConfirmDate()
        {
            if (TxtCuidador.Text == "" || comboBox1.Text == "" || TxtCuidador.Text == null || comboBox1.Text == null)
            {
                MessageBox.Show("Rellene Todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                HistorialVisitas Cita = new HistorialVisitas();
                Cita.IdNMB = int.Parse(TxtId.Text);
                Cita.IdCuidador = int.Parse(TxtCuidador.Text);
                Cita.Fecha = DateCita.Value;
                Cita.Departamento = comboDepartamento.Text;
                Cita.Motivo = TxtObservacion.Text;
                Cita.Reagendo = comboBox1.Text;
                _LogicLayer.ConfirmCita(Cita);
                _LogicLayer.DeleteCita(Cita);
                this.Close();
            }
        }

        public void LoadData(HistorialVisitas Cita)
        {
            if (Cita != null)
            {
                TxtId.Text = Cita.IdNMB.ToString();
                comboDepartamento.Text = Cita.Departamento.ToString();
                DateCita.Value = Cita.Fecha;

            }    
        }

        private void ConfirmarCita_Load(object sender, EventArgs e)
        {
            TxtId.ReadOnly = true;
            DateCita.Enabled = false;
            comboDepartamento.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Si")
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }
    }
}
