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
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Ver") // Si se selecciona el hipervinculo "confirmar"
            {
                EvolutivoPediatria Evolutivo = new EvolutivoPediatria();
                Evolutivo.Data(new ClaseEnfermeria
                {
                    Antecedentes = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString(),
                    Patologia =dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString(),
                    Observacion = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString(),
                });
                Evolutivo.HideButton();
                Evolutivo.ShowDialog(this);
            }
        }
       
        public void GetDataPediatria(string ID, int Dias)
        {
            List<ClaseEnfermeria> Data = _LogicLayer.GetDataPediatria(ID);
            dataGridView1.DataSource = Data;
            if (Dias>1825)
            {
                dataGridView1.Columns[7].Visible = true;
                dataGridView1.Columns[8].Visible = true;
                dataGridView1.Columns[9].Visible = true;
            }
            else
            {
                dataGridView1.Columns[10].Visible = true;
                dataGridView1.Columns[11].Visible = true;
                dataGridView1.Columns[12].Visible = true;
                dataGridView1.Columns[13].Visible = true;
               
            }
        }
    }
}
