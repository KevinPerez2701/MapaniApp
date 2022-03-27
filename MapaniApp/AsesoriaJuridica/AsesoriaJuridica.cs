using System;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class AsesoriaJuridica : Form
    {
        public AsesoriaJuridica()
        {
            InitializeComponent();
        }

        #region Botones
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
        #endregion

        private void AsesoriaJuridica_Load(object sender, EventArgs e)
        {

        }
    }
}
