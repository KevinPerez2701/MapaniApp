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
                GetDataEnfermeria();
            
        }
        private void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                TxtEdad.Text = Metodos.GetEdad(contact.FechaNacimiento,dateTimePicker2.Value);
                TxtEdadMeses.Text = Metodos.GetEdadMeses(contact.FechaNacimiento, dateTimePicker2.Value);
                txtSexo.Text = contact.Sexo;

            }
        }

        private void Pediatria_Load(object sender, EventArgs e)
        {

        }
        public void GetDataEnfermeria()
        {
            List<ClaseEnfermeria> Data = _LogicLayer.GetDataEnfermeria(TxtID.Text,dateTimePicker2.Value.Date);
            ClaseEnfermeria Datos = Data[0];
            TxtPeso.Text = Datos.Peso;
            TxtTalla.Text = Datos.Talla;
            TxtCMB.Text = Datos.CMB;
            txtHb.Text = Datos.Hb.ToString();
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
            if (float.Parse(TxtEdad.Text) > 1825)
            {
                CalculateZScoresWho2007();
                DiagnosticosWho2007();
                DiagnosticoTalla2007();
            }
            else if (float.Parse(TxtEdad.Text) > 0 && float.Parse(TxtEdad.Text) <1825)
            {
                CalculateZScoresWho2006();
                DiagnosticosWho2006();
                DiagnosticoTalla();
            }
        }
        public void CalculateZScoresWho2006()
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
            TxtIMCCalculado.Text = Math.Round(imc,2).ToString();
            double z = 0.0;
            double x = 0.0;
            double y = 0.0;
            double w = 0.0;
            if (txtSexo.Text == "Masculino\t")
            {
                if (who2006.TryCalculateZScore(indicator: Indicator.BodyMassIndexForAge, measurement1: imc, measurement2: ageDays, sex: Sex.Male, z: ref z))
                {
                    TxtZIMC.Text = Math.Round(z, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(z);
                    TxtImc.Text = Math.Round(p, 1).ToString();

                }
                if (who2006.TryCalculateZScore(indicator: Indicator.WeightForLength, measurement1: Weight, measurement2: Lenght, sex: Sex.Male, z: ref x))
                {
                    TxtZPesoTalla.Text = Math.Round(x, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(x);
                    TxtPesoTalla.Text = Math.Round(p, 1).ToString();

                }
                if (who2006.TryCalculateZScore(indicator: Indicator.WeightForAge, measurement1: Weight, measurement2: ageDays, sex: Sex.Male, z: ref y))
                {
                    TxtZPesoEdad.Text = Math.Round(y, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(y);
                    TxtPesoEdad.Text = Math.Round(p, 1).ToString();

                }
                if (who2006.TryCalculateZScore(indicator: Indicator.LengthForAge, measurement1: Lenght, measurement2: ageDays, sex: Sex.Male, z: ref w))
                {
                    TxtZTallaEdad.Text = Math.Round(w, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(w);
                    TxtTallaEdad.Text = Math.Round(p, 1).ToString();
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
            else if (txtSexo.Text == "Femenino\t")
            {
                if (who2006.TryCalculateZScore(indicator: Indicator.BodyMassIndexForAge, measurement1: imc, measurement2: ageDays, sex: Sex.Female, z: ref z))
                {
                    TxtZIMC.Text = Math.Round(z, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(z);
                    TxtImc.Text = Math.Round(p, 1).ToString();

                }
                if (who2006.TryCalculateZScore(indicator: Indicator.WeightForLength, measurement1: Weight, measurement2: Lenght, sex: Sex.Female, z: ref x))
                {
                    TxtZPesoTalla.Text = Math.Round(x, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(x);
                    TxtPesoTalla.Text = Math.Round(p, 1).ToString();

                }
                if (who2006.TryCalculateZScore(indicator: Indicator.WeightForAge, measurement1: Weight, measurement2: ageDays, sex: Sex.Female, z: ref y))
                {
                    TxtZPesoEdad.Text = Math.Round(y, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(y);
                    TxtPesoEdad.Text = Math.Round(p, 1).ToString();

                }
                if (who2006.TryCalculateZScore(indicator: Indicator.LengthForAge, measurement1: Lenght, measurement2: ageDays, sex: Sex.Female, z: ref w))
                {
                    TxtZTallaEdad.Text = Math.Round(w, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(w);
                    TxtTallaEdad.Text = Math.Round(p, 1).ToString();
                }
                if (who2006.TryCalculateZScore(indicator: Indicator.HeadCircumferenceForAge, measurement1: CC, measurement2: ageDays, sex: Sex.Female, z: ref w))
                {
                    TxtZCC.Text = Math.Round(w, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(w);
                    TxtCCP.Text = Math.Round(p, 1).ToString();
                }
                if (who2006.TryCalculateZScore(indicator: Indicator.ArmCircumferenceForAge, measurement1: CMB, measurement2: ageDays, sex: Sex.Female, z: ref w))
                {
                    TxtZMuac.Text = Math.Round(w, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(w);
                    TxtMuacP.Text = Math.Round(p, 1).ToString();
                }
                if (who2006.TryCalculateZScore(indicator: Indicator.TricepsSkinfoldForAge, measurement1: double.Parse(TxtTricep.Text), measurement2: ageDays, sex: Sex.Female, z: ref w))
                {
                    TxtTSFZ.Text = Math.Round(w, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(w);
                    TxtTSFP.Text = Math.Round(p, 1).ToString();
                }
                if (who2006.TryCalculateZScore(indicator: Indicator.SubscapularSkinfoldForAge, measurement1: double.Parse(TxtSSF.Text), measurement2: ageDays, sex: Sex.Female, z: ref w))
                {
                    TxtSSFZ.Text = Math.Round(w, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(w);
                    TxtSSFP.Text = Math.Round(p, 1).ToString();
                }
            }

        }
        public void DiagnosticoTalla()
        {
            if (float.Parse(TxtZTallaEdad.Text) > 2)
                TxtDiagnosticoTalla.Text = "Alta";
            else if (float.Parse(TxtZTallaEdad.Text) > -2 && float.Parse(TxtZTallaEdad.Text) < 2)
                TxtDiagnosticoTalla.Text = "Normal";
            else if (float.Parse(TxtZTallaEdad.Text) < -2)
                TxtDiagnosticoTalla.Text = "Baja";
            else
                TxtDiagnosticoTalla.Text = "Error";

        }
        public void DiagnosticoTalla2007()
        {
            if (float.Parse(TxtTallaEdadWho2007Z.Text) > 2)
                TxtDiagnosticoTalla.Text = "Alta";
            else if (float.Parse(TxtTallaEdadWho2007Z.Text) > -2 && float.Parse(TxtTallaEdadWho2007Z.Text) < 2)
                TxtDiagnosticoTalla.Text = "Normal";
            else if (float.Parse(TxtTallaEdadWho2007Z.Text) < -2)
                TxtDiagnosticoTalla.Text = "Baja";
            else
                TxtDiagnosticoTalla.Text = "Error";

        }
        public void DiagnosticosWho2006()
        {
            if (float.Parse(TxtZPesoTalla.Text) > 3)
                TxtDiagnostico.Text = "Obesidad";
            else if (float.Parse(TxtZPesoTalla.Text) > 2 && float.Parse(TxtZPesoTalla.Text) < 3)
                TxtDiagnostico.Text = " Sobrepeso";
            else if (float.Parse(TxtZPesoTalla.Text) > 1 && float.Parse(TxtZPesoTalla.Text) < 2)
                TxtDiagnostico.Text = "Riesgo SP";
            else if (float.Parse(TxtZPesoTalla.Text) > -1 && float.Parse(TxtZPesoTalla.Text) < 1)
                TxtDiagnostico.Text = "Normal";
            else if (float.Parse(TxtZPesoTalla.Text) > -2 && float.Parse(TxtZPesoTalla.Text) < -1)
                TxtDiagnostico.Text = "Riesgo D";
            else if (float.Parse(TxtZPesoTalla.Text) > -3 && float.Parse(TxtZPesoTalla.Text) < -2)
                TxtDiagnostico.Text = "Agudo Moderado";
            else if (float.Parse(TxtZPesoTalla.Text) > -4 && float.Parse(TxtZPesoTalla.Text) < -3)
                TxtDiagnostico.Text = "Agudo Severo";
            else
                TxtDiagnostico.Text = "Fuera de Rango";
                
        }
        public void DiagnosticosWho2007()
        {
            if ((float.Parse(TxtIMCEdadWho2007Z.Text)) > 3)
                TxtDiagnostico.Text = "Obesidad";
            else if (float.Parse(TxtIMCEdadWho2007Z.Text) > 2 && float.Parse(TxtIMCEdadWho2007Z.Text) < 3)
                TxtDiagnostico.Text = " Sobrepeso";
            else if (float.Parse(TxtIMCEdadWho2007Z.Text) > 1 && float.Parse(TxtIMCEdadWho2007Z.Text) < 2)
                TxtDiagnostico.Text = "Riesgo SP";
            else if (float.Parse(TxtIMCEdadWho2007Z.Text) > -1 && float.Parse(TxtIMCEdadWho2007Z.Text) < 1)
                TxtDiagnostico.Text = "Normal";
            else if (float.Parse(TxtIMCEdadWho2007Z.Text) > -2 && float.Parse(TxtIMCEdadWho2007Z.Text) < -1)
                TxtDiagnostico.Text = "Riesgo D";
            else if (float.Parse(TxtIMCEdadWho2007Z.Text) > -3 && float.Parse(TxtIMCEdadWho2007Z.Text) < -2)
                TxtDiagnostico.Text = "Agudo Moderado";
            else if (float.Parse(TxtIMCEdadWho2007Z.Text) > -4 && float.Parse(TxtIMCEdadWho2007Z.Text) < -3)
                TxtDiagnostico.Text = "Agudo Severo";
            else
                TxtDiagnostico.Text = "Fuera de Rango";

        }
        public void CalculateZScoresWho2007()
        {
            var who2007 = new AnthStat.Statistics.WHO2007();
            double ageMonths = double.Parse(TxtEdadMeses.Text);
            double Weight = double.Parse(TxtPeso.Text);
            double Lenght = double.Parse(TxtTalla.Text);            
            double LenghtMeters = Lenght / 100;
            double imc = Weight / (LenghtMeters * LenghtMeters);
            double z = 0.0;
            double x = 0.0;
            double y = 0.0;
            TxtIMCCalculado.Text = Math.Round(imc, 2).ToString();
            if (txtSexo.Text == "Masculino\t")
            {
                if (who2007.TryCalculateZScore(indicator: Indicator.BodyMassIndexForAge, measurement: imc, age: ageMonths, sex: Sex.Male, z: ref z))
                {
                    double p = StatisticsHelper.CalculatePercentile(z);
                    TxtIMCEdadWho2007Z.Text = Math.Round(z, 2).ToString();
                    TxtIMCEdadWho2007P.Text = Math.Round(p, 2).ToString();
                }
                if (who2007.TryCalculateZScore(indicator: Indicator.WeightForAge, measurement: Weight, age: ageMonths, sex: Sex.Male, z: ref x))
                {
                    double p = StatisticsHelper.CalculatePercentile(x);
                    TxtPesoEdadWho2007Z.Text = Math.Round(x, 2).ToString();
                    TxtPesoEdadWho2007P.Text = Math.Round(p, 2).ToString();
                }
                if (who2007.TryCalculateZScore(indicator: Indicator.HeightForAge, measurement: Lenght, age: ageMonths, sex: Sex.Male, z: ref y))
                {
                    double p = StatisticsHelper.CalculatePercentile(y);
                    TxtTallaEdadWho2007Z.Text = Math.Round(y, 2).ToString();
                    TxtTallaEdadWho2007P.Text = Math.Round(p, 2).ToString();
                }
            }
            else if (txtSexo.Text == "Femenino")
            {
                if (who2007.TryCalculateZScore(indicator: Indicator.BodyMassIndexForAge, measurement: imc, age: ageMonths, sex: Sex.Female, z: ref z))
                {
                    double p = StatisticsHelper.CalculatePercentile(z);
                    TxtIMCEdadWho2007Z.Text = Math.Round(z, 2).ToString();
                    TxtIMCEdadWho2007P.Text = Math.Round(p, 2).ToString();
                }
                if (who2007.TryCalculateZScore(indicator: Indicator.WeightForAge, measurement: Weight, age: ageMonths, sex: Sex.Female, z: ref x))
                {
                    double p = StatisticsHelper.CalculatePercentile(x);
                    TxtPesoEdadWho2007Z.Text = Math.Round(x, 2).ToString();
                    TxtPesoEdadWho2007P.Text = Math.Round(p, 2).ToString();
                }
                if (who2007.TryCalculateZScore(indicator: Indicator.HeightForAge, measurement: Lenght, age: ageMonths, sex: Sex.Female, z: ref y))
                {
                    double p = StatisticsHelper.CalculatePercentile(y);
                    TxtTallaEdadWho2007Z.Text = Math.Round(y, 2).ToString();
                    TxtTallaEdadWho2007P.Text = Math.Round(p, 2).ToString();
                }
            }    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveData();
        }
        public void SaveData()
        {
            ClaseEnfermeria Pediatria = new ClaseEnfermeria {
                NMB = TxtID.Text,
                Fecha = dateTimePicker2.Value.Date,
                PZImcEdad = TxtIMCEdadWho2007Z.Text,
                PZTallaEdad = TxtTallaEdadWho2007Z.Text,
                PZPesoEdad = TxtPesoEdadWho2007Z.Text,
                PZPesoEdad2006 = TxtZPesoEdad.Text,
                PZTallaEdad2006 = TxtZTallaEdad.Text,
                PZPesoTalla = TxtZPesoTalla.Text,
                IMCPZ = TxtZIMC.Text,
                IMC = TxtIMCCalculado.Text,  
                Urgencias = ComboUrgencias.Text,
                Referido = ComboReferido.Text,
                Diagnostico = TxtDiagnostico.Text,
                DiagnosticoTalla = TxtDiagnosticoTalla.Text,

            };
            EvolutivoPediatria Cita = new EvolutivoPediatria();
            Cita.GetCita(Pediatria);
            Cita.ShowDialog(this);
           // _LogicLayer.InsertCitaPediatria(Pediatria);
        }      
        private void button2_Click(object sender, EventArgs e)
        {
            HistoriasPediatria Sucesivo = new HistoriasPediatria();
            Sucesivo.GetDataPediatria(TxtID.Text,int.Parse(TxtEdad.Text));
            Sucesivo.ShowDialog(this);
        }
    }
}
