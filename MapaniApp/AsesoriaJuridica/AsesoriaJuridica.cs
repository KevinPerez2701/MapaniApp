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
    public partial class AsesoriaJuridica : Form
    {
        public AsesoriaJuridica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroBeneficiarios registro = new RegistroBeneficiarios();
            registro.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDocuments Documento = new AddDocuments();
            Documento.ShowDialog(this);
        }

        private void BtnVerDocumentos_Click(object sender, EventArgs e)
        {
            VerDocumentos Ver = new VerDocumentos();
            Ver.ShowDialog(this);
        }

        private void BtnGestionCasos_Click(object sender, EventArgs e)
        {
            GestionCasos casos = new GestionCasos();
            casos.ShowDialog(this);
        }
    }
}
