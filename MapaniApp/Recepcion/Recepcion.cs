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
    public partial class Recepcion : Form
    {
        private ContactMMB _contactMMB = new ContactMMB();
        private ContactCuidador _contactCuidador = new ContactCuidador();
        private ContactNMB _contactNMB = new ContactNMB();
        private LogicLayer _LogicLayer = new LogicLayer();
        public Recepcion()
        {
            InitializeComponent();
        }
        #region RECARGA DE DATOS 
        /// <summary>
        /// Recarga los datos de la Grilla de Relaciones NMB, recibe por parametro el ID
        /// </summary>
        /// <param name="SearchText"></param>
        public void PopulateContacts(string SearchText = null)
        {
            dataGridRelaciones.DataSource = null;
            List<ContactCuidador> contacts = _LogicLayer.GetCuidadores(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }
        /// <summary>
        /// Idem Pero con NMB
        /// </summary>
        /// <param name="SearchText"></param>
        public void PopulateContactsNMB(string SearchText = null)
        {
            dataGridRelaciones.DataSource = null;
            List<ContactNMB> contacts = _LogicLayer.GetNMB(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }
        /// <summary>
        /// Idem pero con MMB
        /// </summary>
        /// <param name="SearchText"></param>
        public void PopulateContactsMMB(string SearchText = null)
        {
            dataGridRelaciones.DataSource = null;
            List<ContactMMB> contacts = _LogicLayer.GetMMB(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }
        /// <summary>
        /// Recibe por parametro el ID y busca en las tablas de datos y recarga la grilla de visitas y proximas visitas
        /// </summary>
        /// <param name="SearchText"></param>
        public void PopulateContactsVisita(string SearchText = null)
        {
            dataGridHistorial.DataSource = null;
            dataGridProximasVisitas.DataSource = null;
            List<HistorialVisitas> Historial = _LogicLayer.GetHistorial(SearchText);
            dataGridHistorial.DataSource = Historial;
            List<ProximasVisitas> Proximas = _LogicLayer.GetProximas(SearchText);
            List<MapaniUsers> Asistencias = _LogicLayer.GetAsistencia();           
            foreach (ProximasVisitas Cita in Proximas)
            {
                foreach (MapaniUsers Asistencia in Asistencias)
                    if (Cita.Rol == Asistencia.Rol && Cita.Fecha == Asistencia.Fecha)
                    {
                        Cita.Activo = "Si";
                    }
            }
            dataGridProximasVisitas.DataSource = Proximas;
        }
        #endregion
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (ComboUsuario.Text == "NMB")
            {
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text); //Busca el contacto con el primary key Id
                ContactNMB contact = contacts[0]; // Devuelve el valor unico de la lista en este caso
                LoadContact(contact); //Carga los datos en los cuadros de texto
                PopulateContacts(TxtID.Text); //Refresca las relaciones de cuidadores del NMB
                PopulateContactsVisita(TxtID.Text); // Refresca las tablas Historial y Proximas visitas del NMB
            }
            else if (ComboUsuario.Text == "Cuidador")
            {
                List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtID.Text);
                ContactCuidador contact = contacts[0];
                LoadContactCuidador(contact);
                PopulateContactsNMB(TxtID.Text);
            }
            else if (ComboUsuario.Text == "MMB")
            {
                List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtID.Text);
                ContactMMB contact = contacts[0];
                LoadContactMMB(contact);
                PopulateContactsMMB(TxtID.Text);
            }
        }
        #region FUNCIONES DE CARGA DE CONTACTOS
        /// <summary>
        /// Se encarga de recibir el contacto de la base de datos con el ID de NMB y cargarlo a los textbox
        /// </summary>
        /// <param name="contact"></param>
        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                TxtDireccion.Text = contact.Direccion;
                pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }
        /// <summary>
        /// Idem pero con IdCuidador
        /// </summary>
        /// <param name="contact"></param>
        public void LoadContactCuidador(ContactCuidador contact)
        {
            _contactCuidador = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                TxtDireccion.Text = contact.Direccion;
                pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }
        /// <summary>
        /// Idem Pero con Id MMB
        /// </summary>
        /// <param name="contact"></param>
        public void LoadContactMMB(ContactMMB contact)
        {
            _contactMMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                TxtDireccion.Text = contact.Direccion;
                pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }
        #endregion

        private void Recepcion_Load(object sender, EventArgs e)
        {
           //Hello wordl
        }


        private void BtnCitas_Click(object sender, EventArgs e)
        {
            Citas Cita = new Citas();
            Cita.ShowDialog(this);
        }

        private void BtnAgregarCita_Click(object sender, EventArgs e)
        {
            AgregarCita NuevaCita = new AgregarCita();
            NuevaCita.LoadData(TxtID.Text);
            NuevaCita.ShowDialog(this);
            PopulateContacts(TxtID.Text); //Refresca las relaciones de cuidadores del NMB
            PopulateContactsVisita(TxtID.Text);
        }

        private void dataGridProximasVisitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridProximasVisitas.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Confirmar") // Si se selecciona el hipervinculo "confirmar"
            {
                ConfirmarCita Confirm = new ConfirmarCita();
                Confirm.LoadData(new HistorialVisitas
                {
                    IdNMB= int.Parse(dataGridProximasVisitas.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Departamento = (dataGridProximasVisitas.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Fecha =(DateTime)dataGridProximasVisitas.Rows[e.RowIndex].Cells[1].Value
                }); // Carga de datos de los cuadros de texto
                Confirm.ShowDialog(this);
                PopulateContacts(TxtID.Text); //Refresca las relaciones de cuidadores del NMB
                PopulateContactsVisita(TxtID.Text);
            }    
        }

        private void dataGridHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridHistorial.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Ver") // Si se selecciona el hipervinculo "confirmar"
            {
                EntregaOrdenes VerOrdenes = new EntregaOrdenes();
                VerOrdenes.GetHistorial(new DataAlmacen
                {
                    IdNMB = TxtID.Text,
                    Fecha = (DateTime)dataGridHistorial.Rows[e.RowIndex].Cells[1].Value,
                });
                VerOrdenes.ShowDialog(this);
            }
        }

        private void dataGridRelaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
