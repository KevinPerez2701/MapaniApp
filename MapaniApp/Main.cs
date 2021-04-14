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
    public partial class Main : Form
    {
        private LogicLayer _LogicLayer;
        public Main()
        {
            InitializeComponent();
            _LogicLayer = new LogicLayer();
        }
       
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContact NewContact = new AddContact();
            NewContact.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ContactNMB> contacts = _LogicLayer.GetContacts(textBox1.Text);
            ContactNMB contact = contacts[0];
            AddContact contactDetails = new AddContact();
            contactDetails.LoadContact(contact);
            contactDetails.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
            BtnCargar.Visible = !BtnCargar.Visible;
        }
        #region APERTURA DE NUEVAS VENTANAS
        private void button1_Click_1(object sender, EventArgs e)
        {
            Transcripcion transcripcion = new Transcripcion();
            transcripcion.ShowDialog(this);
        }
        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.ShowDialog(this);
        }

        private void BtnNutricion_Click(object sender, EventArgs e)
        {
            Nutricion nutricion = new Nutricion();
            nutricion.ShowDialog(this);
        }

        private void BtnPsicologia_Click(object sender, EventArgs e)
        {
            Psicologia psicologia = new Psicologia();
            psicologia.ShowDialog(this);
        }

        private void BtnEnfermeria_Click(object sender, EventArgs e)
        {
            Enfermeria enfermeria = new Enfermeria();
            enfermeria.ShowDialog(this);
        }

        private void BtnPediatria_Click(object sender, EventArgs e)
        {
            Pediatria pediatria = new Pediatria();
            pediatria.ShowDialog(this);
        }

        private void BtnLegal_Click(object sender, EventArgs e)
        {
            AsesoriaLegal legal = new AsesoriaLegal();
            legal.ShowDialog(this);
        }

        private void BtnRecepcion_Click(object sender, EventArgs e)
        {
            Recepcion recepcion = new Recepcion();
            recepcion.ShowDialog(this);
        }
        #endregion

       
    }
}
