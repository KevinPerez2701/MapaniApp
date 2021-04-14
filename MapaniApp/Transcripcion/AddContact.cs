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
            ContactNMB Contact = new ContactNMB
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = dateTimePicker1.Value.Date,
                Direccion = TxtDireccion.Text,
                Sexo = ComboSexo.Text,
                Foto = Metodos.ImageToArray(PbFotoNewContact),
                Cedula = TxtCedula.Text,
                FechaIngreso = dateTimePicker2.Value.Date,
                Discapacidad = ComboDiscapacidad.Text,
                Lactancia = ComboLactancia.Text,
                Ingreso = ComboIngreso.Text,
                Vacunas = ComboVacunas.Text,
                Parto = ComboParto.Text,
                PartidaNacimiento = ComboPartidaNacimiento.Text,
                Id = _contactNMB != null ? _contactNMB.Id : 0
            };
            _LogicLayer.SaveContact(Contact); 
        }

        private void SaveContactCuidador()
        {
            ContactCuidador Contact = new ContactCuidador
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = dateTimePicker1.Value,
                Direccion = TxtDireccion.Text,
                Sexo = ComboSexo.Text,
                Foto = Metodos.ImageToArray(PbFotoNewContact),
                Telefono = TxtTelefono.Text,
                Id = _contactNMB != null ? _contactNMB.Id : 0
            };
            _LogicLayer.SaveContactCuidador(Contact);
        }
        private void SaveContactMMB()
        {
            ContactMMB Contact = new ContactMMB
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = dateTimePicker1.Value,
                Direccion = TxtDireccion.Text,
                Sexo = ComboSexo.Text,
                Foto = Metodos.ImageToArray(PbFotoNewContact),
                Telefono = TxtTelefono.Text,
                Id = _contactNMB != null ? _contactNMB.Id : 0
            };
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
        {   if (textBox1.Text == "NMB")
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
        public void LoadUser(string Contact)
        {
            textBox1.Text = Contact;
            textBox1.ReadOnly = true;
        }


        private void AddContact_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="MMB" || textBox1.Text == "Cuidador")
            {
                label6.Visible = true;
                TxtTelefono.Visible = true;
                labelDiscapacidad.Visible = false;
                ComboDiscapacidad.Visible = false;
                labelFechaIngreso.Visible = false;
                dateTimePicker2.Visible = false;
                labelIngreso.Visible = false;
                ComboIngreso.Visible = false;
                labelLactancia.Visible = false;
                ComboLactancia.Visible = false;
                labelPartidaNacimiento.Visible = false;
                ComboPartidaNacimiento.Visible = false;
                labelParto.Visible = false;
                ComboParto.Visible = false;
                labelvacunas.Visible = false;
                ComboVacunas.Visible = false;
            }
        }

        private void labelIngreso_Click(object sender, EventArgs e)
        {

        }
    }
}
