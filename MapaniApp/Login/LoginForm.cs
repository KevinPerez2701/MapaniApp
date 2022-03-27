using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class LoginForm : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public LoginForm()
        {
            InitializeComponent();
        }
        #region EVENTOS
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.Exito() == true)
            {   
                    this.Posicion();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                
            }
            else
            {
                MessageBox.Show("Inicio de Sesion Invalido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
        }
        #endregion

        #region METODOS DE CLASE

        #endregion
        #region Funciones
        public bool Verificacion()
        {
            if (TxtUsuario.Text == "" || TxtUsuario.Text == null || TxtPassword.Text == "" || TxtPassword.Text == null)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
        public List<MapaniUsers> Posicion()
        {
            int flag = 0;

                List<MapaniUsers> ventana = _LogicLayer.Login(TxtUsuario.Text, TxtPassword.Text);
          
                ventana[0].Fecha = dateTimePicker1.Value.Date;
                ventana[0].HoraEntrada = DateTime.Now.ToString("hh:mm tt");
                List<MapaniUsers> Asistencia = _LogicLayer.GetAsistencia();
                foreach (MapaniUsers User in ventana)
                {
                    foreach (MapaniUsers Cita in Asistencia)
                    {
                        if (Cita.Fecha == User.Fecha && Cita.Id == User.Id)
                            flag = 1;
                    }
                }
                if (flag != 1)
                    _LogicLayer.Asistencia(ventana);
                return ventana;
            
           

        }
        public bool Exito()
        {
            List<MapaniUsers> ventana = _LogicLayer.Login(TxtUsuario.Text, TxtPassword.Text);
            if (ventana.Count != 0)
            {
                return true;
                    }
            else
            {
                return false;
            }
        }


        #endregion


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
