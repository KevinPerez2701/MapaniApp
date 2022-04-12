using System;
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
        #region Funciones
        public void LoadData(DataAlmacen Orden)
        {
            if (Orden != null)
            {
                TxtIdNMB.Text = Orden.IdNMB.ToString();
                TxtIdNMB.ReadOnly = true;
                TxtNombre.Text = Orden.Nombre;
                TxtNombre.ReadOnly = true;
                TxtIdProducto.Text = Orden.IdProducto.ToString();
                TxtIdProducto.ReadOnly = true;
                TxtPrograma.Text = Orden.Programa;
                TxtPrograma.ReadOnly = true;
                txtCantidadDisponible.Text = Orden.Cantidad.ToString();
                txtCantidadDisponible.ReadOnly = true;
            }
        }
        private void SaveOrder()
        {  if (TxtCantidad.Text != "" && ComboPediatra.Text != "")
            {
                if (int.Parse(TxtCantidad.Text) <= int.Parse(txtCantidadDisponible.Text))
                {
                    DataAlmacen Orden = new DataAlmacen
                    {
                        IdNMB = TxtIdNMB.Text,
                        IdProducto = int.Parse(TxtIdProducto.Text),
                        Nombre = TxtNombre.Text,
                        Programa = TxtPrograma.Text,
                        Pediatra = ComboPediatra.Text,
                        Fecha = dateTimePicker1.Value.Date,
                        Cantidad = int.Parse(TxtCantidad.Text),
                    };
                    _LogicLayer.SaveOrder(Orden);

                }
                else
                {
                    MessageBox.Show("Ingrese una Cantidad Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los Datos Solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        #endregion
        #region Botones
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddOrden_Click(object sender, EventArgs e)
        {
            SaveOrder();
            this.Close();
        }
        #endregion

    }
}
