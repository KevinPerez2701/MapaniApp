using System;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class EvolutivoPediatria : Form
    {
        ClaseEnfermeria Pediatria = new ClaseEnfermeria();
        int flag;
        private LogicLayer _LogicLayer = new LogicLayer();
        public EvolutivoPediatria()
        {
            InitializeComponent();
        }

        private void EvolutivoPediatria_Load(object sender, EventArgs e)
        {

        }

        #region Funciones
        public void Data(ClaseEnfermeria Data)
        {
            txtEvolutivo.Text = Data.Observacion;
            txtAntecedentes.Text = Data.Antecedentes;
            txtPatologias.Text = Data.Patologia;
        }

        public void GetCita(ClaseEnfermeria Cita)
        {
            Pediatria = Cita;
        }
        public void GetCitaNutricion(ClaseEnfermeria Cita)
        {
            Pediatria = Cita;
            flag = 1;
        }
        public void HideButton()
        {
            BtnSave.Visible = false;
            txtAntecedentes.ReadOnly = true;
            txtPatologias.ReadOnly = true;
            txtEvolutivo.ReadOnly = true;
        }
        #endregion
        #region Botones
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pediatria.Antecedentes = txtAntecedentes.Text;
            Pediatria.Patologia = txtPatologias.Text;
            Pediatria.Observacion = txtEvolutivo.Text;
            if (flag == 1)
                _LogicLayer.InsertCitaNutricion(Pediatria);
            else
                _LogicLayer.InsertCitaPediatria(Pediatria);
            this.Close();
        }
        #endregion
        
      
    }
}
