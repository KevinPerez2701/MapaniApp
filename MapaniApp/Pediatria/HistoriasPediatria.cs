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
    public partial class HistoriasPediatria : Form
    {
        private LogicLayer _LogicLayer = new LogicLayer();
        public HistoriasPediatria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void GetDataPediatria(string ID)
        {
            List<ClaseEnfermeria> Data = _LogicLayer.GetDataPediatria(ID);
            dataGridView1.DataSource = Data;      
        }
    }
}
