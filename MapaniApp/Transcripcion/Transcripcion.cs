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
        public Transcripcion()
        {
            InitializeComponent();
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
        }

        private void ComboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboOperacion.Text == "Editar Contacto")
            {
                labelId.Visible = true;
                TxtId.Visible = true;
            }
            else
            {
                labelId.Visible = false;
                TxtId.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
