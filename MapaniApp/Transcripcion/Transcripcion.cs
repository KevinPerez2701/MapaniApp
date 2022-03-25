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
                contact.LoadId(ComboContacto.Text);
                contact.ShowDialog(this);
            }
            else if (ComboOperacion.Text == "Editar Contacto")
            {              
                if (ComboContacto.Text == "NMB")
                {
                    List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtId.Text);
                    ContactNMB contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContact(contact);
                    contactDetails.EditUser(ComboContacto.Text,TxtId.Text);
                    contactDetails.ShowDialog(this);
                    Clean();
                }
                else if (ComboContacto.Text == "Cuidador")
                {
                    List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtId.Text);
                    ContactCuidador contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContactCuidador(contact);             
                    contactDetails.EditUser(ComboContacto.Text, contact.Id.ToString());
                    contactDetails.ShowDialog(this);
                    Clean();
                }
                else if (ComboContacto.Text == "MMB")
                {
                    List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtId.Text);
                    ContactMMB contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContactMMB(contact);
                    contactDetails.EditUser(ComboContacto.Text, contact.Id.ToString());                   
                    contactDetails.ShowDialog(this);
                    Clean();
                }

            }
            else if (ComboOperacion.Text == "Ver Contacto" )
            {   if (ComboContacto.Text == "NMB")
                {
                    List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtId.Text);
                    ContactNMB contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContact(contact);
                    contactDetails.LoadUser(ComboContacto.Text,TxtId.Text);
                    contactDetails.HideSave();
                    contactDetails.ShowDialog(this);
                    Clean();
                }
          
                else if (ComboContacto.Text =="Cuidador")
                {
                    List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtId.Text);
                    ContactCuidador contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContactCuidador(contact);
                    contactDetails.HideSave();
                    contactDetails.LoadUser(ComboContacto.Text, contact.Id.ToString());
                    contactDetails.ShowDialog(this);
                    Clean();
                }
                else if (ComboContacto.Text =="MMB")
                {
                    List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtId.Text);
                    ContactMMB contact = contacts[0];
                    AddContact contactDetails = new AddContact();
                    contactDetails.LoadContactMMB(contact);
                    contactDetails.LoadUser(ComboContacto.Text, contact.Id.ToString());
                    contactDetails.HideSave();
                    contactDetails.ShowDialog(this);
                    Clean();
                }
            }
            else if (ComboOperacion.Text=="Buscar Contacto")
            {
                List<ContactNMB> Cedula = _LogicLayer.GetRelacion(TxtCedula.Text);               
                dataGridView1.DataSource = Cedula;
                
            }
            else if (ComboOperacion.Text == "Agregar Relacion")
            {
                if (ComboCuidador.Text == "Cuidador")
                {
                    List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtIdCuidador.Text);
                    ContactCuidador contact = contacts[0];

                    _LogicLayer.InsertRelacion(TxtIdNMB.Text, contact.Id.ToString(),txtParentesco.Text,contact.Cedula);
                    Clean();
                }
                else if (ComboCuidador.Text == "MMB")
                {
                    _LogicLayer.InsertRelacionMMB(TxtIdNMB.Text, TxtIdCuidador.Text,txtParentesco.Text);
                    Clean();
                }
            }
            else if (ComboOperacion.Text == "Imprimir")
            {
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtIdNMB.Text);
                ContactNMB contact = contacts[0];
                List<ContactCuidador> contactsCuidador = _LogicLayer.GetContactsCuidador(TxtIdCuidador.Text);
                ContactCuidador contactCuidador = contactsCuidador[0];
                ImprimirTranscripcion Imprimir = new ImprimirTranscripcion();
                Imprimir.LoadContact(contact);
                Imprimir.LoadContactCuidador(contactCuidador);
                Imprimir.ShowDialog(this);
            }
        }

        private void ComboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboOperacion.Text == "Agregar Contacto")
            {
                HideLabels();
                labelContacto.Visible = true;
                ComboContacto.Visible = true;

            }
            else if (ComboOperacion.Text == "")
            {
                HideLabels();
            }

            else if (ComboOperacion.Text == "Editar Contacto" || ComboOperacion.Text == "Ver Contacto")
            {
                HideLabels();
                labelContacto.Visible = true;
                ComboContacto.Visible = true;
                labelId.Visible = true;
                TxtId.Visible = true;
            }
            else if (ComboOperacion.Text == "Buscar Contacto")
            {
                HideLabels();
                labelTipoCuidador.Visible = true;
                ComboCuidador.Visible = true;
                labelCedula.Visible = true;
                TxtCedula.Visible = true;
                dataGridView1.Visible = true;
            }
            else if (ComboOperacion.Text == "Agregar Relacion" )
            {
                labelTipoCuidador.Visible = true;
                ComboCuidador.Visible = true;
                labelContactoID.Visible = true;
                labelIdNMB.Visible = true;
                TxtIdNMB.Visible = true;
                TxtIdCuidador.Visible = true;
                labelTipoCuidador.Visible = true;
                ComboCuidador.Visible = true;
                labelParentesco.Visible = true;
                txtParentesco.Visible = true;
               
            }
            else if ( ComboOperacion.Text == "Imprimir")
            {
                labelTipoCuidador.Visible = true;
                ComboCuidador.Visible = true;
                labelContactoID.Visible = true;
                labelIdNMB.Visible = true;
                TxtIdNMB.Visible = true;
                TxtIdCuidador.Visible = true;
                labelTipoCuidador.Visible = true;
                ComboCuidador.Visible = true;
             

            }


            else
            {
                HideLabels();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        

        private void HideLabels()
        {
            labelTipoCuidador.Visible = false;
            ComboCuidador.Visible = false;
            labelCedula.Visible = false;
            TxtCedula.Visible = false;
            labelId.Visible = false;
            TxtId.Visible = false;
            labelContactoID.Visible = false;
            TxtIdCuidador.Visible = false;
            labelIdNMB.Visible = false;
            TxtIdNMB.Visible = false;
            ComboContacto.Visible = false;
            labelContacto.Visible = false;
            labelParentesco.Visible = false;
            txtParentesco.Visible = false;
            dataGridView1.Visible = false;           
            dataGridView1.DataSource = null;
        }
        private void Clean()
        {
            TxtIdNMB.Text = "";
            TxtIdCuidador.Text = "";
            txtParentesco.Text = "";
            TxtCedula.Text = "";
            TxtId.Text = "";
            ComboCuidador.Text = "";
            ComboContacto.Text = "";
            ComboOperacion.Text = "";           
            HideLabels();
        }

       
    }
}
