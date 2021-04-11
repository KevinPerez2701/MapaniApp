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
    public partial class AddContact : Form
    {
        private Metodos _metodos;
        private ContactNMB _contactNMB = new ContactNMB();
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddContact()
        {
            InitializeComponent();
            _metodos = new Metodos();
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            Metodos.AgregarFoto(PbFotoNewContact);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveContact()
        {
            ContactNMB Contact = new ContactNMB();
            Contact.Nombre = TxtNombre.Text;
            Contact.Apellido = TxtApellido.Text;
            Contact.FechaNacimiento = dateTimePicker1.Value;
            Contact.Direccion = TxtDireccion.Text;
            Contact.Sexo = ComboSexo.Text;
            Contact.Foto = Metodos.ImageToArray(PbFotoNewContact);
            Contact.Id = _contactNMB != null ? _contactNMB.Id : 0;
            _LogicLayer.SaveContact(Contact); 
        }

        private void SaveContactCuidador()
        {
            ContactCuidador Contact = new ContactCuidador();
            Contact.Nombre = TxtNombre.Text;
            Contact.Apellido = TxtApellido.Text;
            Contact.FechaNacimiento = dateTimePicker1.Value;
            Contact.Direccion = TxtDireccion.Text;
            Contact.Sexo = ComboSexo.Text;
            Contact.Foto = Metodos.ImageToArray(PbFotoNewContact);
            Contact.Telefono = TxtTelefono.Text;
            Contact.Id = _contactNMB != null ? _contactNMB.Id : 0;
            _LogicLayer.SaveContactCuidador(Contact);
        }
        private void SaveContactMMB()
        {
            ContactMMB Contact = new ContactMMB();
            Contact.Nombre = TxtNombre.Text;
            Contact.Apellido = TxtApellido.Text;
            Contact.FechaNacimiento = dateTimePicker1.Value;
            Contact.Direccion = TxtDireccion.Text;
            Contact.Sexo = ComboSexo.Text;
            Contact.Foto = Metodos.ImageToArray(PbFotoNewContact);
            Contact.Telefono = TxtTelefono.Text;
            Contact.Id = _contactNMB != null ? _contactNMB.Id : 0;
            _LogicLayer.SaveContactMMB(Contact);
        }
        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                ComboSexo.Text = contact.Sexo;
                TxtDireccion.Text = contact.Direccion;
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);
            }

        }
            private void BtnSave_Click(object sender, EventArgs e)
        {   if (comboBox1.Text == "NMB")
            {
                SaveContact();
            }
            else if (comboBox1.Text == "Cuidador")
            {
                SaveContactCuidador();
            }
            else if (comboBox1.Text == "MMB")
            {
                SaveContactMMB();

            }
            this.Close();
        }

        private void AddContact_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cuidador" )
            {
                label6.Visible = !label6.Visible;
                TxtTelefono.Visible = !TxtTelefono.Visible;
                    
            }
            else if (comboBox1.Text == "MMB")
            {
                label6.Visible = !label6.Visible;
                TxtTelefono.Visible = !TxtTelefono.Visible;
            }


        }
    }
}
