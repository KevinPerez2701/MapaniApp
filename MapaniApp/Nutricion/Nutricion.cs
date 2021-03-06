using AnthStat.Statistics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MapaniApp
{
    public partial class Nutricion : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        private ContactNMB _contactNMB = new ContactNMB();
        public Nutricion()
        {
            InitializeComponent();
        }

        private void Nutricion_Load(object sender, EventArgs e)
        {

        }

        #region Funciones
        public void SaveData()
        {
            ClaseEnfermeria Pediatria = new ClaseEnfermeria
            {
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
                Peso = TxtPeso.Text,
                Talla = TxtTalla.Text,
                Hb = txtHb.Text,
                Programa = comboPrograma.Text,
                CC = TxtCC.Text,
                CMB = TxtCMB.Text,


            };
            EvolutivoPediatria Cita = new EvolutivoPediatria();
            Cita.GetCitaNutricion(Pediatria);
            Cita.ShowDialog(this);
            // _LogicLayer.InsertCitaPediatria(Pediatria);
        }
        public void GetDataEnfermeria()
        {
            List<ClaseEnfermeria> Data = _LogicLayer.GetDataEnfermeria(TxtID.Text, dateTimePicker2.Value.Date);
            if (Data.Count != 0)
            {
                ClaseEnfermeria Datos = Data[0];
                TxtPeso.Text = Datos.Peso;
                TxtTalla.Text = Datos.Talla;
                TxtCMB.Text = Datos.CMB;
                txtHb.Text = Datos.Hb;
                if (TxtCC.Text != "")
                {
                    TxtCC.Text = Datos.CC;
                }
                else
                {
                    TxtCC.Text = "0";
                }
                TxtTricep.Text = "0";
                TxtSSF.Text = "0";
            }
            else
            {
                MessageBox.Show("Ingrese una Fecha Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                TxtEdad.Text = Metodos.GetEdad(contact.FechaNacimiento, dateTimePicker2.Value);
                TxtEdadMeses.Text = Metodos.GetEdadMeses(contact.FechaNacimiento, dateTimePicker2.Value);
                txtSexo.Text = contact.Sexo;
                txtEdadVisible.Text = Metodos.ObtenerEdad(contact.FechaNacimiento);
                TxtNombre.ReadOnly = true;
                TxtApellido.ReadOnly = true;
                dateTimePicker1.Enabled = false;
                txtSexo.ReadOnly = true;
                txtEdadVisible.ReadOnly = true;

            }
        }
        #endregion
        #region Calculo de Datos
        public void CalculateZScoresWho2006()
        {
            var who2006 = new AnthStat.Statistics.WHO2006();
            double ageDays = double.Parse(TxtEdad.Text);
            double Weight = double.Parse(TxtPeso.Text);
            double Lenght = double.Parse(TxtTalla.Text);
            double CC = double.Parse(TxtCC.Text);
            double CMB = double.Parse(TxtCMB.Text);
            double Muac = double.Parse(TxtTricep.Text);
            double LenghtMeters = Lenght / 100;
            double imc = Weight / (LenghtMeters * LenghtMeters);
            TxtIMCCalculado.Text = Math.Round(imc, 2).ToString();
            double z = 0.0;
            double x = 0.0;
            double y = 0.0;
            double w = 0.0;
            if (txtSexo.Text == "Masculino" || txtSexo.Text == "Masculino\t")
            {
                if (who2006.TryCalculateZScore(indicator: Indicator.BodyMassIndexForAge, measurement1: imc, measurement2: ageDays, sex: Sex.Male, z: ref z))
                {
                    TxtZIMC.Text = Math.Round(z, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(z);
                    TxtImc.Text = Math.Round(p, 1).ToString();

                }
                if (ageDays > 720)
                {
                    if (who2006.TryCalculateZScore(indicator: Indicator.WeightForHeight, measurement1: Weight, measurement2: Lenght, sex: Sex.Male, z: ref x))
                    {
                        TxtZPesoTalla.Text = Math.Round(x, 2).ToString();
                        double p = StatisticsHelper.CalculatePercentile(x);
                        TxtPesoTalla.Text = Math.Round(p, 1).ToString();


                    }
                }
                if (ageDays < 720)
                {
                    if (who2006.TryCalculateZScore(indicator: Indicator.WeightForLength, measurement1: Weight, measurement2: Lenght, sex: Sex.Male, z: ref x))
                    {
                        TxtZPesoTalla.Text = Math.Round(x, 2).ToString();
                        double p = StatisticsHelper.CalculatePercentile(x);
                        TxtPesoTalla.Text = Math.Round(p, 1).ToString();

                    }

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
            else if (txtSexo.Text == "Femenino" || txtSexo.Text == "Femenino\t")
            {
                if (who2006.TryCalculateZScore(indicator: Indicator.BodyMassIndexForAge, measurement1: imc, measurement2: ageDays, sex: Sex.Female, z: ref z))
                {
                    TxtZIMC.Text = Math.Round(z, 2).ToString();
                    double p = StatisticsHelper.CalculatePercentile(z);
                    TxtImc.Text = Math.Round(p, 1).ToString();

                }
                if (ageDays > 720)
                {
                    if (who2006.TryCalculateZScore(indicator: Indicator.WeightForHeight, measurement1: Weight, measurement2: Lenght, sex: Sex.Female, z: ref x))
                    {
                        TxtZPesoTalla.Text = Math.Round(x, 2).ToString();
                        double p = StatisticsHelper.CalculatePercentile(x);
                        TxtPesoTalla.Text = Math.Round(p, 1).ToString();

                    }

                }
                if (ageDays < 720)
                {
                    if (who2006.TryCalculateZScore(indicator: Indicator.WeightForLength, measurement1: Weight, measurement2: Lenght, sex: Sex.Female, z: ref x))
                    {
                        TxtZPesoTalla.Text = Math.Round(x, 2).ToString();
                        double p = StatisticsHelper.CalculatePercentile(x);
                        TxtPesoTalla.Text = Math.Round(p, 1).ToString();

                    }

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
            if (txtSexo.Text == "Masculino" || txtSexo.Text == "Masculino\t")
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
            else if (txtSexo.Text == "Femenino" || txtSexo.Text == "Femenino\t")
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
        #endregion
        #region Botones
        private void BtnHistorialNutricional_Click(object sender, EventArgs e)
        {
            HistorialNutricional Historial = new HistorialNutricional();
            Historial.LoadInfo(TxtNombre.Text, TxtApellido.Text, TxtID.Text, _contactNMB.HistorialNutricional);
            Historial.ShowDialog(this);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void BtnSucesivo_Click(object sender, EventArgs e)
        {
            SucesivoNutricion Sucesivo = new SucesivoNutricion();

            Sucesivo.GetDataNutricion(TxtID.Text, int.Parse(TxtEdad.Text));
            Sucesivo.ShowDialog(this);
        }
        private void BtnCargarContacto_Click(object sender, EventArgs e)
        {
            List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
            if (contacts.Count != 0)
            {
                ContactNMB contact = contacts[0];
                LoadContact(contact);
                BtnAddOrder.Visible = true;
                GetDataEnfermeria();
            }
            else
            {
                MessageBox.Show("Ingrese un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            VerProductos NuevaOrden = new VerProductos();
            NuevaOrden.GetProductos();
            NuevaOrden.GetIdNMB(TxtID.Text);
            NuevaOrden.ShowDialog(this);
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (float.Parse(TxtEdad.Text) > 1825)
            {
                GroupWHO2007.Visible = true;
                GroupWHO2006.Visible = false;
                CalculateZScoresWho2007();
                DiagnosticosWho2007();
                DiagnosticoTalla2007();
            }
            else if (float.Parse(TxtEdad.Text) > 0 && float.Parse(TxtEdad.Text) < 1825)
            {
                GroupWHO2006.Visible = true;
                GroupWHO2007.Visible = false;
                CalculateZScoresWho2006();
                DiagnosticosWho2006();
                DiagnosticoTalla();
                if (float.Parse(TxtCC.Text) != 0)
                {
                    TxtCCP.Visible = true;
                    TxtZCC.Visible = true;
                    label17.Visible = true;
                }
                if (float.Parse(TxtTricep.Text) != 0)
                {
                    TxtTSFP.Visible = true;
                    TxtTSFZ.Visible = true;
                    label14.Visible = true;
                }
                if (float.Parse(TxtSSF.Text) != 0)
                {
                    TxtSSFP.Visible = true;
                    TxtSSFZ.Visible = true;
                    label15.Visible = true;
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            TxtPeso.ReadOnly = false;
            txtHb.ReadOnly = false;
            TxtCC.ReadOnly = false;
            TxtTalla.ReadOnly = false;
            TxtCMB.ReadOnly = false;
        }
        #endregion
        #region Validacion de DAtos
        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ComboUrgencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese una opcion Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }

        private void TxtPeso_Leave(object sender, EventArgs e)
        {
            if (float.Parse(TxtPeso.Text) < 1 || float.Parse(TxtPeso.Text) > 275)
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPeso.Text = "0";
                return;
            }
        }

        private void TxtTalla_Leave(object sender, EventArgs e)
        {
            if (float.Parse(TxtTalla.Text) < 38 || float.Parse(TxtTalla.Text) > 230)
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtTalla.Text = "0";
                return;
            }
        }

        private void TxtCMB_Leave(object sender, EventArgs e)
        {
            if (float.Parse(TxtCMB.Text) < 6 || float.Parse(TxtCMB.Text) > 35)
            {
                MessageBox.Show("Ingrese un Valor Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCMB.Text = "0";
                return;
            }
        }
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca un Id Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion


    }
}
