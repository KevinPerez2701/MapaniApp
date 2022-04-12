using System;
using System.Collections.Generic;
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

        #region Botones
        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboOperacion.Text == "Agregar Contacto")
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
                    if (contacts.Count != 0)
                    {
                        ContactNMB contact = contacts[0];
                        AddContact contactDetails = new AddContact();
                        contactDetails.LoadContact(contact);
                        contactDetails.EditUser(ComboContacto.Text, TxtId.Text);
                        contactDetails.ShowDialog(this);
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (ComboContacto.Text == "Cuidador")
                {
                    List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtId.Text);
                    if (contacts.Count != 0)
                    {
                        ContactCuidador contact = contacts[0];
                        AddContact contactDetails = new AddContact();
                        contactDetails.LoadContactCuidador(contact);
                        contactDetails.EditUser(ComboContacto.Text, contact.Id.ToString());
                        contactDetails.ShowDialog(this);
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (ComboContacto.Text == "MMB")
                {
                    List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtId.Text);
                    if (contacts.Count != 0)
                    {
                        ContactMMB contact = contacts[0];
                        AddContact contactDetails = new AddContact();
                        contactDetails.LoadContactMMB(contact);
                        contactDetails.EditUser(ComboContacto.Text, contact.Id.ToString());
                        contactDetails.ShowDialog(this);
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else if (ComboOperacion.Text == "Ver Contacto")
            {
                if (ComboContacto.Text == "NMB")
                {
                    List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtId.Text);
                    if ( contacts.Count != 0) 
                    {
                        ContactNMB contact = contacts[0];
                        AddContact contactDetails = new AddContact();
                        contactDetails.LoadContact(contact);
                        contactDetails.LoadUser(ComboContacto.Text, TxtId.Text);
                        contactDetails.HideSave();
                        contactDetails.ShowDialog(this);
                        Clean();
                    }
                    else
                    {
                      MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

                else if (ComboContacto.Text == "Cuidador")
                {
                    List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtId.Text);
                    if (contacts.Count != 0)
                    {
                        ContactCuidador contact = contacts[0];
                        AddContact contactDetails = new AddContact();
                        contactDetails.LoadContactCuidador(contact);
                        contactDetails.HideSave();
                        contactDetails.LoadUser(ComboContacto.Text, contact.Id.ToString());
                        contactDetails.ShowDialog(this);
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (ComboContacto.Text == "MMB")
                {
                    List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtId.Text);
                    if (contacts.Count != 0)
                    {
                        ContactMMB contact = contacts[0];
                        AddContact contactDetails = new AddContact();
                        contactDetails.LoadContactMMB(contact);
                        contactDetails.LoadUser(ComboContacto.Text, contact.Id.ToString());
                        contactDetails.HideSave();
                        contactDetails.ShowDialog(this);
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (ComboOperacion.Text == "Buscar Contacto")
            {
                List<ContactNMB> Cedula = _LogicLayer.GetRelacion(TxtCedula.Text);
                if (Cedula.Count != 0)
                {
                    dataGridView1.DataSource = Cedula;
                }
                else
                {
                    MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (ComboOperacion.Text == "Agregar Relación")
            {
                if (ComboCuidador.Text == "Cuidador")
                {
                    List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtIdCuidador.Text);
                   
                    List<ContactNMB> contactsNMB = _LogicLayer.GetContacts(TxtIdNMB.Text);
                    
                    if (contacts.Count != 0 && contactsNMB.Count != 0)
                    {
                        ContactCuidador contact = contacts[0];
                        ContactNMB contactNMB = contactsNMB[0];
                        _LogicLayer.InsertRelacion(contactNMB.Id.ToString(), contact.Id.ToString(), txtParentesco.Text, contact.Cedula);
                        Clean();
                    }
                    else
                    {
                       MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (ComboCuidador.Text == "MMB")
                {
                    List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtIdCuidador.Text);
                   
                    List<ContactNMB> contactsNMB = _LogicLayer.GetContacts(TxtIdNMB.Text);
                   
                    if (contacts.Count != 0 && contactsNMB.Count != 0)
                    {
                        ContactMMB contact = contacts[0];
                        ContactNMB contactNMB = contactsNMB[0];
                        _LogicLayer.InsertRelacionMMB(contactNMB.Id.ToString(), contact.Id.ToString(), txtParentesco.Text, contact.Cedula);
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (ComboOperacion.Text == "Imprimir")
            {   if (ComboCuidador.Text == "Cuidador")
                {
                    List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtIdNMB.Text);
                   
                    List<ContactCuidador> contactsCuidador = _LogicLayer.GetContactsCuidador(TxtIdCuidador.Text);
                    
                    if (contacts.Count != 0 && contactsCuidador.Count != 0)
                    {
                        ContactCuidador contactCuidador = contactsCuidador[0];
                        ContactNMB contact = contacts[0];
                        ImprimirTranscripcion Imprimir = new ImprimirTranscripcion();
                        Imprimir.LoadContact(contact);
                        Imprimir.LoadContactCuidador(contactCuidador);
                        Imprimir.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (ComboCuidador.Text =="MMB")
                {
                    List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtIdNMB.Text);
                    
                    List<ContactMMB> contactsCuidador = _LogicLayer.GetContactsMMB(TxtIdCuidador.Text);
                   
                    if (contacts.Count != 0 && contactsCuidador.Count != 0)
                    {
                        ContactNMB contact = contacts[0];
                        ContactMMB contactCuidador = contactsCuidador[0];
                        ImprimirTranscripcion Imprimir = new ImprimirTranscripcion();
                        Imprimir.LoadContact(contact);
                        Imprimir.LoadContactMMB(contactCuidador);
                        Imprimir.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Valor del Cuidador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                   
                    return;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Eventos
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
            else if (ComboOperacion.Text == "Agregar Relación")
            {
                HideLabels();
                labelTipoCuidador.Visible = true;
                ComboCuidador.Visible = true;
                labelContactoID.Visible = true;
                labelIdNMB.Visible = true;
                TxtIdNMB.Visible = true;
                TxtIdCuidador.Visible = true;
                labelTipoCuidador.Visible = true;
                labelParentesco.Visible = true;
                txtParentesco.Visible = true;

            }
            else if (ComboOperacion.Text == "Imprimir")
            {
                HideLabels();
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
        #endregion     
        #region Limpieza de Datos


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
            PrimeraVez.Visible = false;
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
        #endregion
        #region Validacion de Datos
        private void ComboCuidador_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese una opcion Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }
        private void TxtIdNMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtIdCuidador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtParentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca un Parentesco Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        #endregion

       

        private void ComboContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboContacto.Text == "NMB" && ComboOperacion.Text == "Agregar Contacto")
            {
                PrimeraVez.Visible = true;
            }
            else
            {
                PrimeraVez.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TxtId.Visible = !TxtId.Visible;
            labelId.Visible = !labelId.Visible;
        }
    }
}
