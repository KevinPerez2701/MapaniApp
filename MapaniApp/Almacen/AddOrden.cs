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
   
    public partial class AddOrden : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddOrden()
        {
            InitializeComponent();
        }

        private void AddOrden_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(DataAlmacen Orden)
        {
            if (Orden != null)
            {
                TxtIdNMB.Text = Orden.IdNMB.ToString();
                TxtNombre.Text = Orden.Nombre;
                TxtIdProducto.Text = Orden.IdProducto.ToString();
                TxtPrograma.Text = Orden.Programa;                
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddOrden_Click(object sender, EventArgs e)
        {
            SaveOrder();
            this.Close();
        }
        private void SaveOrder()
        {
            DataAlmacen Orden = new DataAlmacen{
                IdNMB = TxtIdNMB.Text,
                IdProducto =int.Parse(TxtIdProducto.Text),
                Nombre = TxtNombre.Text,
                Programa = TxtPrograma.Text,
                Pediatra = ComboPediatra.Text,
                Fecha = dateTimePicker1.Value.Date,
                Cantidad = int.Parse(TxtCantidad.Text),              
        };
            _LogicLayer.SaveOrder(Orden);
        }
    }
}
