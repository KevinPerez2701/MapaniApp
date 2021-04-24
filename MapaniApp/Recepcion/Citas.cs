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
    public partial class Citas : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public Citas()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<ProximasVisitas> Citas = _LogicLayer.GetCitas(dateTimePicker1.Value.Date);
            dataGridView1.DataSource = Citas;
            dataGridView1.Visible = true;


        }

        private void Citas_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<HistorialVisitas> Historial = _LogicLayer.GetHistorialCitas(dateTimePicker1.Value.Date);
            dataGridView2.DataSource = Historial;
        }
    }
}
