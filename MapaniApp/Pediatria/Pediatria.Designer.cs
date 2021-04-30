
namespace MapaniApp
{
    partial class Pediatria
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
            this.BtnCargarContacto = new System.Windows.Forms.Button();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboPrograma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.groupBase = new System.Windows.Forms.GroupBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.ComboEdema = new System.Windows.Forms.ComboBox();
            this.labelEdema = new System.Windows.Forms.Label();
            this.labelTalla = new System.Windows.Forms.Label();
            this.TxtTalla = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPesoTalla = new System.Windows.Forms.TextBox();
            this.TxtPesoEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtImc = new System.Windows.Forms.TextBox();
            this.TxtTallaEdad = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.groupBase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCargarContacto
            // 
            this.BtnCargarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarContacto.Location = new System.Drawing.Point(12, 92);
            this.BtnCargarContacto.Name = "BtnCargarContacto";
            this.BtnCargarContacto.Size = new System.Drawing.Size(171, 49);
            this.BtnCargarContacto.TabIndex = 91;
            this.BtnCargarContacto.Text = "Cargar Contacto";
            this.BtnCargarContacto.UseVisualStyleBackColor = true;
            this.BtnCargarContacto.Click += new System.EventHandler(this.BtnCargarContacto_Click);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(601, 114);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(173, 29);
            this.TxtEdad.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(478, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 24);
            this.label13.TabIndex = 89;
            this.label13.Text = "Edad";
            // 
            // comboPrograma
            // 
            this.comboPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPrograma.FormattingEnabled = true;
            this.comboPrograma.Items.AddRange(new object[] {
            "IRC",
            "Ponte Poronte"});
            this.comboPrograma.Location = new System.Drawing.Point(272, 46);
            this.comboPrograma.Name = "comboPrograma";
            this.comboPrograma.Size = new System.Drawing.Size(121, 32);
            this.comboPrograma.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 24);
            this.label6.TabIndex = 87;
            this.label6.Text = "Seleccione el Programa";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(272, 11);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(121, 29);
            this.TxtID.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "Ingrese el ID del usuario";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(644, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 29);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 83;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(601, 41);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(173, 29);
            this.TxtApellido.TabIndex = 82;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(601, 6);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(173, 29);
            this.TxtNombre.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "Nombre";
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddOrder.Location = new System.Drawing.Point(208, 87);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(171, 59);
            this.BtnAddOrder.TabIndex = 92;
            this.BtnAddOrder.Text = "Agregar Medicamentos";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            this.BtnAddOrder.Visible = false;
            this.BtnAddOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBase
            // 
            this.groupBase.Controls.Add(this.labelPeso);
            this.groupBase.Controls.Add(this.ComboEdema);
            this.groupBase.Controls.Add(this.labelEdema);
            this.groupBase.Controls.Add(this.labelTalla);
            this.groupBase.Controls.Add(this.TxtTalla);
            this.groupBase.Controls.Add(this.TxtPeso);
            this.groupBase.Location = new System.Drawing.Point(16, 152);
            this.groupBase.Name = "groupBase";
            this.groupBase.Size = new System.Drawing.Size(452, 134);
            this.groupBase.TabIndex = 93;
            this.groupBase.TabStop = false;
            this.groupBase.Text = "GroupBase";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(16, 28);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(53, 24);
            this.labelPeso.TabIndex = 69;
            this.labelPeso.Tag = "Contact";
            this.labelPeso.Text = "Peso";
            // 
            // ComboEdema
            // 
            this.ComboEdema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEdema.FormattingEnabled = true;
            this.ComboEdema.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.ComboEdema.Location = new System.Drawing.Point(268, 96);
            this.ComboEdema.Name = "ComboEdema";
            this.ComboEdema.Size = new System.Drawing.Size(173, 32);
            this.ComboEdema.TabIndex = 87;
            this.ComboEdema.Tag = "Contact";
            // 
            // labelEdema
            // 
            this.labelEdema.AutoSize = true;
            this.labelEdema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdema.Location = new System.Drawing.Point(16, 96);
            this.labelEdema.Name = "labelEdema";
            this.labelEdema.Size = new System.Drawing.Size(54, 24);
            this.labelEdema.TabIndex = 77;
            this.labelEdema.Tag = "Contact";
            this.labelEdema.Text = "Sexo";
            // 
            // labelTalla
            // 
            this.labelTalla.AutoSize = true;
            this.labelTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTalla.Location = new System.Drawing.Point(16, 63);
            this.labelTalla.Name = "labelTalla";
            this.labelTalla.Size = new System.Drawing.Size(50, 24);
            this.labelTalla.TabIndex = 79;
            this.labelTalla.Tag = "Contact";
            this.labelTalla.Text = "Talla";
            // 
            // TxtTalla
            // 
            this.TxtTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTalla.Location = new System.Drawing.Point(268, 58);
            this.TxtTalla.Name = "TxtTalla";
            this.TxtTalla.Size = new System.Drawing.Size(173, 29);
            this.TxtTalla.TabIndex = 81;
            this.TxtTalla.Tag = "Contact";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeso.Location = new System.Drawing.Point(268, 23);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(173, 29);
            this.TxtPeso.TabIndex = 80;
            this.TxtPeso.Tag = "Contact";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtImc);
            this.groupBox1.Controls.Add(this.TxtTallaEdad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtPesoTalla);
            this.groupBox1.Controls.Add(this.TxtPesoEdad);
            this.groupBox1.Location = new System.Drawing.Point(16, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 179);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 69;
            this.label1.Tag = "Contact";
            this.label1.Text = "Peso-Edad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 79;
            this.label8.Tag = "Contact";
            this.label8.Text = "Peso-Talla";
            // 
            // TxtPesoTalla
            // 
            this.TxtPesoTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesoTalla.Location = new System.Drawing.Point(268, 19);
            this.TxtPesoTalla.Name = "TxtPesoTalla";
            this.TxtPesoTalla.Size = new System.Drawing.Size(173, 29);
            this.TxtPesoTalla.TabIndex = 81;
            this.TxtPesoTalla.Tag = "Contact";
            // 
            // TxtPesoEdad
            // 
            this.TxtPesoEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesoEdad.Location = new System.Drawing.Point(268, 54);
            this.TxtPesoEdad.Name = "TxtPesoEdad";
            this.TxtPesoEdad.Size = new System.Drawing.Size(173, 29);
            this.TxtPesoEdad.TabIndex = 80;
            this.TxtPesoEdad.Tag = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 82;
            this.label3.Tag = "Contact";
            this.label3.Text = "Talla-Edad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 24);
            this.label9.TabIndex = 83;
            this.label9.Tag = "Contact";
            this.label9.Text = "IMC";
            // 
            // TxtImc
            // 
            this.TxtImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImc.Location = new System.Drawing.Point(268, 128);
            this.TxtImc.Name = "TxtImc";
            this.TxtImc.Size = new System.Drawing.Size(173, 29);
            this.TxtImc.TabIndex = 85;
            this.TxtImc.Tag = "Contact";
            // 
            // TxtTallaEdad
            // 
            this.TxtTallaEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTallaEdad.Location = new System.Drawing.Point(268, 93);
            this.TxtTallaEdad.Name = "TxtTallaEdad";
            this.TxtTallaEdad.Size = new System.Drawing.Size(173, 29);
            this.TxtTallaEdad.TabIndex = 84;
            this.TxtTallaEdad.Tag = "Contact";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(488, 197);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(92, 41);
            this.BtnCalcular.TabIndex = 95;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Pediatria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBase);
            this.Controls.Add(this.BtnAddOrder);
            this.Controls.Add(this.BtnCargarContacto);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboPrograma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "Pediatria";
            this.Text = "Pediatria";
            this.Load += new System.EventHandler(this.Pediatria_Load);
            this.groupBase.ResumeLayout(false);
            this.groupBase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarContacto;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboPrograma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddOrder;
        private System.Windows.Forms.GroupBox groupBase;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.ComboBox ComboEdema;
        private System.Windows.Forms.Label labelEdema;
        private System.Windows.Forms.Label labelTalla;
        private System.Windows.Forms.TextBox TxtTalla;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtImc;
        private System.Windows.Forms.TextBox TxtTallaEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPesoTalla;
        private System.Windows.Forms.TextBox TxtPesoEdad;
        private System.Windows.Forms.Button BtnCalcular;
    }
}