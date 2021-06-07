
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
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evolutivo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lactanciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMCPZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZImcEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZTallaEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZTallaEdad2006DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZPesoEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZPesoEdad2006DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZPesoTallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZTallaImcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patologiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antecedentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoTallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseEnfermeriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseEnfermeriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Observacion,
            this.Evolutivo,
            this.nMBDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.programaDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.tallaDataGridViewTextBoxColumn,
            this.mUACDataGridViewTextBoxColumn,
            this.cCDataGridViewTextBoxColumn,
            this.cMBDataGridViewTextBoxColumn,
            this.edemaDataGridViewTextBoxColumn,
            this.lactanciaDataGridViewTextBoxColumn,
            this.pesoNacimientoDataGridViewTextBoxColumn,
            this.iMCDataGridViewTextBoxColumn,
            this.iMCPZDataGridViewTextBoxColumn,
            this.pZImcEdadDataGridViewTextBoxColumn,
            this.pZTallaEdadDataGridViewTextBoxColumn,
            this.pZTallaEdad2006DataGridViewTextBoxColumn,
            this.pZPesoEdadDataGridViewTextBoxColumn,
            this.pZPesoEdad2006DataGridViewTextBoxColumn,
            this.pZPesoTallaDataGridViewTextBoxColumn,
            this.pZTallaImcDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.patologiaDataGridViewTextBoxColumn,
            this.antecedentesDataGridViewTextBoxColumn,
            this.hbDataGridViewTextBoxColumn,
            this.urgenciasDataGridViewTextBoxColumn,
            this.referidoDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn,
            this.diagnosticoTallaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.claseEnfermeriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1438, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.Visible = false;
            // 
            // Evolutivo
            // 
            this.Evolutivo.HeaderText = "Evolutivo";
            this.Evolutivo.Name = "Evolutivo";
            this.Evolutivo.Text = "Ver";
            this.Evolutivo.UseColumnTextForLinkValue = true;
            // 
            // nMBDataGridViewTextBoxColumn
            // 
            this.nMBDataGridViewTextBoxColumn.DataPropertyName = "NMB";
            this.nMBDataGridViewTextBoxColumn.HeaderText = "NMB";
            this.nMBDataGridViewTextBoxColumn.Name = "nMBDataGridViewTextBoxColumn";
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
            // mUACDataGridViewTextBoxColumn
            // 
            this.mUACDataGridViewTextBoxColumn.DataPropertyName = "MUAC";
            this.mUACDataGridViewTextBoxColumn.HeaderText = "MUAC";
            this.mUACDataGridViewTextBoxColumn.Name = "mUACDataGridViewTextBoxColumn";
            // 
            // cCDataGridViewTextBoxColumn
            // 
            this.cCDataGridViewTextBoxColumn.DataPropertyName = "CC";
            this.cCDataGridViewTextBoxColumn.HeaderText = "CC";
            this.cCDataGridViewTextBoxColumn.Name = "cCDataGridViewTextBoxColumn";
            // 
            // cMBDataGridViewTextBoxColumn
            // 
            this.cMBDataGridViewTextBoxColumn.DataPropertyName = "CMB";
            this.cMBDataGridViewTextBoxColumn.HeaderText = "CMB";
            this.cMBDataGridViewTextBoxColumn.Name = "cMBDataGridViewTextBoxColumn";
            // 
            // edemaDataGridViewTextBoxColumn
            // 
            this.edemaDataGridViewTextBoxColumn.DataPropertyName = "Edema";
            this.edemaDataGridViewTextBoxColumn.HeaderText = "Edema";
            this.edemaDataGridViewTextBoxColumn.Name = "edemaDataGridViewTextBoxColumn";
            // 
            // lactanciaDataGridViewTextBoxColumn
            // 
            this.lactanciaDataGridViewTextBoxColumn.DataPropertyName = "Lactancia";
            this.lactanciaDataGridViewTextBoxColumn.HeaderText = "Lactancia";
            this.lactanciaDataGridViewTextBoxColumn.Name = "lactanciaDataGridViewTextBoxColumn";
            // 
            // pesoNacimientoDataGridViewTextBoxColumn
            // 
            this.pesoNacimientoDataGridViewTextBoxColumn.DataPropertyName = "PesoNacimiento";
            this.pesoNacimientoDataGridViewTextBoxColumn.HeaderText = "PesoNacimiento";
            this.pesoNacimientoDataGridViewTextBoxColumn.Name = "pesoNacimientoDataGridViewTextBoxColumn";
            // 
            // iMCDataGridViewTextBoxColumn
            // 
            this.iMCDataGridViewTextBoxColumn.DataPropertyName = "IMC";
            this.iMCDataGridViewTextBoxColumn.HeaderText = "IMC";
            this.iMCDataGridViewTextBoxColumn.Name = "iMCDataGridViewTextBoxColumn";
            // 
            // iMCPZDataGridViewTextBoxColumn
            // 
            this.iMCPZDataGridViewTextBoxColumn.DataPropertyName = "IMCPZ";
            this.iMCPZDataGridViewTextBoxColumn.HeaderText = "IMCPZ";
            this.iMCPZDataGridViewTextBoxColumn.Name = "iMCPZDataGridViewTextBoxColumn";
            // 
            // pZImcEdadDataGridViewTextBoxColumn
            // 
            this.pZImcEdadDataGridViewTextBoxColumn.DataPropertyName = "PZImcEdad";
            this.pZImcEdadDataGridViewTextBoxColumn.HeaderText = "PZImcEdad";
            this.pZImcEdadDataGridViewTextBoxColumn.Name = "pZImcEdadDataGridViewTextBoxColumn";
            // 
            // pZTallaEdadDataGridViewTextBoxColumn
            // 
            this.pZTallaEdadDataGridViewTextBoxColumn.DataPropertyName = "PZTallaEdad";
            this.pZTallaEdadDataGridViewTextBoxColumn.HeaderText = "PZTallaEdad";
            this.pZTallaEdadDataGridViewTextBoxColumn.Name = "pZTallaEdadDataGridViewTextBoxColumn";
            // 
            // pZTallaEdad2006DataGridViewTextBoxColumn
            // 
            this.pZTallaEdad2006DataGridViewTextBoxColumn.DataPropertyName = "PZTallaEdad2006";
            this.pZTallaEdad2006DataGridViewTextBoxColumn.HeaderText = "PZTallaEdad2006";
            this.pZTallaEdad2006DataGridViewTextBoxColumn.Name = "pZTallaEdad2006DataGridViewTextBoxColumn";
            // 
            // pZPesoEdadDataGridViewTextBoxColumn
            // 
            this.pZPesoEdadDataGridViewTextBoxColumn.DataPropertyName = "PZPesoEdad";
            this.pZPesoEdadDataGridViewTextBoxColumn.HeaderText = "PZPesoEdad";
            this.pZPesoEdadDataGridViewTextBoxColumn.Name = "pZPesoEdadDataGridViewTextBoxColumn";
            // 
            // pZPesoEdad2006DataGridViewTextBoxColumn
            // 
            this.pZPesoEdad2006DataGridViewTextBoxColumn.DataPropertyName = "PZPesoEdad2006";
            this.pZPesoEdad2006DataGridViewTextBoxColumn.HeaderText = "PZPesoEdad2006";
            this.pZPesoEdad2006DataGridViewTextBoxColumn.Name = "pZPesoEdad2006DataGridViewTextBoxColumn";
            // 
            // pZPesoTallaDataGridViewTextBoxColumn
            // 
            this.pZPesoTallaDataGridViewTextBoxColumn.DataPropertyName = "PZPesoTalla";
            this.pZPesoTallaDataGridViewTextBoxColumn.HeaderText = "PZPesoTalla";
            this.pZPesoTallaDataGridViewTextBoxColumn.Name = "pZPesoTallaDataGridViewTextBoxColumn";
            // 
            // pZTallaImcDataGridViewTextBoxColumn
            // 
            this.pZTallaImcDataGridViewTextBoxColumn.DataPropertyName = "PZTallaImc";
            this.pZTallaImcDataGridViewTextBoxColumn.HeaderText = "PZTallaImc";
            this.pZTallaImcDataGridViewTextBoxColumn.Name = "pZTallaImcDataGridViewTextBoxColumn";
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            // 
            // patologiaDataGridViewTextBoxColumn
            // 
            this.patologiaDataGridViewTextBoxColumn.DataPropertyName = "Patologia";
            this.patologiaDataGridViewTextBoxColumn.HeaderText = "Patologia";
            this.patologiaDataGridViewTextBoxColumn.Name = "patologiaDataGridViewTextBoxColumn";
            // 
            // antecedentesDataGridViewTextBoxColumn
            // 
            this.antecedentesDataGridViewTextBoxColumn.DataPropertyName = "Antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.HeaderText = "Antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.Name = "antecedentesDataGridViewTextBoxColumn";
            // 
            // hbDataGridViewTextBoxColumn
            // 
            this.hbDataGridViewTextBoxColumn.DataPropertyName = "Hb";
            this.hbDataGridViewTextBoxColumn.HeaderText = "Hb";
            this.hbDataGridViewTextBoxColumn.Name = "hbDataGridViewTextBoxColumn";
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
            // claseEnfermeriaBindingSource
            // 
            this.claseEnfermeriaBindingSource.DataSource = typeof(MapaniApp.ClaseEnfermeria);
            // 
            // SucesivoNutricion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewLinkColumn Evolutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lactanciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMCPZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZImcEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZTallaEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZTallaEdad2006DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZPesoEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZPesoEdad2006DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZPesoTallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZTallaImcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patologiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecedentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoTallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource claseEnfermeriaBindingSource;
    }
}