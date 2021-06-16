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
        string Id;
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
                IdNMB = Id,
            };
            _LogicLayer.InsertarEvaluacionInicial(Contact);
        }
        public void LoadContact(string ID, string Historia)
        {
            Id = ID;
            if (Historia == "Si")
            {
                guardarToolStripMenuItem.Visible = false;
                LoadHistorial(ID);
                txtEvaluacionInicial.Visible = true;
                checkedListBox1.Visible = false;
            }
           

        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EvaluacionInicial_Load(object sender, EventArgs e)
        {

        }
        public void LoadHistorial(string ID)
        {
            ContactPsicologia contact = _LogicLayer.GetEvaluacionPsicologia(ID);

            txtRiesgoAlto.Text = contact.RazonAlta;
            txtRiesgoBajo.Text = contact.RazonBajo;
            txtRiesgoMedio.Text = contact.RazonMedia;
            txtSinRiesgo.Text = contact.NoRazon;
            txtSistemaAuxiliar.Text = contact.SistemaFamiliar;
            txtAntecedentes.Text = contact.Antecedentes;
            txtEvaluacion.Text = contact.Evaluacion;
            TxtMotivoConsulta.Text = contact.MotivoConsulta;
            txtEvaluacionInicial.Text = contact.EvaluacionInicial;

        }
    }
}
