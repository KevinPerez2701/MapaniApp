using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class Asistencia : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public Asistencia()
        {
            InitializeComponent();
        }
        #region Botones
        private void button1_Click(object sender, EventArgs e)
        {
            ShowAsistencia(dateTimePicker1.Value.Date);
        }
        #endregion
        #region Funciones
        public void ShowAsistencia(DateTime Fecha)
        {
            List<MapaniUsers> Asistencia = _LogicLayer.ShowAsistencia(Fecha);
            dataGridView1.DataSource = Asistencia;
        }
        #endregion
        private void Asistencia_Load(object sender, EventArgs e)
        {

        }


    }
}
