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
    public partial class EvaluacionInicial : Form
    {
        LogicLayer _LogicLayer = new LogicLayer();
        public EvaluacionInicial()
        {
            InitializeComponent();
        }

       

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavedataList();
            this.Close();


        }
        public void SavedataList()
        {
            string EvaluacionInicial = string.Empty;
            foreach (object item in checkedListBox1.CheckedItems)
            {
                EvaluacionInicial += item.ToString() + ",";
            }
            ContactPsicologia Contact = new ContactPsicologia
            {
                Antecedentes = txtAntecedentes.Text,
                SistemaFamiliar = txtSistemaAuxiliar.Text,
                Evaluacion = txtEvaluacion.Text,
                MotivoConsulta = TxtMotivoConsulta.Text,
                EvaluacionInicial = EvaluacionInicial,
                RazonAlta = txtRiesgoAlto.Text,
                RazonMedia = txtRiesgoMedio.Text,
                RazonBajo = txtRiesgoBajo.Text,
                NoRazon = txtSinRiesgo.Text,
            };
            _LogicLayer.InsertarEvaluacionInicial(Contact);
        }

    
    }
}
