
namespace MapaniApp
{
    partial class SucesivoNutricion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.claseEnfermeriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZPesoEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZTallaEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZImcEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZTallaEdad2006DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZPesoEdad2006DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZPesoTallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMCPZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoTallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antecedentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patologiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evolutivo = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseEnfermeriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.programaDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.tallaDataGridViewTextBoxColumn,
            this.cMBDataGridViewTextBoxColumn,
            this.hbDataGridViewTextBoxColumn,
            this.iMCDataGridViewTextBoxColumn,
            this.pZPesoEdadDataGridViewTextBoxColumn,
            this.pZTallaEdadDataGridViewTextBoxColumn,
            this.pZImcEdadDataGridViewTextBoxColumn,
            this.pZTallaEdad2006DataGridViewTextBoxColumn,
            this.pZPesoEdad2006DataGridViewTextBoxColumn,
            this.pZPesoTallaDataGridViewTextBoxColumn,
            this.iMCPZDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.diagnosticoTallaDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.antecedentesDataGridViewTextBoxColumn,
            this.patologiaDataGridViewTextBoxColumn,
            this.urgenciasDataGridViewTextBoxColumn,
            this.referidoDataGridViewTextBoxColumn,
            this.Evolutivo});
            this.dataGridView1.DataSource = this.claseEnfermeriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1462, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // claseEnfermeriaBindingSource
            // 
            this.claseEnfermeriaBindingSource.DataSource = typeof(MapaniApp.ClaseEnfermeria);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // programaDataGridViewTextBoxColumn
            // 
            this.programaDataGridViewTextBoxColumn.DataPropertyName = "Programa";
            this.programaDataGridViewTextBoxColumn.HeaderText = "Programa";
            this.programaDataGridViewTextBoxColumn.Name = "programaDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // tallaDataGridViewTextBoxColumn
            // 
            this.tallaDataGridViewTextBoxColumn.DataPropertyName = "Talla";
            this.tallaDataGridViewTextBoxColumn.HeaderText = "Talla";
            this.tallaDataGridViewTextBoxColumn.Name = "tallaDataGridViewTextBoxColumn";
            // 
            // cMBDataGridViewTextBoxColumn
            // 
            this.cMBDataGridViewTextBoxColumn.DataPropertyName = "CMB";
            this.cMBDataGridViewTextBoxColumn.HeaderText = "CMB";
            this.cMBDataGridViewTextBoxColumn.Name = "cMBDataGridViewTextBoxColumn";
            // 
            // hbDataGridViewTextBoxColumn
            // 
            this.hbDataGridViewTextBoxColumn.DataPropertyName = "Hb";
            this.hbDataGridViewTextBoxColumn.HeaderText = "Hb";
            this.hbDataGridViewTextBoxColumn.Name = "hbDataGridViewTextBoxColumn";
            // 
            // iMCDataGridViewTextBoxColumn
            // 
            this.iMCDataGridViewTextBoxColumn.DataPropertyName = "IMC";
            this.iMCDataGridViewTextBoxColumn.HeaderText = "IMC";
            this.iMCDataGridViewTextBoxColumn.Name = "iMCDataGridViewTextBoxColumn";
            // 
            // pZPesoEdadDataGridViewTextBoxColumn
            // 
            this.pZPesoEdadDataGridViewTextBoxColumn.DataPropertyName = "PZPesoEdad";
            this.pZPesoEdadDataGridViewTextBoxColumn.HeaderText = "PZPesoEdad";
            this.pZPesoEdadDataGridViewTextBoxColumn.Name = "pZPesoEdadDataGridViewTextBoxColumn";
            this.pZPesoEdadDataGridViewTextBoxColumn.Visible = false;
            // 
            // pZTallaEdadDataGridViewTextBoxColumn
            // 
            this.pZTallaEdadDataGridViewTextBoxColumn.DataPropertyName = "PZTallaEdad";
            this.pZTallaEdadDataGridViewTextBoxColumn.HeaderText = "PZTallaEdad";
            this.pZTallaEdadDataGridViewTextBoxColumn.Name = "pZTallaEdadDataGridViewTextBoxColumn";
            this.pZTallaEdadDataGridViewTextBoxColumn.Visible = false;
            // 
            // pZImcEdadDataGridViewTextBoxColumn
            // 
            this.pZImcEdadDataGridViewTextBoxColumn.DataPropertyName = "PZImcEdad";
            this.pZImcEdadDataGridViewTextBoxColumn.HeaderText = "PZImcEdad";
            this.pZImcEdadDataGridViewTextBoxColumn.Name = "pZImcEdadDataGridViewTextBoxColumn";
            this.pZImcEdadDataGridViewTextBoxColumn.Visible = false;
            // 
            // pZTallaEdad2006DataGridViewTextBoxColumn
            // 
            this.pZTallaEdad2006DataGridViewTextBoxColumn.DataPropertyName = "PZTallaEdad2006";
            this.pZTallaEdad2006DataGridViewTextBoxColumn.HeaderText = "PZTallaEdad2006";
            this.pZTallaEdad2006DataGridViewTextBoxColumn.Name = "pZTallaEdad2006DataGridViewTextBoxColumn";
            this.pZTallaEdad2006DataGridViewTextBoxColumn.Visible = false;
            // 
            // pZPesoEdad2006DataGridViewTextBoxColumn
            // 
            this.pZPesoEdad2006DataGridViewTextBoxColumn.DataPropertyName = "PZPesoEdad2006";
            this.pZPesoEdad2006DataGridViewTextBoxColumn.HeaderText = "PZPesoEdad2006";
            this.pZPesoEdad2006DataGridViewTextBoxColumn.Name = "pZPesoEdad2006DataGridViewTextBoxColumn";
            this.pZPesoEdad2006DataGridViewTextBoxColumn.Visible = false;
            // 
            // pZPesoTallaDataGridViewTextBoxColumn
            // 
            this.pZPesoTallaDataGridViewTextBoxColumn.DataPropertyName = "PZPesoTalla";
            this.pZPesoTallaDataGridViewTextBoxColumn.HeaderText = "PZPesoTalla";
            this.pZPesoTallaDataGridViewTextBoxColumn.Name = "pZPesoTallaDataGridViewTextBoxColumn";
            this.pZPesoTallaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iMCPZDataGridViewTextBoxColumn
            // 
            this.iMCPZDataGridViewTextBoxColumn.DataPropertyName = "IMCPZ";
            this.iMCPZDataGridViewTextBoxColumn.HeaderText = "IMCPZ";
            this.iMCPZDataGridViewTextBoxColumn.Name = "iMCPZDataGridViewTextBoxColumn";
            this.iMCPZDataGridViewTextBoxColumn.Visible = false;
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            // 
            // diagnosticoTallaDataGridViewTextBoxColumn
            // 
            this.diagnosticoTallaDataGridViewTextBoxColumn.DataPropertyName = "DiagnosticoTalla";
            this.diagnosticoTallaDataGridViewTextBoxColumn.HeaderText = "DiagnosticoTalla";
            this.diagnosticoTallaDataGridViewTextBoxColumn.Name = "diagnosticoTallaDataGridViewTextBoxColumn";
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // antecedentesDataGridViewTextBoxColumn
            // 
            this.antecedentesDataGridViewTextBoxColumn.DataPropertyName = "Antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.HeaderText = "Antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.Name = "antecedentesDataGridViewTextBoxColumn";
            this.antecedentesDataGridViewTextBoxColumn.Visible = false;
            // 
            // patologiaDataGridViewTextBoxColumn
            // 
            this.patologiaDataGridViewTextBoxColumn.DataPropertyName = "Patologia";
            this.patologiaDataGridViewTextBoxColumn.HeaderText = "Patologia";
            this.patologiaDataGridViewTextBoxColumn.Name = "patologiaDataGridViewTextBoxColumn";
            this.patologiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // urgenciasDataGridViewTextBoxColumn
            // 
            this.urgenciasDataGridViewTextBoxColumn.DataPropertyName = "Urgencias";
            this.urgenciasDataGridViewTextBoxColumn.HeaderText = "Urgencias";
            this.urgenciasDataGridViewTextBoxColumn.Name = "urgenciasDataGridViewTextBoxColumn";
            // 
            // referidoDataGridViewTextBoxColumn
            // 
            this.referidoDataGridViewTextBoxColumn.DataPropertyName = "Referido";
            this.referidoDataGridViewTextBoxColumn.HeaderText = "Referido";
            this.referidoDataGridViewTextBoxColumn.Name = "referidoDataGridViewTextBoxColumn";
            // 
            // Evolutivo
            // 
            this.Evolutivo.HeaderText = "Evolutivo";
            this.Evolutivo.Name = "Evolutivo";
            this.Evolutivo.Text = "Ver";
            this.Evolutivo.UseColumnTextForLinkValue = true;
            // 
            // SucesivoNutricion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SucesivoNutricion";
            this.Text = "SucesivoNutricion";
            this.Load += new System.EventHandler(this.SucesivoNutricion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseEnfermeriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource claseEnfermeriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZPesoEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZTallaEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZImcEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZTallaEdad2006DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZPesoEdad2006DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZPesoTallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMCPZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoTallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecedentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patologiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Evolutivo;
    }
}