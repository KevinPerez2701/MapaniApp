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
    public partial class GestionCasos : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public GestionCasos()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadContactCuidador(txtID.Text);
        }
        public void LoadContactCuidador(string ID)
        {
            List<ContactCuidador> Contacts = _LogicLayer.GetContactsCuidador(ID);
            ContactCuidador contact = Contacts[0];
            TxtNombre.Text = contact.Nombre;
            TxtApellido.Text = contact.Apellido;
            txtCedula.Text = contact.Cedula;
            dataGridView1.DataSource = _LogicLayer.GetHistorialAsesoria(ID);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void GestionCasos_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
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
        public void LimpiarCampos()
        {
            txtTipoAtencion.Text = "";
            txtTipoCaso.Text ="";
            txtSeguimiento.Text = "";
            txtEstatus.Text = "";
            txtObservacion.Text = "";
            txtEvolucion.Text = "";
            dateTimePicker1.Value = DateTime.Now ;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
