
namespace MapaniApp
{
    partial class Transcripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transcripcion));
            this.labelContacto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboOperacion = new System.Windows.Forms.ComboBox();
            this.ComboContacto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Parentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelIdNMB = new System.Windows.Forms.Label();
            this.TxtIdNMB = new System.Windows.Forms.TextBox();
            this.labelContactoID = new System.Windows.Forms.Label();
            this.TxtIdCuidador = new System.Windows.Forms.TextBox();
            this.labelTipoCuidador = new System.Windows.Forms.Label();
            this.ComboCuidador = new System.Windows.Forms.ComboBox();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.labelParentesco = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactCuidadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactCuidadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.Location = new System.Drawing.Point(12, 63);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(274, 24);
            this.labelContacto.TabIndex = 0;
            this.labelContacto.Text = "Seleccione el Tipo de Contacto";
            this.labelContacto.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la operacion a realizar";
            // 
            // ComboOperacion
            // 
            this.ComboOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboOperacion.FormattingEnabled = true;
            this.ComboOperacion.Items.AddRange(new object[] {
            "Agregar Contacto",
            "Editar Contacto",
            "Ver Contacto",
            "Buscar Contacto",
            "Agregar Relacion",
            "Imprimir"});
            this.ComboOperacion.Location = new System.Drawing.Point(330, 15);
            this.ComboOperacion.Name = "ComboOperacion";
            this.ComboOperacion.Size = new System.Drawing.Size(172, 32);
            this.ComboOperacion.TabIndex = 0;
            this.ComboOperacion.SelectedIndexChanged += new System.EventHandler(this.ComboOperacion_SelectedIndexChanged);
            this.ComboOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboCuidador_KeyPress);
            // 
            // ComboContacto
            // 
            this.ComboContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboContacto.FormattingEnabled = true;
            this.ComboContacto.Items.AddRange(new object[] {
            "NMB",
            "MMB",
            "Cuidador"});
            this.ComboContacto.Location = new System.Drawing.Point(330, 57);
            this.ComboContacto.Name = "ComboContacto";
            this.ComboContacto.Size = new System.Drawing.Size(172, 32);
            this.ComboContacto.TabIndex = 1;
            this.ComboContacto.Visible = false;
            this.ComboContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboCuidador_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(274, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(12, 100);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(223, 24);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "Ingrese el Id del Contacto";
            this.labelId.Visible = false;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(330, 100);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(172, 29);
            this.TxtId.TabIndex = 2;
            this.TxtId.Visible = false;
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedula.Location = new System.Drawing.Point(12, 100);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(162, 24);
            this.labelCedula.TabIndex = 8;
            this.labelCedula.Text = "Ingrese la Cedula ";
            this.labelCedula.Visible = false;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(330, 100);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(172, 29);
            this.TxtCedula.TabIndex = 2;
            this.TxtCedula.Visible = false;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.Parentesco});
            this.dataGridView1.DataSource = this.contactCuidadorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 79);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // Parentesco
            // 
            this.Parentesco.DataPropertyName = "Parentesco";
            this.Parentesco.HeaderText = "Parentesco";
            this.Parentesco.Name = "Parentesco";
            // 
            // labelIdNMB
            // 
            this.labelIdNMB.AutoSize = true;
            this.labelIdNMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdNMB.Location = new System.Drawing.Point(12, 105);
            this.labelIdNMB.Name = "labelIdNMB";
            this.labelIdNMB.Size = new System.Drawing.Size(191, 24);
            this.labelIdNMB.TabIndex = 11;
            this.labelIdNMB.Text = "Ingrese el Id del NMB";
            this.labelIdNMB.Visible = false;
            // 
            // TxtIdNMB
            // 
            this.TxtIdNMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdNMB.Location = new System.Drawing.Point(330, 100);
            this.TxtIdNMB.Name = "TxtIdNMB";
            this.TxtIdNMB.Size = new System.Drawing.Size(172, 29);
            this.TxtIdNMB.TabIndex = 2;
            this.TxtIdNMB.Visible = false;
            this.TxtIdNMB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdNMB_KeyPress);
            // 
            // labelContactoID
            // 
            this.labelContactoID.AutoSize = true;
            this.labelContactoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactoID.Location = new System.Drawing.Point(12, 137);
            this.labelContactoID.Name = "labelContactoID";
            this.labelContactoID.Size = new System.Drawing.Size(258, 24);
            this.labelContactoID.TabIndex = 13;
            this.labelContactoID.Text = "Seleccione el Id del Cuidador";
            this.labelContactoID.Visible = false;
            // 
            // TxtIdCuidador
            // 
            this.TxtIdCuidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCuidador.Location = new System.Drawing.Point(330, 137);
            this.TxtIdCuidador.Name = "TxtIdCuidador";
            this.TxtIdCuidador.Size = new System.Drawing.Size(172, 29);
            this.TxtIdCuidador.TabIndex = 3;
            this.TxtIdCuidador.Visible = false;
            this.TxtIdCuidador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdCuidador_KeyPress);
            // 
            // labelTipoCuidador
            // 
            this.labelTipoCuidador.AutoSize = true;
            this.labelTipoCuidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoCuidador.Location = new System.Drawing.Point(12, 60);
            this.labelTipoCuidador.Name = "labelTipoCuidador";
            this.labelTipoCuidador.Size = new System.Drawing.Size(277, 24);
            this.labelTipoCuidador.TabIndex = 15;
            this.labelTipoCuidador.Text = "Seleccione el Tipo de Cuidador";
            this.labelTipoCuidador.Visible = false;
            // 
            // ComboCuidador
            // 
            this.ComboCuidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCuidador.FormattingEnabled = true;
            this.ComboCuidador.Items.AddRange(new object[] {
            "MMB",
            "Cuidador"});
            this.ComboCuidador.Location = new System.Drawing.Point(330, 57);
            this.ComboCuidador.Name = "ComboCuidador";
            this.ComboCuidador.Size = new System.Drawing.Size(172, 32);
            this.ComboCuidador.TabIndex = 1;
            this.ComboCuidador.Visible = false;
            this.ComboCuidador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboCuidador_KeyPress);
            // 
            // txtParentesco
            // 
            this.txtParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentesco.Location = new System.Drawing.Point(330, 172);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Size = new System.Drawing.Size(172, 29);
            this.txtParentesco.TabIndex = 4;
            this.txtParentesco.Visible = false;
            this.txtParentesco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParentesco_KeyPress);
            // 
            // labelParentesco
            // 
            this.labelParentesco.AutoSize = true;
            this.labelParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParentesco.Location = new System.Drawing.Point(12, 171);
            this.labelParentesco.Name = "labelParentesco";
            this.labelParentesco.Size = new System.Drawing.Size(205, 24);
            this.labelParentesco.TabIndex = 17;
            this.labelParentesco.Text = "Seleccione Parentesco";
            this.labelParentesco.Visible = false;
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
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // contactCuidadorBindingSource
            // 
            this.contactCuidadorBindingSource.DataSource = typeof(MapaniApp.ContactCuidador);
            // 
            // Transcripcion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MapaniApp.Properties.Resources.Logotipo_Variaciones_39;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 391);
            this.Controls.Add(this.txtParentesco);
            this.Controls.Add(this.labelParentesco);
            this.Controls.Add(this.ComboCuidador);
            this.Controls.Add(this.labelTipoCuidador);
            this.Controls.Add(this.TxtIdCuidador);
            this.Controls.Add(this.labelContactoID);
            this.Controls.Add(this.TxtIdNMB);
            this.Controls.Add(this.labelIdNMB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboContacto);
            this.Controls.Add(this.ComboOperacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelContacto);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transcripcion";
            this.Text = "Transcripcion";
            this.Load += new System.EventHandler(this.Transcripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactCuidadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboOperacion;
        private System.Windows.Forms.ComboBox ComboContacto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contactCuidadorBindingSource;
        private System.Windows.Forms.Label labelIdNMB;
        private System.Windows.Forms.TextBox TxtIdNMB;
        private System.Windows.Forms.Label labelContactoID;
        private System.Windows.Forms.TextBox TxtIdCuidador;
        private System.Windows.Forms.Label labelTipoCuidador;
        private System.Windows.Forms.ComboBox ComboCuidador;
        private System.Windows.Forms.TextBox txtParentesco;
        private System.Windows.Forms.Label labelParentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parentesco;
    }
}