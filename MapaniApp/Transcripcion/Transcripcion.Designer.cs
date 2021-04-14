
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboOperacion = new System.Windows.Forms.ComboBox();
            this.ComboContacto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Tipo de Contacto";
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
            "Ver Contacto"});
            this.ComboOperacion.Location = new System.Drawing.Point(317, 19);
            this.ComboOperacion.Name = "ComboOperacion";
            this.ComboOperacion.Size = new System.Drawing.Size(172, 32);
            this.ComboOperacion.TabIndex = 2;
            this.ComboOperacion.SelectedIndexChanged += new System.EventHandler(this.ComboOperacion_SelectedIndexChanged);
            // 
            // ComboContacto
            // 
            this.ComboContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboContacto.FormattingEnabled = true;
            this.ComboContacto.Items.AddRange(new object[] {
            "NMB",
            "MMB",
            "Cuidador"});
            this.ComboContacto.Location = new System.Drawing.Point(317, 60);
            this.ComboContacto.Name = "ComboContacto";
            this.ComboContacto.Size = new System.Drawing.Size(172, 32);
            this.ComboContacto.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(270, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(12, 105);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(223, 24);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "Ingrese el Id del Contacto";
            this.labelId.Visible = false;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(317, 105);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(172, 29);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // Transcripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 246);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboContacto);
            this.Controls.Add(this.ComboOperacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transcripcion";
            this.Text = "Transcripcion";
            this.Load += new System.EventHandler(this.Transcripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboOperacion;
        private System.Windows.Forms.ComboBox ComboContacto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox TxtId;
    }
}