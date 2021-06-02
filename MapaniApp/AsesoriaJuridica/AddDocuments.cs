﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class AddDocuments : Form
    {   string filepath;
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddDocuments()
        {
            InitializeComponent();
        }

        private void AddDocuments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodos.AgregarFoto(PbFotoNewContact); 
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDocumento.Text == "Partida Nacimiento" || ComboDocumento.Text == "Cedula NMB")
            {
                labelIdNMB.Visible = true;
                txtIdNMB.Visible = true;
                BtnAgregar.Visible = true;
            }
            else
            {
                BtnAgregar.Visible = true;
                labelIdNMB.Visible = false;
                txtIdNMB.Visible = false;
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LoadContactCuidador(txtID.Text);
        }
        public void LoadContactCuidador(string ID)
        {
            List<ContactCuidador> Contacts = _LogicLayer.GetContactsCuidador(ID);
            ContactCuidador contact = Contacts[0];
            TxtNombre.Text = contact.Nombre;
            TxtApellido.Text = contact.Apellido;
            txtCedula.Text = contact.Cedula;           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveDocument();
            this.Close();
        }
        private void SaveDocument()
        {
            if (txtIdNMB.Text == "")
                txtIdNMB.Text = "0";
                ContactAsesoria document = new ContactAsesoria
                {
                    IdCuidador = int.Parse(txtID.Text),
                    IdNMB = int.Parse(txtIdNMB.Text),
                    Documento = Metodos.ImageToArray(PbFotoNewContact),
                    TipoDocumento = ComboDocumento.Text,
                  
                };
            Metodos.databaseFilePut(filepath, document);
                 _LogicLayer.SaveDocument(document);
            //}
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
              
            }
        }
    }
}
