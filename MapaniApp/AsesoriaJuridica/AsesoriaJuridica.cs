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
    public partial class AsesoriaJuridica : Form
    {
        public AsesoriaJuridica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroBeneficiarios registro = new RegistroBeneficiarios();
            registro.ShowDialog(this);
        }
    }
}
