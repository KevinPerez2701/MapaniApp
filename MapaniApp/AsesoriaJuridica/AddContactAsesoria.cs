using System;
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
        private void AddContactAsesoria_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveContactAsesoria();
            this.Close();
        }
        #endregion

        #region Funciones
        public void GetReferencia(string ID)
        {
            txtID.Text = ID;
        }
        private void SaveContactAsesoria()
        {
            ContactAsesoria Contact = new ContactAsesoria
            {
                IdCuidador = int.Parse(txtID.Text),
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
        #endregion

        #region Validacion de Datos
        private void AddContactAsesoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese un Caracter Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
