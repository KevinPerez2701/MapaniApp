using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class ContactosCuidadores : Form
    {
        LogicLayer _LogicLayer = new LogicLayer();
        public ContactosCuidadores()
        {
            InitializeComponent();
        }

        private void ContactosCuidadores_Load(object sender, EventArgs e)
        {

        }
        #region Eventos
        public void PopulateContactsAsesoria(string SearchText = null)
        {
            List<ContactAsesoria> contacts = _LogicLayer.GetContactsAsesoria(SearchText);
            dataGridView1.DataSource = contacts;
        }
        #endregion 
    }
}
