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
    public partial class Pediatria : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        private ContactNMB _contactNMB = new ContactNMB();
        private ContactMMB _contactMMB = new ContactMMB();
        public Pediatria()
        {
            InitializeComponent();
        }

        private void BtnCargarContacto_Click(object sender, EventArgs e)
        {          
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                ContactNMB contact = contacts[0];
                LoadContact(contact);
            BtnAddOrder.Visible = true;
            
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

        private void Pediatria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProductos NuevaOrden = new VerProductos();
            NuevaOrden.GetProductos();
            NuevaOrden.GetIdNMB(TxtID.Text);
            NuevaOrden.ShowDialog(this);
        }
    }
}
