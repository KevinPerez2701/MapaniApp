
namespace MapaniApp
{
    partial class AsesoriaJuridica
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
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.BtnCargarDocumentos = new System.Windows.Forms.Button();
            this.BtnVerDocumentos = new System.Windows.Forms.Button();
            this.BtnGestionCasos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.Location = new System.Drawing.Point(21, 23);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(130, 68);
            this.BtnRegistro.TabIndex = 0;
            this.BtnRegistro.Text = "Registro Beneficiarios";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCargarDocumentos
            // 
            this.BtnCargarDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarDocumentos.Location = new System.Drawing.Point(157, 23);
            this.BtnCargarDocumentos.Name = "BtnCargarDocumentos";
            this.BtnCargarDocumentos.Size = new System.Drawing.Size(128, 68);
            this.BtnCargarDocumentos.TabIndex = 1;
            this.BtnCargarDocumentos.Text = "Cargar Documentos";
            this.BtnCargarDocumentos.UseVisualStyleBackColor = true;
            this.BtnCargarDocumentos.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnVerDocumentos
            // 
            this.BtnVerDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDocumentos.Location = new System.Drawing.Point(291, 23);
            this.BtnVerDocumentos.Name = "BtnVerDocumentos";
            this.BtnVerDocumentos.Size = new System.Drawing.Size(128, 68);
            this.BtnVerDocumentos.TabIndex = 2;
            this.BtnVerDocumentos.Text = "Ver Documentos";
            this.BtnVerDocumentos.UseVisualStyleBackColor = true;
            this.BtnVerDocumentos.Click += new System.EventHandler(this.BtnVerDocumentos_Click);
            // 
            // BtnGestionCasos
            // 
            this.BtnGestionCasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionCasos.Location = new System.Drawing.Point(425, 23);
            this.BtnGestionCasos.Name = "BtnGestionCasos";
            this.BtnGestionCasos.Size = new System.Drawing.Size(128, 68);
            this.BtnGestionCasos.TabIndex = 3;
            this.BtnGestionCasos.Text = "Gestion de Casos";
            this.BtnGestionCasos.UseVisualStyleBackColor = true;
            this.BtnGestionCasos.Click += new System.EventHandler(this.BtnGestionCasos_Click);
            // 
            // AsesoriaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 119);
            this.Controls.Add(this.BtnGestionCasos);
            this.Controls.Add(this.BtnVerDocumentos);
            this.Controls.Add(this.BtnCargarDocumentos);
            this.Controls.Add(this.BtnRegistro);
            this.Name = "AsesoriaJuridica";
            this.Text = "AsesoriaJuridica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Button BtnCargarDocumentos;
        private System.Windows.Forms.Button BtnVerDocumentos;
        private System.Windows.Forms.Button BtnGestionCasos;
    }
}