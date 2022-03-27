using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class AddDocuments : Form
    {
        string filepath;
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddDocuments()
        {
            InitializeComponent();
        }

        #region Carga de Contactos 
        public void LoadContactCuidador(string ID)
        {
            List<ContactCuidador> Contacts = _LogicLayer.GetContactsCuidador(ID);
            ContactCuidador contact = Contacts[0];
            TxtNombre.Text = contact.Nombre;
            TxtApellido.Text = contact.Apellido;
            txtCedula.Text = contact.Cedula;
        }
        #endregion

        #region Eventos
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDocumento.Text == "Partida Nacimiento" || ComboDocumento.Text == "Cedula NMB")
            {
                labelIdNMB.Visible = true;
                txtIdNMB.Visible = true;
                BtnAgregar.Visible = true;
            }
            else
            {
                BtnAgregar.Visible = true;
                labelIdNMB.Visible = false;
                txtIdNMB.Visible = false;
            }
        }

        #endregion

        #region Botones
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveDocument();
            this.Close();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadContactCuidador(txtID.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;

            }

        }
        #endregion

        #region Funciones
        private void SaveDocument()
        {
            if (txtIdNMB.Text == "")
                txtIdNMB.Text = "0";
            ContactAsesoria document = new ContactAsesoria
            {
                IdCuidador = int.Parse(txtID.Text),
                IdNMB = int.Parse(txtIdNMB.Text),
                TipoDocumento = ComboDocumento.Text,

            };
            Metodos.databaseFilePut(filepath, document);
            _LogicLayer.SaveDocument(document);
            //}

        }
        #endregion

        #region Validacion de Datos
        private void AddDocuments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ComboDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

            MessageBox.Show("Seleccione un Documento Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;

        }
        #endregion

        private void AddDocuments_Load(object sender, EventArgs e)
        {

        }
    }
}
