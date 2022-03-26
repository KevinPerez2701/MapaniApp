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
            TxtNombre.ReadOnly = true;
            txtEdadVisible.ReadOnly = true;
            TxtApellido.ReadOnly = true;
            dateTimePicker1.Enabled = false;
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
                txtEdadVisible.Text = Metodos.ObtenerEdad(contact.FechaNacimiento);
              



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

        private void groupBase_Enter(object sender, EventArgs e)
        {

        }
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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPeso_Leave(object sender, EventArgs e)
        {
            if (float.Parse(TxtPeso.Text) < 1 || float.Parse(TxtPeso.Text) > 275)
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPeso.Text = "0";
                return;
            }
        }

        private void TxtTalla_Leave(object sender, EventArgs e)
        {
            if (float.Parse(TxtTalla.Text) < 38 || float.Parse(TxtTalla.Text) > 230)
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtTalla.Text = "0";
                return;
            }
        }

        private void TxtCMB_Leave(object sender, EventArgs e)
        {
            if (float.Parse(TxtCMB.Text) < 6 || float.Parse(TxtCMB.Text) > 35)
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCMB.Text = "0";
                return;
            }
        }

        private void txtCC_Leave(object sender, EventArgs e)
        {
            if (float.Parse(txtCC.Text) < 25 || float.Parse(txtCC.Text) > 64)
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCC.Text = "0";
                return;
            }
        }
        #endregion


    }
}
