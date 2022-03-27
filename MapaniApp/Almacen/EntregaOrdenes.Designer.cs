
namespace MapaniApp
{
    partial class EntregaOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregaOrdenes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pediatraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataAlmacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlmacenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNMBDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.programaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.pediatraDataGridViewTextBoxColumn,
            this.Orden});
            this.dataGridView1.DataSource = this.dataAlmacenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idNMBDataGridViewTextBoxColumn
            // 
            this.idNMBDataGridViewTextBoxColumn.DataPropertyName = "IdNMB";
            this.idNMBDataGridViewTextBoxColumn.HeaderText = "IdNMB";
            this.idNMBDataGridViewTextBoxColumn.Name = "idNMBDataGridViewTextBoxColumn";
            this.idNMBDataGridViewTextBoxColumn.Width = 50;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // programaDataGridViewTextBoxColumn
            // 
            this.programaDataGridViewTextBoxColumn.DataPropertyName = "Programa";
            this.programaDataGridViewTextBoxColumn.HeaderText = "Programa";
            this.programaDataGridViewTextBoxColumn.Name = "programaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 50;
            // 
            // pediatraDataGridViewTextBoxColumn
            // 
            this.pediatraDataGridViewTextBoxColumn.DataPropertyName = "Pediatra";
            this.pediatraDataGridViewTextBoxColumn.HeaderText = "Pediatra";
            this.pediatraDataGridViewTextBoxColumn.Name = "pediatraDataGridViewTextBoxColumn";
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.Text = "Despachar";
            this.Orden.UseColumnTextForLinkValue = true;
            // 
            // dataAlmacenBindingSource
            // 
            this.dataAlmacenBindingSource.DataSource = typeof(MapaniApp.DataAlmacen);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(275, 312);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(133, 30);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // EntregaOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntregaOrdenes";
            this.Text = "EntregaOrdenes";
            this.Load += new System.EventHandler(this.EntregaOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlmacenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataAlmacenBindingSource;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pediatraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Orden;
    }
}