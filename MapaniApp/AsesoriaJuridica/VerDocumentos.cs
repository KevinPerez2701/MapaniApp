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
    public partial class VerDocumentos : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public VerDocumentos()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadDocuments(txtID.Text);
        }
        public void LoadDocuments(string ID)
        {
            List<ContactAsesoria> Documents = _LogicLayer.GetDocuments(ID);
            dataGridView1.DataSource = Documents;
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Ver") // Si se selecciona el hipervinculo "confirmar"
            {
                AbrirDocumento Documento = new AbrirDocumento();
                Documento.LoadDocument(new ContactAsesoria
                {
                    Documento = (byte[])dataGridView1.Rows[e.RowIndex].Cells[4].Value,
                    PDF = (byte[])dataGridView1.Rows[e.RowIndex].Cells[5].Value,
                });

                Documento.ShowDialog(this);
            }
        }
    }
}
