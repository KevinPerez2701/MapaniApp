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
    public partial class Transcripcion : Form
    {
        private LogicLayer _LogicLayer;
        public Transcripcion()
        {
            InitializeComponent();
            _LogicLayer = new LogicLayer();
        }

        private void Transcripcion_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboOperacion.Text=="Agregar Contacto")
            {
                AddContact contact = new AddContact();
                contact.LoadUser(ComboContacto.Text);
                contact.ShowDialog(this);
            }
            else if (ComboOperacion.Text == "Ver Contacto" )
            {   if (ComboContacto.Text == "NMB")
                {
                    List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtId.Text);
                    ContactNMB contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContact(contact);
                    contactDetails.LoadUser(ComboContacto.Text);
                    contactDetails.HideSave();
                    contactDetails.ShowDialog(this);
                }
                else if (ComboContacto.Text =="Cuidador")
                {
                    List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtId.Text);
                    ContactCuidador contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContactCuidador(contact);
                    contactDetails.HideSave();
                    contactDetails.LoadUser(ComboContacto.Text);
                    contactDetails.ShowDialog(this);
                }
                else if (ComboContacto.Text =="MMB")
                {
                    List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtId.Text);
                    ContactMMB contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContactMMB(contact);
                    contactDetails.LoadUser(ComboContacto.Text);
                    contactDetails.HideSave();
                    contactDetails.ShowDialog(this);
                }
            }
            else if (ComboOperacion.Text=="Buscar Contacto")
            {
                List<ContactCuidador> Cedula = _LogicLayer.GetCedulaCuidador(TxtCedula.Text);
               // ContactCuidador contact = Cedula[0];
                dataGridView1.DataSource = Cedula;
            }
            else if (ComboOperacion.Text == "Agregar Relacion")
            {
                if (ComboCuidador.Text == "Cuidador")
                {
                    _LogicLayer.InsertRelacion(TxtIdNMB.Text, TxtIdCuidador.Text,txtParentesco.Text);
                }
                else if (ComboCuidador.Text == "MMB")
                {
                    _LogicLayer.InsertRelacionMMB(TxtIdNMB.Text, TxtIdCuidador.Text,txtParentesco.Text);
                }
            }
        }

        private void ComboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboOperacion.Text == "Editar Contacto" || ComboOperacion.Text == "Ver Contacto")
            {
                labelId.Visible = true;
                labelCedula.Visible = false;
                TxtCedula.Visible = false;
                TxtId.Visible = true;
            }
            else if (ComboOperacion.Text == "Buscar Contacto")
            {
                labelCedula.Visible = true;
                TxtCedula.Visible = true;
                labelId.Visible = false;
                TxtId.Visible = false;
                dataGridView1.Visible = true;
            }
            else if (ComboOperacion.Text == "Agregar Relacion")
            {
                labelContactoID.Visible = true;
                labelIdNMB.Visible = true;
                TxtIdNMB.Visible = true;
                TxtIdCuidador.Visible = true;
                labelTipoCuidador.Visible = true;
                ComboCuidador.Visible = true;
                labelParentesco.Visible = true;
                txtParentesco.Visible = true;
            }


            else
            {
                labelParentesco.Visible = false;
                txtParentesco.Visible = false;
                labelTipoCuidador.Visible = false;
                ComboCuidador.Visible = false;
                dataGridView1.Visible = false;
                labelId.Visible = false;
                TxtId.Visible = false;
                labelCedula.Visible = false;
                TxtCedula.Visible = false;
                labelContactoID.Visible = false;
                labelIdNMB.Visible = false;
                TxtIdNMB.Visible = false;
                TxtIdCuidador.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
