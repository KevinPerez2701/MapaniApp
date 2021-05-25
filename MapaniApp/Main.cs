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
    public partial class Main : Form
    {
        List<MapaniUsers> ventana;
        private LogicLayer _LogicLayer;
        public Main()
        {
            InitializeComponent();
            _LogicLayer = new LogicLayer();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog(this);
            ventana = login.Posicion();
           
            if (ventana[0].Posicion == "SuperUser")
            {
                groupSuperUser.Visible = true;
            }
            else if (ventana[0].Posicion == "Recepcion")
            {
                Recepcion recepcion = new Recepcion();
                recepcion.ShowDialog(this);
            }
            else if (ventana[0].Posicion == "Transcripcion")
            {
                Transcripcion transcripcion = new Transcripcion();
                transcripcion.ShowDialog(this);
            }
            else if (ventana[0].Posicion == "Enfermeria")
            {
                Enfermeria enfermeria = new Enfermeria();
                enfermeria.Show(this);
            }


        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContact NewContact = new AddContact();
            NewContact.ShowDialog(this);
        }

        #region APERTURA DE NUEVAS VENTANAS
        private void button1_Click_1(object sender, EventArgs e)
        {
            Transcripcion transcripcion = new Transcripcion();
            transcripcion.ShowDialog(this);
        }
        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.ShowDialog(this);
        }

        private void BtnNutricion_Click(object sender, EventArgs e)
        {
            Nutricion nutricion = new Nutricion();
            nutricion.ShowDialog(this);
        }

        private void BtnPsicologia_Click(object sender, EventArgs e)
        {
            Psicologia psicologia = new Psicologia();
            psicologia.ShowDialog(this);
        }

        private void BtnEnfermeria_Click(object sender, EventArgs e)
        {
            Enfermeria enfermeria = new Enfermeria();
            enfermeria.ShowDialog(this);
        }

        private void BtnPediatria_Click(object sender, EventArgs e)
        {
            Pediatria pediatria = new Pediatria();
            pediatria.ShowDialog(this);
        }

        private void BtnLegal_Click(object sender, EventArgs e)
        {
            AsesoriaJuridica legal = new AsesoriaJuridica();
            legal.ShowDialog(this);
        }

        private void BtnRecepcion_Click(object sender, EventArgs e)
        {
            Recepcion recepcion = new Recepcion();
            recepcion.ShowDialog(this);
        }

        #endregion

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Salida();
            this.Close();
        }
        private void Salida()
        {
            ventana[0].HoraSalida = DateTime.Now.ToString("hh:mm tt");
            _LogicLayer.Salida(ventana);
        }
        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            Asistencia VerAsistencia = new Asistencia();
            VerAsistencia.ShowDialog(this);
        }
    }
}
