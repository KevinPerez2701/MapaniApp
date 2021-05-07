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
            this.Hide();
        }
        #endregion

        #region METODOS DE CLASE

        #endregion
        public List<MapaniUsers> Posicion()
        {
            List<MapaniUsers> ventana =_LogicLayer.Login(TxtUsuario.Text, TxtPassword.Text);
            ventana[0].Fecha = dateTimePicker1.Value.Date;
            ventana[0].Asistencia = "Si";
            return ventana;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
