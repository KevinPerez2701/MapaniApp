using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class Psicologia : Form
    {
        string HistoriaPsicologia;
        LogicLayer _LogicLayer = new LogicLayer();
        public Psicologia()
        {
            InitializeComponent();
        }

        private void Psicologia_Load(object sender, EventArgs e)
        {

        }
        #region Funciones
        public void PopulateContacts(string SearchText = null)
        {
            List<ContactCuidador> contacts = _LogicLayer.GetCuidadores(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }
        public void LoadContact(string ID)
        {
            List<ContactNMB> contacts = _LogicLayer.GetContacts(ID);
            if (contacts.Count != 0)
            {
                TxtNombre.Text = contacts[0].Nombre;
                TxtApellido.Text = contacts[0].Apellido;
                txtEscolaridad.Text = contacts[0].Escolaridad;
                txtEscuela.Text = contacts[0].NombreEscuela;
                dateTimeFechaNacimiento.Value = contacts[0].FechaNacimiento;
                txtEdad.Text = Metodos.ObtenerEdad(contacts[0].FechaNacimiento);
                HistoriaPsicologia = contacts[0].Psicologia;
                List<ContactPsicologia> Lista = _LogicLayer.GetHistorialPsicologia(ID);
                dataGridView1.DataSource = Lista;
            }
            else
            {
                MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        public void SaveCitaPsicologia()
        {
            ContactPsicologia contact = new ContactPsicologia
            {
                RazonCuidado = txtRazonCuidado.Text,
                RazonSalud = txtRazonSalud.Text,
                RazonSeguridad = txtRazonSeguridad.Text,
                RazonOtro = txtRazonOtro.Text,
                NoRazon = txtNoRazon.Text,
                AccionSalud = txtAccionSalud.Text,
                AccionCuidado = txtCuidadoProvisional.Text,
                AccionSeguridad = txtAccionSeguridad.Text,
                AccionOtro = txtAccionOtra.Text,
                NoAccion = txtNoAccion.Text,
                Seguimiento = txtSeguimiento.Text,
                Fecha = dateTimePicker1.Value,
                IdNMB = TxtID.Text,
            };
            _LogicLayer.InsertCitaPsicologia(contact);
        }
        #endregion
        #region Botones
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonCuidado.Text = string.Empty;
            txtRazonSalud.Text = string.Empty;
            txtRazonSeguridad.Text = string.Empty;
            txtRazonOtro.Text = string.Empty;
            txtNoRazon.Text = string.Empty;
            txtAccionSalud.Text = string.Empty;
            txtCuidadoProvisional.Text = string.Empty;
            txtAccionSeguridad.Text = string.Empty;
            txtAccionOtra.Text = string.Empty;
            txtNoAccion.Text = string.Empty;
            txtSeguimiento.Text = string.Empty;
        }
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadContact(TxtID.Text);
            PopulateContacts(TxtID.Text);
            button1.Visible = true;

        }
        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            SaveCitaPsicologia();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EvaluacionInicial evaluacion = new EvaluacionInicial();
            evaluacion.LoadContact(TxtID.Text, HistoriaPsicologia);
            evaluacion.ShowDialog(this);
        }

        #endregion
        #region Eventos
        private void dataGridRelaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridRelaciones.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Ver") // Si se selecciona el hipervinculo "confirmar"
            {
                ContactosCuidadores Contactos = new ContactosCuidadores();
                Contactos.PopulateContactsAsesoria(dataGridRelaciones.Rows[e.RowIndex].Cells[0].Value.ToString());
                Contactos.ShowDialog(this);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Ver") // Si se selecciona el hipervinculo "confirmar"
            {

                txtRazonCuidado.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtRazonSalud.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRazonSeguridad.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRazonOtro.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtNoRazon.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtAccionSalud.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtAccionSeguridad.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtAccionOtra.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtNoAccion.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtCuidadoProvisional.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtSeguimiento.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[13].Value;

            }
        }
        #endregion
        #region Validacion de Datos
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
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
