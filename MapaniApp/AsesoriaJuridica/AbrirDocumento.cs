using System;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class AbrirDocumento : Form
    {
        public AbrirDocumento()
        {
            InitializeComponent();
        }

        #region Apertura de Archivo
        public void LoadDocument(ContactAsesoria contact)

        {
            Metodos.databaseFileRead(contact);
        }
        private void abrirPDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axAcroPDF1.src = openFileDialog1.FileName;
        }
        #endregion

        private void AbrirDocumento_Load(object sender, EventArgs e)
        {

        }


    }
}
