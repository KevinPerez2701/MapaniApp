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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProductos Productos = new VerProductos();
            Productos.GetProductos();
            Productos.ShowDialog(this);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddProduct NewProduct = new AddProduct();
            NewProduct.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntregaOrdenes Ordenes = new EntregaOrdenes();
            Ordenes.PopulateContacts();
            Ordenes.ShowDialog(this);
        }
    }
}
