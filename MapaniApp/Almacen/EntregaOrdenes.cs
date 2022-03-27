using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class EntregaOrdenes : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public EntregaOrdenes()
        {
            InitializeComponent();
        }
        private void EntregaOrdenes_Load(object sender, EventArgs e)
        {

        }
        #region Botones
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones
        public void PopulateContacts()
        {
            List<DataAlmacen> contacts = _LogicLayer.GetOrdenes();
            foreach (DataAlmacen contact in contacts.ToArray())
            {
                if (contact.Despachado == "Si")
                    contacts.Remove(contact);
            }
            dataGridView1.DataSource = contacts;
        }
        public void GetHistorial(DataAlmacen Orden)
        {
            List<DataAlmacen> contacts = _LogicLayer.GetHistorialOrdenes(Orden);
            foreach (DataAlmacen contact in contacts.ToArray())
            {
                if (contact.Despachado == "No")
                    contacts.Remove(contact);
            }

            dataGridView1.DataSource = contacts;
            dataGridView1.Columns[7].Visible = false;
        }
        #endregion
        #region Eventos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Despachar") // Si se selecciona el hipervinculo "confirmar"
            {
                _LogicLayer.Despacho(new DataAlmacen
                {
                    IdNMB = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    IdProducto = int.Parse((dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString())),
                    Fecha = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[4].Value,
                    Cantidad = int.Parse((dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString())),
                });

                PopulateContacts();
            }

        }
        #endregion


    }

}
