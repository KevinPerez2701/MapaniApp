using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            Metodos.databaseFileRead(contact);
        }



        private void abrirPDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axAcroPDF1.src = openFileDialog1.FileName;
        }
    }
}
