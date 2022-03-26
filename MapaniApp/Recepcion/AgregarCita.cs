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
    public partial class AgregarCita : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public AgregarCita()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarCita_Click(object sender, EventArgs e)
        {
            SaveDate();
           
        }
        private void SaveDate()
        {   if (comboDepartamento.Text == "" || comboProfesional.Text == "" || comboDepartamento.Text == null || comboProfesional.Text == null)
            {
                MessageBox.Show("Rellene Todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
                return;
            }
            else
            {
                ProximasVisitas Cita = new ProximasVisitas
                {
                    IdNMB = int.Parse(TxtId.Text),
                    Fecha = DateCita.Value,
                    Departamento = comboDepartamento.Text,
                    Rol = comboProfesional.Text
                };
                _LogicLayer.SaveCita(Cita);
                this.Close();
            }
        }
        public void LoadData(string ID)
        {
            TxtId.Text = ID;
            TxtId.ReadOnly = true;
        }
        private void AgregarCita_Load(object sender, EventArgs e)
        {

        }
        #region Validacion de Datos
        private void DateCita_ValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(Metodos.GetEdad(DateCita.Value, DateTime.Now)) > 0)

            {
                MessageBox.Show("Ingrese una Fecha de visita Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DateCita.Value = DateTime.Now;
            }
        }

        private void comboDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese una opcion Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }
        #endregion
    }
}
