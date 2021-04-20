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
            if ((ComboUsuario.Text == "NMB") && (comboPrograma.Text == "Ponte Poronte")  )
            {
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                ContactNMB contact = contacts[0];
                LoadContact(contact);
                groupBase.Visible = true;
                if ((int.Parse(TxtEdad.Text) > 5))
                {
                    groupMayor5.Visible = true;
                    groupMenor5.Visible = false;
                    GroupIRC.Visible = false;
                }
                else if (int.Parse(TxtEdad.Text) < 5)
                {                    
                    groupMenor5.Visible = true;
                    groupMayor5.Visible = false;
                    GroupIRC.Visible = false;
                }
                else
                {
                    groupMenor5.Visible = false;
                    groupMayor5.Visible = false;
                    groupBase.Visible = false;
                }
            }
            else if  ((ComboUsuario.Text == "NMB") && (comboPrograma.Text == "IRC"))
                {
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                ContactNMB contact = contacts[0];
                LoadContact(contact);
                GroupIRC.Visible = true;
                groupMenor5.Visible = false;
                groupMayor5.Visible = false;
                groupBase.Visible = true;
            }

        }
        private void LoadContact(ContactNMB contact)
        {   
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                TxtEdad.Text = Metodos.GetEdad(contact.FechaNacimiento);
                
                
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
                MUAC = TxtMUAC.Text,
                CC = TxtCC.Text,
                CMB = TxtCMB.Text,
                Edema = ComboEdema.Text,
                IMC = TxtIMC.Text,
                PZImcEdad = TxtPzImcEdad.Text,
                PZTallaEdad = TxtPZTallaEdad.Text,
                PZTallaImc = TxtPZpesotalla.Text,
                PesoNacimiento = TxtPesoNacimiento.Text,
                Lactancia = comboLactancia.Text,
                Observacion = TxtObservacion.Text,
                Patologia = TxtPatologia.Text,
                Antecedentes = TxtAntecedentes.Text,
            };
            _LogicLayer.SaveContactEnfermeria(Cita);
        }

        private void GroupIRC_Enter(object sender, EventArgs e)
        {

        }
    }
}
