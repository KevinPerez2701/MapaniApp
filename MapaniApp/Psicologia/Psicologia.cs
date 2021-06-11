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
    public partial class Psicologia : Form
    {
        LogicLayer _LogicLayer = new LogicLayer();
        public Psicologia()
        {
            InitializeComponent();
        }

        private void Psicologia_Load(object sender, EventArgs e)
        {

        }
        public void PopulateContacts(string SearchText = null)
        {
            List<ContactCuidador> contacts = _LogicLayer.GetCuidadores(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadContact(TxtID.Text);
            PopulateContacts(TxtID.Text);
        }
        
        public void LoadContact(string ID)
        {
            List<ContactNMB> contacts = _LogicLayer.GetContacts(ID);
            TxtNombre.Text = contacts[0].Nombre;
            TxtApellido.Text = contacts[0].Apellido;
            txtEscolaridad.Text = contacts[0].Escolaridad;
            txtEscuela.Text = contacts[0].NombreEscuela;
            dateTimeFechaNacimiento.Value = contacts[0].FechaNacimiento;
            txtEdad.Text = Metodos.GetEdadAnhos(contacts[0].FechaNacimiento);
        }

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
    }
}
