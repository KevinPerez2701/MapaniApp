using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class Citas : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public Citas()
        {
            InitializeComponent();

        }
        private void Citas_Load(object sender, EventArgs e)
        {

        }
        #region Botones
        private void button1_Click(object sender, EventArgs e)
        {
            List<MapaniUsers> Asistencias = _LogicLayer.GetAsistencia();
            List<ProximasVisitas> Citas = _LogicLayer.GetCitas(dateTimePicker1.Value.Date);
            foreach (ProximasVisitas Cita in Citas)
            {
                foreach (MapaniUsers Asistencia in Asistencias)
                    if (Cita.Rol == Asistencia.Rol && Cita.Fecha == Asistencia.Fecha)
                    {
                        Cita.Activo = "Si";
                    }
            }
            dataGridView1.DataSource = Citas;
            dataGridView1.Visible = true;


        }
        #endregion       
    }
}
