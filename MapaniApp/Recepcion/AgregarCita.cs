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
            this.Close();
        }
        private void SaveDate()
        {
            ProximasVisitas Cita = new ProximasVisitas();
            Cita.IdNMB = int.Parse(TxtId.Text);
            Cita.Fecha =DateCita.Value;
            Cita.Departamento = comboDepartamento.Text;
            _LogicLayer.SaveCita(Cita);
        }
        public void LoadData(string ID)
        {
            TxtId.Text = ID;            
        }
        private void AgregarCita_Load(object sender, EventArgs e)
        {

        }
    }
}
