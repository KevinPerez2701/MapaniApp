using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            this.Posicion();
            this.DialogResult = DialogResult.OK;
            CultureInfo current = Thread.CurrentThread.CurrentUICulture;
            if (current.TwoLetterISOLanguageName != "fr")
            {
                CultureInfo newCulture = CultureInfo.CreateSpecificCulture("en-US");
                Thread.CurrentThread.CurrentUICulture = newCulture;
                // Make current UI culture consistent with current culture.
                Thread.CurrentThread.CurrentCulture = newCulture;
            }
            Console.WriteLine("The current UI culture is {0} [{1}]",
                              Thread.CurrentThread.CurrentUICulture.NativeName,
                              Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine("The current culture is {0} [{1}]",
                              Thread.CurrentThread.CurrentUICulture.NativeName,
                              Thread.CurrentThread.CurrentUICulture.Name);
            this.Hide();
            
        }
        #endregion
       
        #region METODOS DE CLASE

        #endregion
        public List<MapaniUsers> Posicion()
        {
            int flag=0;
            List<MapaniUsers> ventana =_LogicLayer.Login(TxtUsuario.Text, TxtPassword.Text);
            ventana[0].Fecha = dateTimePicker1.Value.Date;
            ventana[0].HoraEntrada = DateTime.Now.ToString("hh:mm tt");
            List<MapaniUsers> Asistencia = _LogicLayer.GetAsistencia();
            foreach (MapaniUsers User in ventana)
            {
                foreach(MapaniUsers Cita in Asistencia)
                {
                    if (Cita.Fecha == User.Fecha && Cita.Id == User.Id)
                        flag = 1;                    
                }
            }
            if (flag!=1)
            _LogicLayer.Asistencia(ventana);
            return ventana;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
        }
    }
}
