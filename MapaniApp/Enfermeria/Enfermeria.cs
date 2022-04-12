using System;
using System.Collections.Generic;
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
        #region Funciones 
        private void Enfermeria_Load(object sender, EventArgs e)
        {
            TxtNombre.ReadOnly = true;
            txtEdadVisible.ReadOnly = true;
            TxtApellido.ReadOnly = true;
            dateTimePicker1.Enabled = false;
        }
        private void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                TxtEdad.Text = Metodos.GetEdad(contact.FechaNacimiento, DateTimeFecha.Value);
                txtEdadVisible.Text = Metodos.ObtenerEdad(contact.FechaNacimiento);
            }
        }
        private void SaveContact()
        {
            ClaseEnfermeria Cita = new ClaseEnfermeria
            {
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
        #endregion
        #region Botones

        private void BtnCargarContacto_Click(object sender, EventArgs e)
        {
            List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
            if (contacts.Count != 0)
            {
                ContactNMB contact = contacts[0];
                LoadContact(contact);
                groupBox1.Visible = true;
                groupBase.Visible = true;
                if (int.Parse(TxtEdad.Text) < 730)
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
            else
            {
                MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        #endregion

        #region Validacion de datos
        private void ComboUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese una opcion Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBox.Show("Ingrese un Dato Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPeso_Leave(object sender, EventArgs e)
        {
            
            if (TxtPeso.Text != "" )
            {
                if (float.Parse(TxtPeso.Text) < 1 || float.Parse(TxtPeso.Text) > 275)
                {
                    MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtPeso.Text = "0";
                    TxtPeso.Focus();
                   
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPeso.Text = "0";
                TxtPeso.Focus();
            }
        }

        private void TxtTalla_Leave(object sender, EventArgs e)
        {
            if (TxtTalla.Text != "")
            {
                if (float.Parse(TxtTalla.Text) < 38 || float.Parse(TxtTalla.Text) > 230)
                {
                    MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtTalla.Text = "0";
                    
                    TxtTalla.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtTalla.Text = "0";
                TxtTalla.Focus();
            }
        }

        private void TxtCMB_Leave(object sender, EventArgs e)
        {
            if (TxtCMB.Text != "")
            {
                if (float.Parse(TxtCMB.Text) < 6 || float.Parse(TxtCMB.Text) > 35)
                {
                    MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCMB.Text = "0";
                    TxtCMB.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCMB.Text = "0";
                TxtCMB.Focus();
            }
        }

        private void txtCC_Leave(object sender, EventArgs e)
        {
            if (TxtCMB.Text != "")
            {
                if (float.Parse(txtCC.Text) < 25 || float.Parse(txtCC.Text) > 64)
                {
                    MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCC.Text = "0";
                    txtCC.Focus();
                }

            }
            else
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCC.Text = "0";
                txtCC.Focus();
            }

        }

        #endregion

        
    }
}
