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
    public partial class Recepcion : Form
    {
        private Metodos _metodos;
        private ContactNMB _contactNMB = new ContactNMB();
        private LogicLayer _LogicLayer = new LogicLayer();
        public Recepcion()
        {
            InitializeComponent();
        }

        public void PopulateContacts(string SearchText = null)
        {
            List<ContactCuidador> contacts = _LogicLayer.GetCuidadores(SearchText);
            dataGridView1.DataSource = contacts;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (ComboUsuario.Text == "NMB")
            {
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                ContactNMB contact = contacts[0];
                LoadContact(contact);
                PopulateContacts(TxtID.Text);
            }
        }

        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                TxtDireccion.Text = contact.Direccion;
                pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }

        private void Recepcion_Load(object sender, EventArgs e)
        {
           //Hello wordl
        }
    }
}
