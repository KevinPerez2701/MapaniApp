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
    public partial class Asistencia : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public Asistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAsistencia(dateTimePicker1.Value.Date);
        }

        public void ShowAsistencia(DateTime Fecha)
        {
            List<MapaniUsers> Asistencia = _LogicLayer.ShowAsistencia(Fecha);
            dataGridView1.DataSource = Asistencia;
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {

        }
    }
}
