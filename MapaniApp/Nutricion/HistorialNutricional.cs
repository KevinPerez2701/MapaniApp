using System;
using System.Windows.Forms;

namespace MapaniApp
{

    public partial class HistorialNutricional : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public HistorialNutricional()
        {
            InitializeComponent();
        }

        private void HistorialNutricional_Load(object sender, EventArgs e)
        {

        }
        #region Botones
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SavedataList();
            SaveData();
            this.Close();
        }
        #endregion
        #region Funciones
        public void LoadInfo(string Name, string LastName, string ID, string Historial)
        {
            TxtNombre.Text = Name;
            TxtApellido.Text = LastName;
            txtSexo.Text = ID;
            TxtNombre.ReadOnly = true;
            TxtApellido.ReadOnly = true;
            txtSexo.ReadOnly = true;
            if (Historial == "Si")
            {
                groupBox3.Visible = true;
                groupBox2.Visible = false;
                LoadHistorial(ID);
                BtnGuardar.Visible = false;
            }

        }
        public void SavedataList()
        {
            string Diario = string.Empty;
            string Semanal = string.Empty;
            string Quincenal = string.Empty;
            string Mensual = string.Empty;

            foreach (object item in checkedListBox4.CheckedItems)
            {
                Diario += item.ToString() + ",";
            }
            foreach (object item in checkedListBox3.CheckedItems)
            {
                Semanal += item.ToString() + ",";
            }
            foreach (object item in checkedListBox2.CheckedItems)
            {
                Quincenal += item.ToString() + ",";
            }
            foreach (object item in checkedListBox1.CheckedItems)
            {
                Mensual += item.ToString() + ",";
            }
            textBox4.Text = Diario.Substring(0, Diario.Length - 1);
            textBox3.Text = Semanal.Substring(0, Semanal.Length - 1);
            textBox2.Text = Quincenal.Substring(0, Quincenal.Length - 1);
            textBox1.Text = Mensual.Substring(0, Mensual.Length - 1);

        }
        public void SaveData()
        {
            ContactNutricion Nutricion = new ContactNutricion
            {
                NMB = int.Parse(txtSexo.Text),
                HoraLevantar = dateTimeLevantar.Value,
                HoraDesayuno = dateTimeDesayuno.Value,
                HoraAlmuerzo = dateTimeAlmuerzo.Value,
                HoraMerienda1 = dateTimeMerienda1.Value,
                HoraMerienda2 = dateTimeMerienda2.Value,
                HoraCena = dateTimeCena.Value,
                Levantar = txtLevantar.Text,
                Desayuno = txtDesayuno.Text,
                Merienda1 = txtMerienda.Text,
                Almuerzo = txtAlmuerzo.Text,
                Merienda2 = txtDulce.Text,
                Cena = txtCena.Text,
                Diario = textBox4.Text,
                Semanal = textBox3.Text,
                Quincenal = textBox2.Text,
                Mensual = textBox1.Text,
                Historial = "Si",
            };
            _LogicLayer.InsertarHistorialNutricional(Nutricion);
        }
        public void LoadHistorial(string ID)
        {
            ContactNutricion contact = _LogicLayer.GetHistorialNutricion(ID);
            dateTimeLevantar.Value = contact.HoraLevantar;
            dateTimeDesayuno.Value = contact.HoraDesayuno;
            dateTimeMerienda1.Value = contact.HoraMerienda1;
            dateTimeAlmuerzo.Value = contact.HoraAlmuerzo;
            dateTimeMerienda2.Value = contact.HoraMerienda2;
            dateTimeCena.Value = contact.HoraCena;
            txtLevantar.Text = contact.Levantar;
            txtDesayuno.Text = contact.Desayuno;
            txtMerienda.Text = contact.Merienda1;
            txtAlmuerzo.Text = contact.Almuerzo;
            txtDulce.Text = contact.Merienda2;
            txtCena.Text = contact.Cena;
            textBox4.Text = contact.Diario;
            textBox3.Text = contact.Semanal;
            textBox2.Text = contact.Quincenal;
            textBox1.Text = contact.Mensual;
        }
        #endregion

    }

}
