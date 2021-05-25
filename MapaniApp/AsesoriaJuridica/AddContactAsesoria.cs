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
    public partial class AddContactAsesoria : Form
    {
        private ContactAsesoria _contactAsesoria = new ContactAsesoria();
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddContactAsesoria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddContactAsesoria_Load(object sender, EventArgs e)
        {

        }
        public void GetReferencia(string ID)
        {
            txtID.Text = ID;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveContactAsesoria();
            this.Close();
        }
        private void SaveContactAsesoria()
        {
            ContactAsesoria Contact = new ContactAsesoria
            { IdCuidador = int.Parse(txtID.Text),
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                Direccion = TxtDireccion.Text,
                Telefono = txtTelefono.Text,
                Ocupacion = txtOcupacion.Text,
                Cedula = txtCedula.Text,
                Parroquia = txtParroquia.Text,
                Municipio = txtMunicipio.Text,
                Estado = txtEstado.Text,
                Vinculo = txtVinculo.Text,
                Id = _contactAsesoria != null ? _contactAsesoria.Id : 0
            };
            _LogicLayer.SaveContactAsesoria(Contact);
        }
    }
}
