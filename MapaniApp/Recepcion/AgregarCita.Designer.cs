
namespace MapaniApp
{
    partial class AgregarCita
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAgregarCita = new System.Windows.Forms.Button();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DateCita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(230, 145);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(145, 34);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAgregarCita
            // 
            this.BtnAgregarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCita.Location = new System.Drawing.Point(74, 145);
            this.BtnAgregarCita.Name = "BtnAgregarCita";
            this.BtnAgregarCita.Size = new System.Drawing.Size(126, 33);
            this.BtnAgregarCita.TabIndex = 14;
            this.BtnAgregarCita.Text = "Agregar Cita";
            this.BtnAgregarCita.UseVisualStyleBackColor = true;
            this.BtnAgregarCita.Click += new System.EventHandler(this.BtnAgregarCita_Click);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Items.AddRange(new object[] {
            "Pediatria",
            "Nutricion",
            "Psicologia"});
            this.comboDepartamento.Location = new System.Drawing.Point(253, 90);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(134, 32);
            this.comboDepartamento.TabIndex = 13;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(253, 22);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(134, 29);
            this.TxtId.TabIndex = 12;
            // 
            // DateCita
            // 
            this.DateCita.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateCita.Location = new System.Drawing.Point(253, 57);
            this.DateCita.Name = "DateCita";
            this.DateCita.Size = new System.Drawing.Size(134, 29);
            this.DateCita.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inserte el Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inserte Fecha de la cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inserte Id NMB";
            // 
            // AgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 199);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregarCita);
            this.Controls.Add(this.comboDepartamento);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DateCita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarCita";
            this.Text = "AgregarCita";
            this.Load += new System.EventHandler(this.AgregarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAgregarCita;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DateTimePicker DateCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}