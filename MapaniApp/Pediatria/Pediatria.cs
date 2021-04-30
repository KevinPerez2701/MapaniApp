using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnthStat.Statistics;

namespace MapaniApp
{
    public partial class Pediatria : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        private ContactNMB _contactNMB = new ContactNMB();
        private ContactMMB _contactMMB = new ContactMMB();
        public Pediatria()
        {
            InitializeComponent();
        }

        private void BtnCargarContacto_Click(object sender, EventArgs e)
        {          
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                ContactNMB contact = contacts[0];
                LoadContact(contact);
            BtnAddOrder.Visible = true;
            
        }
        private void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                TxtEdad.Text = Metodos.GetEdad(contact.FechaNacimiento);
                TxtEdadMeses.Text = Metodos.GetEdadMeses(contact.FechaNacimiento);

            }
        }

        private void Pediatria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProductos NuevaOrden = new VerProductos();
            NuevaOrden.GetProductos();
            NuevaOrden.GetIdNMB(TxtID.Text);
            NuevaOrden.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            CalculateZScores();
        }
        public void CalculateZScores()
        {
            var who2006 = new AnthStat.Statistics.WHO2006();
            double ageDays = double.Parse(TxtEdad.Text);
            double Weight = double.Parse(TxtPeso.Text);
            double Lenght = double.Parse(TxtTalla.Text);
            double CC  = double.Parse(TxtCC.Text);
            double CMB = double.Parse(TxtCMB.Text);
            double Muac = double.Parse(TxtTricep.Text);
            double LenghtMeters = Lenght / 100;
            double imc = Weight / (LenghtMeters * LenghtMeters);
            double z = 0.0;
            double x = 0.0;
            double y = 0.0;
            double w = 0.0;
         
            if (who2006.TryCalculateZScore(indicator: Indicator.BodyMassIndexForAge, measurement1: imc, measurement2: ageDays, sex: Sex.Male, z: ref z))
            {
                TxtZIMC.Text = Math.Round(z, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(z);
                TxtImc.Text = Math.Round(p,1).ToString();
              
            }
            if (who2006.TryCalculateZScore(indicator: Indicator.WeightForLength, measurement1: Weight, measurement2: Lenght, sex: Sex.Male, z: ref x))
            {
                TxtZPesoTalla.Text = Math.Round(x, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(x);
                TxtPesoTalla.Text = Math.Round(p,1).ToString();
                
            }
            if (who2006.TryCalculateZScore(indicator: Indicator.WeightForAge, measurement1: Weight, measurement2: ageDays, sex: Sex.Male, z: ref y))
            {
                TxtZPesoEdad.Text = Math.Round(y, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(y);
                TxtPesoEdad.Text = Math.Round(p,1).ToString();
                
            }
            if (who2006.TryCalculateZScore(indicator: Indicator.LengthForAge, measurement1: Lenght, measurement2: ageDays, sex: Sex.Male, z: ref w))
            {
                TxtZTallaEdad.Text = Math.Round(w, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(w);
                TxtTallaEdad.Text = Math.Round(p,1).ToString();
            }
            if (who2006.TryCalculateZScore(indicator: Indicator.HeadCircumferenceForAge, measurement1: CC, measurement2: ageDays, sex: Sex.Male, z: ref w))
            {
                TxtZCC.Text = Math.Round(w, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(w);
                TxtCCP.Text = Math.Round(p, 1).ToString();
            }
            if (who2006.TryCalculateZScore(indicator: Indicator.ArmCircumferenceForAge, measurement1: CMB, measurement2: ageDays, sex: Sex.Male, z: ref w))
            {
                TxtZMuac.Text = Math.Round(w, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(w);
                TxtMuacP.Text = Math.Round(p, 1).ToString();
            }
            if (who2006.TryCalculateZScore(indicator: Indicator.TricepsSkinfoldForAge, measurement1: double.Parse(TxtTricep.Text), measurement2: ageDays, sex: Sex.Male, z: ref w))
            {
                TxtTSFZ.Text = Math.Round(w, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(w);
                TxtTSFP.Text = Math.Round(p, 1).ToString();
            }
            if (who2006.TryCalculateZScore(indicator: Indicator.SubscapularSkinfoldForAge, measurement1: double.Parse(TxtSSF.Text), measurement2: ageDays, sex: Sex.Male, z: ref w))
            {
                TxtSSFZ.Text = Math.Round(w, 2).ToString();
                double p = StatisticsHelper.CalculatePercentile(w);
                TxtSSFP.Text = Math.Round(p, 1).ToString();
            }



        }

        
    }
}
