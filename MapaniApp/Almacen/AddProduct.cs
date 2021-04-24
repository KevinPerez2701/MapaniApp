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
    public partial class AddProduct : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveProduct();
            this.Close();
        }
        private void SaveProduct()
        {
            DataAlmacen Product = new DataAlmacen
            {   IdProducto =int.Parse(TxtIdProducto.Text),
                Nombre = TxtNombre.Text,
                Lote = TxtLote.Text,
                FechaVencimiento = datetimeVencimiento.Value.Date,
                Descripcion = TxtDescripcion.Text,
                Programa = comboPrograma.Text,
                Cantidad = int.Parse(TxtCantidad.Text),
            };
            _LogicLayer.SaveProduct(Product);
        }
    }
}
