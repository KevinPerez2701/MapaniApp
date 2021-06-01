using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

      

        private void abrirPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axAcroPDF1.src = openFileDialog1.FileName;           
        }

        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // saveFileDialog1.ShowDialog();
            Metodos.GuardarFoto(pictureBox1);
        }
    }
}
