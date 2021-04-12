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
    public partial class Recepcion : Form
    {
        private ContactMMB _contactMMB = new ContactMMB();
        private ContactCuidador _contactCuidador = new ContactCuidador();
        private ContactNMB _contactNMB = new ContactNMB();
        private LogicLayer _LogicLayer = new LogicLayer();
        public Recepcion()
        {
            InitializeComponent();
        }
        #region RECARGA DE DATOS 
        public void PopulateContacts(string SearchText = null)
        {
            List<ContactCuidador> contacts = _LogicLayer.GetCuidadores(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }
        public void PopulateContactsNMB(string SearchText = null)
        {
            List<ContactNMB> contacts = _LogicLayer.GetNMB(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }
        public void PopulateContactsMMB(string SearchText = null)
        {
            List<ContactMMB> contacts = _LogicLayer.GetMMB(SearchText);
            dataGridRelaciones.DataSource = contacts;
        }

        public void PopulateContactsVisita(string SearchText = null)
        {
            List<HistorialVisitas> Historial = _LogicLayer.GetHistorial(SearchText);
            dataGridHistorial.DataSource = Historial;
            List<ProximasVisitas> Proximas = _LogicLayer.GetProximas(SearchText);
            dataGridProximasVisitas.DataSource = Proximas;
        }
        #endregion
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (ComboUsuario.Text == "NMB")
            {
                List<ContactNMB> contacts = _LogicLayer.GetContacts(TxtID.Text);
                ContactNMB contact = contacts[0];
                LoadContact(contact);
                PopulateContacts(TxtID.Text);
                PopulateContactsVisita(TxtID.Text);
            }
            else if (ComboUsuario.Text == "Cuidador")
            {
                List<ContactCuidador> contacts = _LogicLayer.GetContactsCuidador(TxtID.Text);
                ContactCuidador contact = contacts[0];
                LoadContactCuidador(contact);
                PopulateContactsNMB(TxtID.Text);
            }
            else if (ComboUsuario.Text == "MMB")
            {
                List<ContactMMB> contacts = _LogicLayer.GetContactsMMB(TxtID.Text);
                ContactMMB contact = contacts[0];
                LoadContactMMB(contact);
                PopulateContactsMMB(TxtID.Text);
            }
        }
        #region FUNCIONES DE CARGA DE CONTACTOS
        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                TxtDireccion.Text = contact.Direccion;
                pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }
        public void LoadContactCuidador(ContactCuidador contact)
        {
            _contactCuidador = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                TxtDireccion.Text = contact.Direccion;
                pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }
        public void LoadContactMMB(ContactMMB contact)
        {
            _contactMMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento;
                TxtDireccion.Text = contact.Direccion;
                pictureBox1.Image = Metodos.GetImageFromByteArray(contact.Foto);

            }

        }
        #endregion

        private void Recepcion_Load(object sender, EventArgs e)
        {
           //Hello wordl
        }

      

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            Citas Cita = new Citas();
            Cita.ShowDialog(this);
        }

        private void BtnAgregarCita_Click(object sender, EventArgs e)
        {
            AgregarCita NuevaCita = new AgregarCita();
            NuevaCita.ShowDialog(this);
        }

        private void dataGridProximasVisitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridProximasVisitas.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Confirmar")
            {
                ConfirmarCita Confirm = new ConfirmarCita();
                Confirm.LoadData(new HistorialVisitas
                {
                    IdNMB= int.Parse(dataGridProximasVisitas.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Departamento = (dataGridProximasVisitas.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Fecha =(DateTime)dataGridProximasVisitas.Rows[e.RowIndex].Cells[1].Value
                });
                Confirm.ShowDialog(this);
            }    
        }
    }
}
