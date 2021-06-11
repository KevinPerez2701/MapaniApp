using System;
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
        public void PopulateContactsAsesoria(string SearchText = null)
        {
            List<ContactAsesoria> contacts = _LogicLayer.GetContactsAsesoria(SearchText);
            dataGridView1.DataSource = contacts;
        }
    }
}
