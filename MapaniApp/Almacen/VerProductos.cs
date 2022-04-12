using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class VerProductos : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public VerProductos()
        {
            InitializeComponent();
        }
        private void VerProductos_Load(object sender, EventArgs e)
        {

        }
       
        #region Funciones

        public void GetProductos(string flag = null)
        {
            List<DataAlmacen> contacts = _LogicLayer.GetProductos();
            dataGridView1.DataSource = contacts;
            if (flag == "1")
                dataGridView1.Columns[6].Visible = false;
        }
        public void GetProductosBodega(string flag = null)
        {
            List<DataAlmacen> contacts = _LogicLayer.GetProductosBodega();
            dataGridView1.DataSource = contacts;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
        public void GetTotalProductos(string flag = null)
        {
            List<DataAlmacen> ProductosAlmacen = _LogicLayer.GetProductos();
            List<DataAlmacen> ProductosBodega = _LogicLayer.GetProductosBodega();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            int i = 0;
            foreach (DataAlmacen Producto in ProductosAlmacen.ToArray())
            {
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                if (ProductosAlmacen[j].IdProducto == ProductosBodega[j].IdProducto)
                    ProductosAlmacen[j].Cantidad += ProductosBodega[j].Cantidad;
            }
            dataGridView1.DataSource = ProductosAlmacen;
        }
        public void GetIdNMB(string Id)
        {
            TxtId.Text = Id;

        }
        #endregion
        #region Eventos

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Agregar") // Si se selecciona el hipervinculo "confirmar"
            {
                AddOrden Orden = new AddOrden();
                Orden.LoadData(new DataAlmacen
                {
                    IdNMB = TxtId.Text,
                    IdProducto = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Nombre = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    Programa = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Cantidad = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()),
                }); // Carga de datos de los cuadros de texto
                Orden.ShowDialog(this);
                GetProductos();
            }
            else
            {

            }
        }
        #endregion
    }
}
