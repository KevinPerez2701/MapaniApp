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
        string flag;
        string flagBodega;
        string flagAlmacen;

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
        {   if (flag == "0")
                SaveProduct();
            else if (flag == "1")
                SaveProductBodega();
            else 
                this.Close();
            this.Close();
        }
        private void SaveProduct()
        {
          
            if (flagAlmacen == "1")
            {
               
                DataAlmacen Product = new DataAlmacen
                {
                    IdProducto = int.Parse(TxtIdProducto.Text),
                    Nombre = TxtNombre.Text,
                    Lote = TxtLote.Text,
                    FechaVencimiento = datetimeVencimiento.Value.Date,
                    Descripcion = TxtDescripcion.Text,
                    Programa = comboPrograma.Text,
                    Cantidad = int.Parse(TxtCantidad.Text),
                };
                _LogicLayer.UpdateCantidad(Product);
            }          
        }
        private void SaveProductBodega()
        {

            if (flagBodega == "1")
            {

                DataAlmacen Product = new DataAlmacen
                {
                    IdProducto = int.Parse(TxtIdProducto.Text),
                    Nombre = TxtNombre.Text,
                    Lote = TxtLote.Text,
                    FechaVencimiento = datetimeVencimiento.Value.Date,
                    Descripcion = TxtDescripcion.Text,
                    Programa = comboPrograma.Text,
                    Cantidad = int.Parse(TxtCantidad.Text),
                };
                _LogicLayer.UpdateCantidadBodega(Product);
            }
            else
            {
                DataAlmacen Product = new DataAlmacen
                {
                    Nombre = TxtNombre.Text,
                    Lote = TxtLote.Text,
                    FechaVencimiento = datetimeVencimiento.Value.Date,
                    Descripcion = TxtDescripcion.Text,
                    Programa = comboPrograma.Text,
                    Cantidad = int.Parse(TxtCantidad.Text),
                };

                _LogicLayer.SaveProductBodega(Product);
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {   if (flag == "1")
            {
                List<DataAlmacen> Productos = _LogicLayer.GetProductosBodega();
                foreach (DataAlmacen Producto in Productos.ToArray())
                {
                    if (Producto.IdProducto == int.Parse(TxtIdProducto.Text))
                    {
                        GroupAdd.Visible = true;
                        groupCantidad.Visible = true;
                        TxtNombre.Text = Producto.Nombre;
                        TxtLote.Text = Producto.Lote;
                        datetimeVencimiento.Value = Producto.FechaVencimiento;
                        TxtDescripcion.Text = Producto.Descripcion;
                        comboPrograma.Text = Producto.Programa;
                        flagBodega = "1";
                    }
                    else
                    {
                        GroupAdd.Visible = true;
                        groupCantidad.Visible = true;
                    }
                }
            }
            else if (flag == "0")
            {
                List<DataAlmacen> Productos = _LogicLayer.GetProductos();
                foreach (DataAlmacen Producto in Productos.ToArray())
                {
                    if (Producto.IdProducto == int.Parse(TxtIdProducto.Text))
                    {
                        GroupAdd.Visible = true;
                        groupCantidad.Visible = true;
                        TxtNombre.Text = Producto.Nombre;
                        TxtLote.Text = Producto.Lote;
                        datetimeVencimiento.Value = Producto.FechaVencimiento;
                        TxtDescripcion.Text = Producto.Descripcion;
                        comboPrograma.Text = Producto.Programa;
                        flagAlmacen = "1";
                    }
                    else
                    {
                        GroupAdd.Visible = true;
                        groupCantidad.Visible = true;
                    }
                }

            }
        }
        public void Bodega()
        {
            flag = "1";
        }
        public void almacen()
        {
            flag = "0";
        }
    }
}
