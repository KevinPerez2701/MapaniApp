using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class GestionCasos : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public GestionCasos()
        {
            InitializeComponent();
        }

        private void GestionCasos_Load(object sender, EventArgs e)
        {

        }
        #region Botones
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadContactCuidador(txtID.Text);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion
        #region Funciones
        public void LoadContactCuidador(string ID)
        {
            List<ContactCuidador> Contacts = _LogicLayer.GetContactsCuidador(ID);
            ContactCuidador contact = Contacts[0];
            TxtNombre.Text = contact.Nombre;
            TxtApellido.Text = contact.Apellido;
            txtCedula.Text = contact.Cedula;
            dataGridView1.DataSource = _LogicLayer.GetHistorialAsesoria(ID);
        }
        public void SaveData()
        {
            ContactAsesoria contact = new ContactAsesoria
            {
                IdCuidador = int.Parse(txtID.Text),
                Fecha = dateTimePicker1.Value,
                TipoAtencion = txtTipoAtencion.Text,
                TipoCaso = txtTipoCaso.Text,
                Seguimiento = txtSeguimiento.Text,
                Observacion = txtObservacion.Text,
                Evolucion = txtEvolucion.Text,
                Estatus = txtEstatus.Text,
            };
            _LogicLayer.InsertCitaAsesoria(contact);
        }
        public void LimpiarCampos()
        {
            txtTipoAtencion.Text = "";
            txtTipoCaso.Text = "";
            txtSeguimiento.Text = "";
            txtEstatus.Text = "";
            txtObservacion.Text = "";
            txtEvolucion.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        #endregion
        #region Eventos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Ver") // Si se selecciona el hipervinculo "confirmar"
            {

                txtTipoAtencion.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTipoCaso.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSeguimiento.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtObservacion.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEvolucion.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

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
    }
}
