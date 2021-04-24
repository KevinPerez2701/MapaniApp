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
    public partial class EntregaOrdenes : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public EntregaOrdenes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntregaOrdenes_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }
        public void PopulateContacts()
        {
                List<DataAlmacen> contacts = _LogicLayer.GetOrdenes();
                dataGridView1.DataSource = contacts;           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Despachar") // Si se selecciona el hipervinculo "confirmar"
            {
                PopulateContacts();
            }

         }
    }

}
