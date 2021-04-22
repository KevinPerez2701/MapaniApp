﻿using System;
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
    public partial class ConfirmarCita : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public ConfirmarCita()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void BtnAgregarCita_Click(object sender, EventArgs e)
        {
            ConfirmDate();
            this.Close();
        }
        private void ConfirmDate()
        {
            HistorialVisitas Cita = new HistorialVisitas();
            Cita.IdNMB = int.Parse(TxtId.Text);
            Cita.IdCuidador = int.Parse(TxtCuidador.Text);
            Cita.Fecha = DateCita.Value;
            Cita.Departamento = comboDepartamento.Text;
            Cita.Motivo = TxtObservacion.Text;
            Cita.Reagendo = comboBox1.Text;
            _LogicLayer.ConfirmCita(Cita);
            _LogicLayer.DeleteCita(Cita);
            
        }

        public void LoadData(HistorialVisitas Cita)
        {
            if (Cita != null)
            {
                TxtId.Text = Cita.IdNMB.ToString();
                comboDepartamento.Text = Cita.Departamento.ToString();
                DateCita.Value = Cita.Fecha;

            }    
        }

        private void ConfirmarCita_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Si")
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }
    }
}
