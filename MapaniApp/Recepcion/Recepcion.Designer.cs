
namespace MapaniApp
{
    public partial class Recepcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboUsuario = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridRelaciones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNMBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.idCuidadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reagendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewLinkColumn();
            this.historialVisitasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCitas = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridProximasVisitas = new System.Windows.Forms.DataGridView();
            this.IdNMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.proximasVisitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAgregarCita = new System.Windows.Forms.Button();
            this.historialVisitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactCuidadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactNMBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialVisitasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactNMBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVisitasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProximasVisitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximasVisitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVisitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactCuidadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactNMBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVisitasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de usuario";
            // 
            // ComboUsuario
            // 
            this.ComboUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboUsuario.FormattingEnabled = true;
            this.ComboUsuario.Items.AddRange(new object[] {
            "NMB",
            "MMB",
            "Cuidador"});
            this.ComboUsuario.Location = new System.Drawing.Point(281, 12);
            this.ComboUsuario.Name = "ComboUsuario";
            this.ComboUsuario.Size = new System.Drawing.Size(121, 32);
            this.ComboUsuario.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 29);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(144, 212);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(173, 29);
            this.TxtDireccion.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Direccion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(144, 139);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(173, 29);
            this.TxtApellido.TabIndex = 31;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(144, 104);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(173, 29);
            this.TxtNombre.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(419, 37);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCargar.Size = new System.Drawing.Size(110, 33);
            this.BtnCargar.TabIndex = 38;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ingrese el ID";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(281, 59);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(121, 29);
            this.TxtID.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(360, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridRelaciones
            // 
            this.dataGridRelaciones.AutoGenerateColumns = false;
            this.dataGridRelaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridRelaciones.DataSource = this.contactNMBBindingSource1;
            this.dataGridRelaciones.Location = new System.Drawing.Point(557, 37);
            this.dataGridRelaciones.Name = "dataGridRelaciones";
            this.dataGridRelaciones.Size = new System.Drawing.Size(253, 244);
            this.dataGridRelaciones.TabIndex = 45;
            this.dataGridRelaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRelaciones_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // contactNMBBindingSource1
            // 
            this.contactNMBBindingSource1.DataSource = typeof(MapaniApp.ContactNMB);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Relaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Historial Visitas";
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.AutoGenerateColumns = false;
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuidadorDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.Reagendo,
            this.Motivo,
            this.Productos});
            this.dataGridHistorial.DataSource = this.historialVisitasBindingSource2;
            this.dataGridHistorial.Location = new System.Drawing.Point(82, 477);
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.Size = new System.Drawing.Size(662, 124);
            this.dataGridHistorial.TabIndex = 48;
            this.dataGridHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorial_CellContentClick);
            // 
            // idCuidadorDataGridViewTextBoxColumn
            // 
            this.idCuidadorDataGridViewTextBoxColumn.DataPropertyName = "IdCuidador";
            this.idCuidadorDataGridViewTextBoxColumn.HeaderText = "IdCuidador";
            this.idCuidadorDataGridViewTextBoxColumn.Name = "idCuidadorDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            // 
            // Reagendo
            // 
            this.Reagendo.DataPropertyName = "Reagendo";
            this.Reagendo.HeaderText = "Reagendo";
            this.Reagendo.Name = "Reagendo";
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.Text = "Ver";
            this.Productos.UseColumnTextForLinkValue = true;
            // 
            // historialVisitasBindingSource2
            // 
            this.historialVisitasBindingSource2.DataSource = typeof(MapaniApp.HistorialVisitas);
            // 
            // BtnCitas
            // 
            this.BtnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCitas.Location = new System.Drawing.Point(25, 49);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Size = new System.Drawing.Size(129, 45);
            this.BtnCitas.TabIndex = 49;
            this.BtnCitas.Text = "Citas del Dia";
            this.BtnCitas.UseVisualStyleBackColor = true;
            this.BtnCitas.Click += new System.EventHandler(this.BtnCitas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "Proximas Visitas";
            // 
            // dataGridProximasVisitas
            // 
            this.dataGridProximasVisitas.AutoGenerateColumns = false;
            this.dataGridProximasVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProximasVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNMB,
            this.fechaDataGridViewTextBoxColumn1,
            this.departamentoDataGridViewTextBoxColumn1,
            this.Activo,
            this.Confirmar});
            this.dataGridProximasVisitas.DataSource = this.proximasVisitasBindingSource;
            this.dataGridProximasVisitas.Location = new System.Drawing.Point(187, 324);
            this.dataGridProximasVisitas.Name = "dataGridProximasVisitas";
            this.dataGridProximasVisitas.Size = new System.Drawing.Size(557, 114);
            this.dataGridProximasVisitas.TabIndex = 51;
            this.dataGridProximasVisitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProximasVisitas_CellContentClick);
            // 
            // IdNMB
            // 
            this.IdNMB.DataPropertyName = "IdNMB";
            this.IdNMB.HeaderText = "IdNMB";
            this.IdNMB.Name = "IdNMB";
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            // 
            // departamentoDataGridViewTextBoxColumn1
            // 
            this.departamentoDataGridViewTextBoxColumn1.DataPropertyName = "Departamento";
            this.departamentoDataGridViewTextBoxColumn1.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn1.Name = "departamentoDataGridViewTextBoxColumn1";
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // Confirmar
            // 
            this.Confirmar.HeaderText = "Confirmar";
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseColumnTextForLinkValue = true;
            // 
            // proximasVisitasBindingSource
            // 
            this.proximasVisitasBindingSource.DataSource = typeof(MapaniApp.ProximasVisitas);
            // 
            // BtnAgregarCita
            // 
            this.BtnAgregarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCita.Location = new System.Drawing.Point(82, 247);
            this.BtnAgregarCita.Name = "BtnAgregarCita";
            this.BtnAgregarCita.Size = new System.Drawing.Size(154, 34);
            this.BtnAgregarCita.TabIndex = 52;
            this.BtnAgregarCita.Text = "Agregar Cita";
            this.BtnAgregarCita.UseVisualStyleBackColor = true;
            this.BtnAgregarCita.Click += new System.EventHandler(this.BtnAgregarCita_Click);
            // 
            // historialVisitasBindingSource
            // 
            this.historialVisitasBindingSource.DataSource = typeof(MapaniApp.HistorialVisitas);
            // 
            // contactCuidadorBindingSource
            // 
            this.contactCuidadorBindingSource.DataSource = typeof(MapaniApp.ContactCuidador);
            // 
            // contactNMBBindingSource
            // 
            this.contactNMBBindingSource.DataSource = typeof(MapaniApp.ContactNMB);
            // 
            // historialVisitasBindingSource1
            // 
            this.historialVisitasBindingSource1.DataSource = typeof(MapaniApp.HistorialVisitas);
            // 
            // Recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 635);
            this.Controls.Add(this.BtnAgregarCita);
            this.Controls.Add(this.dataGridProximasVisitas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnCitas);
            this.Controls.Add(this.dataGridHistorial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridRelaciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Recepcion";
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.Recepcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactNMBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVisitasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProximasVisitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximasVisitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVisitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactCuidadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactNMBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVisitasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridRelaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactCuidadorBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource contactNMBBindingSource1;
        private System.Windows.Forms.BindingSource contactNMBBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.BindingSource historialVisitasBindingSource;
        private System.Windows.Forms.Button BtnCitas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource historialVisitasBindingSource1;
        private System.Windows.Forms.DataGridView dataGridProximasVisitas;
        private System.Windows.Forms.BindingSource proximasVisitasBindingSource;
        private System.Windows.Forms.Button BtnAgregarCita;
        private System.Windows.Forms.BindingSource historialVisitasBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuidadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reagendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewLinkColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewLinkColumn Confirmar;
    }
}