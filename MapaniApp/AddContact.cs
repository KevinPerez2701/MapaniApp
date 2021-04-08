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

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            TxtIdCuidador.ReadOnly = !TxtIdCuidador.ReadOnly;
            TxtIdCuidador.Visible = !TxtIdCuidador.Visible;
            label6.Visible = !label6.Visible;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TxtIdMMB.ReadOnly = !TxtIdMMB.ReadOnly;
            label8.Visible = !label8.Visible;
            TxtIdMMB.Visible = !TxtIdMMB.Visible;
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
            //Contact.IdCuidador = int.Parse(TxtIdCuidador.Text);
            Contact.Sexo = ComboSexo.Text;
            Contact.Foto = Metodos.ImageToArray(PbFotoNewContact);
            Contact.Id = _contactNMB != null ? _contactNMB.Id : 0;
            _LogicLayer.SaveContact(Contact); 
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
               // TxtIdCuidador.Text = (contact.IdCuidador).ToString();
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }
            private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
        }

      
    }
}
