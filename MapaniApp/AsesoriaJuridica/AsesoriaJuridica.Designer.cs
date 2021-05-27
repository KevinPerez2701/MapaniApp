
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnVerDocumentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registro Beneficiarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cargar Documentos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnVerDocumentos
            // 
            this.BtnVerDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDocumentos.Location = new System.Drawing.Point(21, 186);
            this.BtnVerDocumentos.Name = "BtnVerDocumentos";
            this.BtnVerDocumentos.Size = new System.Drawing.Size(128, 64);
            this.BtnVerDocumentos.TabIndex = 2;
            this.BtnVerDocumentos.Text = "Ver Documentos";
            this.BtnVerDocumentos.UseVisualStyleBackColor = true;
            this.BtnVerDocumentos.Click += new System.EventHandler(this.BtnVerDocumentos_Click);
            // 
            // AsesoriaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVerDocumentos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AsesoriaJuridica";
            this.Text = "AsesoriaJuridica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnVerDocumentos;
    }
}