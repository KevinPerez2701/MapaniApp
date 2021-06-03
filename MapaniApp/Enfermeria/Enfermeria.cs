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

    public partial class Enfermeria : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        private ContactNMB _contactNMB = new ContactNMB();
        private ContactMMB _contactMMB = new ContactMMB();
        public Enfermeria()
        {
            InitializeComponent();
        }

        private void Enfermeria_Load(object sender, EventArgs e)
        {

        }

        private void BtnCargarContacto_Click(object sender, EventArgs e)
        {
            List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
            ContactNMB contact = contacts[0];
            LoadContact(contact);
            groupBox1.Visible = true;
            groupBase.Visible = true;
            if (int.Parse(TxtEdad.Text)<730)
            {
                txtCC.Visible = true;
                labelCC.Visible = true;
            }
            /*  if ((ComboUsuario.Text == "NMB") && (comboPrograma.Text == "Ponte Poronte")  )
              {
                  List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                  ContactNMB contact = contacts[0];
                  LoadContact(contact);
                  groupBase.Visible = true;
                  groupBox1.Visible = true;                              
              }
              else if  ((ComboUsuario.Text == "NMB") && (comboPrograma.Text == "IRC"))
                  {
                  List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                  ContactNMB contact = contacts[0];
                  LoadContact(contact);

                  groupBox1.Visible = true;

                  groupBase.Visible = true;
              }
            */
        }
        private void LoadContact(ContactNMB contact)
        {   
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                TxtEdad.Text = Metodos.GetEdad(contact.FechaNacimiento,DateTimeFecha.Value);
                
                
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
        }
        private void SaveContact()
        {
            ClaseEnfermeria Cita = new ClaseEnfermeria {
                NMB = TxtID.Text,
                Fecha = DateTimeFecha.Value.Date,
                Programa = comboPrograma.Text,
                Peso = TxtPeso.Text,
                Talla = TxtTalla.Text,              
                CMB = TxtCMB.Text,
                Hb = TxtHb.Text,
                CC = txtCC.Text,
               
            };
            _LogicLayer.SaveContactEnfermeria(Cita);
        }

        private void ComboEdema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
