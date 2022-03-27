using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class RegistroBeneficiarios : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public RegistroBeneficiarios()
        {
            InitializeComponent();
        }

        private void AsesoriaLegal_Load(object sender, EventArgs e)
        {

        }
        #region Botones
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadContactCuidador(txtID.Text);
            PopulateContactsNMB(txtID.Text);
            PopulateContactsAsesoria(txtID.Text);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddContactAsesoria asesoria = new AddContactAsesoria();
            asesoria.GetReferencia(txtID.Text);
            asesoria.ShowDialog(this);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Funciones
        public void LoadContactCuidador(string ID)
        {
            List<ContactCuidador> Contacts = _LogicLayer.GetContactsCuidador(ID);
            ContactCuidador contact = Contacts[0];
            TxtNombre.Text = contact.Nombre;
            TxtApellido.Text = contact.Apellido;
            TxtDireccion.Text = contact.Direccion;
            txtParroquia.Text = contact.Parroquia;
            txtMunicipio.Text = contact.Municipio;
            txtEstado.Text = contact.Estado;
            txtCedula.Text = contact.Cedula;
            txtTelefono.Text = contact.Telefono;

        }
        public void PopulateContactsNMB(string SearchText = null)
        {
            List<ContactNMB> contacts = _LogicLayer.GetNMB(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }
        public void PopulateContactsAsesoria(string SearchText = null)
        {
            List<ContactAsesoria> contacts = _LogicLayer.GetContactsAsesoria(SearchText);
            dataGridView1.DataSource = contacts;
        }
        #endregion

        #region Validacion de Datos
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
