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
        private ContactCuidador _contactCuidador = new ContactCuidador();
        private ContactMMB _contactMMB = new ContactMMB();
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddContact()
        {
            InitializeComponent();
            _metodos = new Metodos();
        }   
        #region AGREGAR CONTACTOS
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
                Cedula = TxtCedula.Text,
                EstadoCivil = ComboEstadoCivil.Text,
                CantidadHijos = TxtHijos.Text,
                Transporte = TxtTransporte.Text,
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
                Cedula = TxtCedula.Text,
                EstadoCivil = ComboEstadoCivil.Text,
                CantidadHijos = TxtHijos.Text,
                Transporte = TxtTransporte.Text,
                Id = _contactNMB != null ? _contactNMB.Id : 0
            };
            _LogicLayer.SaveContactMMB(Contact);
        }
        #endregion
        #region METODOS  FORM ADD CONTACTS
        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                dateTimePicker2.Value = contact.FechaIngreso.Date;
                ComboLactancia.Text = contact.Lactancia;
                TxtCedula.Text = contact.Cedula;
                ComboDiscapacidad.Text = contact.Discapacidad;
                ComboParto.Text = contact.Parto;
                ComboVacunas.Text = contact.Vacunas;
                ComboPartidaNacimiento.Text = contact.PartidaNacimiento;
                ComboLactancia.Text = contact.Lactancia;
                ComboIngreso.Text = contact.Ingreso;
                ComboSexo.Text = contact.Sexo;
                TxtDireccion.Text = contact.Direccion;
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);
            }


        }
        public void LoadContactCuidador(ContactCuidador contact)
        {
            _contactCuidador = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                ComboEstadoCivil.Text = contact.EstadoCivil;
                TxtHijos.Text = contact.CantidadHijos;
                TxtCedula.Text = contact.Cedula;
                TxtTelefono.Text = contact.Telefono;
                TxtTransporte.Text = contact.Transporte;
                ComboSexo.Text = contact.Sexo;
                TxtDireccion.Text = contact.Direccion;
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);
            }


        }
        public void LoadContactMMB(ContactMMB contact)
        {
            _contactMMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                ComboEstadoCivil.Text = contact.EstadoCivil;
                TxtHijos.Text = contact.CantidadHijos;
                TxtCedula.Text = contact.Cedula;
                TxtTelefono.Text = contact.Telefono;
                TxtTransporte.Text = contact.Transporte;
                ComboSexo.Text = contact.Sexo;
                TxtDireccion.Text = contact.Direccion;
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);
            }


        }
        public void LoadUser(string Contact)
        {
            textBox1.Text = Contact;
            textBox1.ReadOnly = true;
        }
        public void HideSave()
        {
            BtnSave.Visible = false;
        }
        #endregion
        #region EVENTOS DE BOTONES
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "MMB" || textBox1.Text == "Cuidador")
            {
                labelEstadoCivil.Visible = true;
                ComboEstadoCivil.Visible = true;
                labelHijos.Visible = true;
                TxtHijos.Visible = true;
                labelTransporte.Visible = true;
                TxtTransporte.Visible = true;
                HideNMB();

            }
        }
        private void BtnFoto_Click(object sender, EventArgs e)
        {
            Metodos.AgregarFoto(PbFotoNewContact);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {   if (textBox1.Text == "NMB")
            {
                SaveContact();
            }
            else if (textBox1.Text == "Cuidador")
            {
                SaveContactCuidador();
            }
            else if (textBox1.Text == "MMB")
            {
                SaveContactMMB();

            }
            this.Close();
        }
        private void HideNMB()
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
        #endregion

        private void AddContact_Load(object sender, EventArgs e)
        {

        }
    }
}
