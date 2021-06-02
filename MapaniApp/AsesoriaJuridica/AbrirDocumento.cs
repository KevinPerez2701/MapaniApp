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
    { string filepath;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;

            }
            Metodos.databaseFileRead(contact, filepath);
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

        private void guardarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.ShowDialog();

            // Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            Document doc = new Document(PageSize.A4);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(svg.FileName + ".pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            doc.Add(png);

            doc.Close();
        }
    }
}
