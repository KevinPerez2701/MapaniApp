using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class VerDocumentos : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public VerDocumentos()
        {
            InitializeComponent();
        }
        #region Botones 
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadDocuments(txtID.Text);
        }
        #endregion
        #region Funciones
        public void LoadDocuments(string ID)
        {
            List<ContactAsesoria> Documents = _LogicLayer.GetDocuments(ID);
            dataGridView1.DataSource = Documents;
        }
        #endregion
        #region Eventos
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Ver") // Si se selecciona el hipervinculo "confirmar"
            {
                AbrirDocumento Documento = new AbrirDocumento();
                Documento.LoadDocument(new ContactAsesoria
                {

                    PDF = (byte[])dataGridView1.Rows[e.RowIndex].Cells[4].Value,
                });

                Documento.ShowDialog(this);
            }
        }
        #endregion
        #region Validacion de Datos
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void VerDocumentos_Load(object sender, EventArgs e)
        {

        }
    }
}
