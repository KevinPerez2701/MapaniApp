using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class AddProduct : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        string flag;
        string flagBodega;
        string flagAlmacen = "0";

        public AddProduct()
        {
            InitializeComponent();

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
        #region Botones
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == "0")
            {
                if (int.Parse(txtCantidadActual.Text) > int.Parse(TxtCantidad.Text))
                {
                    DataAlmacen Product = new DataAlmacen
                    {
                        IdProducto = int.Parse(TxtIdProducto.Text),
                        Cantidad = int.Parse(TxtCantidad.Text),
                    };
                    _LogicLayer.UpdateCantidad(Product);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese una Cantidad Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCantidad.Text = "0";

                }
            }

            else if (flag == "1")
            {
                SaveProductBodega();
                this.Close();
            }
            
           
        }
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            TxtIdProducto.ReadOnly = true;

            if (flag == "1")

            {   if (TxtIdProducto.Text == "" || TxtIdProducto.Text == null)
                {
                    TxtIdProducto.Text = (_LogicLayer.GetMaxIDBodega() + 1).ToString();
                    GroupAdd.Visible = true;
                    groupCantidad.Visible = true;
                }
                else if (int.Parse(TxtIdProducto.Text) > _LogicLayer.GetMaxIDBodega())
                {
                    MessageBox.Show("Ingrese un Id  Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtIdProducto.ReadOnly = false;
                    TxtIdProducto.Text = "";
                }
                
                else
                {
                    List<DataAlmacen> Productos = _LogicLayer.GetProductosBodega();
                    if (Productos.Count != 0)
                    {
                        foreach (DataAlmacen Producto in Productos.ToArray())
                        {
                            if (Producto.IdProducto == int.Parse(TxtIdProducto.Text))
                            {
                                GroupAdd.Visible = true;
                                groupCantidad.Visible = true;
                                TxtNombre.Text = Producto.Nombre;
                                TxtNombre.ReadOnly = true;
                                TxtLote.Text = Producto.Lote;
                                TxtLote.ReadOnly = true;
                                datetimeVencimiento.Value = Producto.FechaVencimiento;
                                datetimeVencimiento.Enabled = false;
                                TxtDescripcion.Text = Producto.Descripcion;
                                TxtDescripcion.ReadOnly = true;
                                comboPrograma.Text = Producto.Programa;
                                comboPrograma.Enabled = false;
                                txtCantidadActual.Text = Producto.Cantidad.ToString();
                                flagBodega = "1";
                            }

                        }
                    }

                
                }
            }
               
            else if (flag == "0")
            {
                if (TxtIdProducto.Text == "" || TxtIdProducto.Text == null)
                {
                    MessageBox.Show("Ingrese un Id  Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtIdProducto.ReadOnly = false;
                    TxtIdProducto.Text = "";
                }
                else if (int.Parse(TxtIdProducto.Text) > _LogicLayer.GetMaxIDBodega())
                {
                    MessageBox.Show("Ingrese un Id  Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtIdProducto.ReadOnly = false;
                    TxtIdProducto.Text = "";
                }
                else
                {                
                    List<DataAlmacen> Productos = _LogicLayer.GetProductos();
                    if (Productos.Count != 0)
                    {
                        foreach (DataAlmacen Producto in Productos.ToArray())
                        {
                            if (Producto.IdProducto == int.Parse(TxtIdProducto.Text))
                            {
                                GroupAdd.Visible = true;
                                groupCantidad.Visible = true;
                                TxtNombre.Text = Producto.Nombre;
                                TxtNombre.ReadOnly = true;
                                TxtLote.Text = Producto.Lote;
                                TxtLote.ReadOnly = true;
                                datetimeVencimiento.Value = Producto.FechaVencimiento;
                                datetimeVencimiento.Enabled = false;
                                txtCantidadAlmacen.Text = Producto.Cantidad.ToString();
                                txtCantidadAlmacen.ReadOnly = true;
                                TxtDescripcion.Text = Producto.Descripcion;
                                TxtDescripcion.ReadOnly = true;
                                comboPrograma.Text = Producto.Programa;
                                comboPrograma.Enabled = false;
                                flagAlmacen = "1";
                            }
                        }
                    }
                    List<DataAlmacen> ProductosBodega = _LogicLayer.GetProductosBodega();
                    foreach (DataAlmacen ProductoBodega in ProductosBodega.ToArray())
                    {
                        if (ProductoBodega.IdProducto == int.Parse(TxtIdProducto.Text))
                        {
                           
                            txtCantidadActual.Text = ProductoBodega.Cantidad.ToString();
                            
                        }
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
        #endregion
        #region Funciones
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
                Product.Cantidad = 0;
                _LogicLayer.SaveProduct(Product);
            }
        }

        #endregion

        private void TxtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
