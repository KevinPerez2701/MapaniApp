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
    public partial class AbrirDocumento : Form
    {
        public AbrirDocumento()
        {
            InitializeComponent();
        }

        private void AbrirDocumento_Load(object sender, EventArgs e)
        {

        }
        public void LoadDocument(ContactAsesoria contact)

        {
            pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Documento);
        }
    }
}
