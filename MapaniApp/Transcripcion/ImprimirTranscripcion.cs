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
    public partial class ImprimirTranscripcion : Form
    {
       
        private ContactNMB _contactNMB = new ContactNMB();
        private ContactCuidador _contactCuidador = new ContactCuidador();
        private LogicLayer _LogicLayer = new LogicLayer();
        public ImprimirTranscripcion()
        {
            InitializeComponent();
        }

        private void ImprimirTranscripcion_Load(object sender, EventArgs e)
        {

        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y,0,0,this.Size);
            printPreviewDialog1.ShowDialog();

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {
                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                FechaNacimientoNMB.Value = contact.FechaNacimiento.Date;
                Fecha.Value = contact.FechaIngreso.Date;
                TxtGenero.Text = contact.Sexo;
                txtDiscapacidad.Text = contact.Discapacidad;
                txtIdNMB.Text = Convert.ToString(contact.Id);
                txtPartidaNacimiento.Text = contact.PartidaNacimiento;
                txtTipoIngreso.Text = contact.Ingreso;
                txtDireccion.Text = contact.Direccion;
                txtParroquia.Text = contact.Parroquia;
                txtMunicipio.Text = contact.Municipio;
                txtEstado.Text = contact.Estado;

            }
        }

            public void LoadContactCuidador(ContactCuidador contact)
            {
                _contactCuidador = contact;
                if (contact != null)
                {

                txtNombreCuidador.Text = contact.Nombre;
                txtApellidoCuidador.Text = contact.Apellido;
                txtGeneroCuidador.Text = contact.Sexo;
                txtCedula.Text = contact.Cedula;
                dateTimePicker2.Value = contact.FechaNacimiento.Date;
                txtEstadoCivil.Text = contact.EstadoCivil;
                txtTelefono.Text = contact.Telefono;
                    
                }


            }


     }
}

