
namespace MapaniApp
{
    partial class EvaluacionInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluacionInicial));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtEvaluacionInicial = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAntecedentes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEvaluacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSistemaAuxiliar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSinRiesgo = new System.Windows.Forms.TextBox();
            this.txtRiesgoBajo = new System.Windows.Forms.TextBox();
            this.txtRiesgoMedio = new System.Windows.Forms.TextBox();
            this.txtRiesgoAlto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtEvaluacionInicial);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtAntecedentes);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.txtEvaluacion);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.TxtMotivoConsulta);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtSistemaAuxiliar);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtSinRiesgo);
            this.splitContainer1.Panel2.Controls.Add(this.txtRiesgoBajo);
            this.splitContainer1.Panel2.Controls.Add(this.txtRiesgoMedio);
            this.splitContainer1.Panel2.Controls.Add(this.txtRiesgoAlto);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.checkedListBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 712);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtEvaluacionInicial
            // 
            this.txtEvaluacionInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvaluacionInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvaluacionInicial.Location = new System.Drawing.Point(0, 25);
            this.txtEvaluacionInicial.Multiline = true;
            this.txtEvaluacionInicial.Name = "txtEvaluacionInicial";
            this.txtEvaluacionInicial.Size = new System.Drawing.Size(1106, 289);
            this.txtEvaluacionInicial.TabIndex = 109;
            this.txtEvaluacionInicial.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ColumnWidth = 500;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Abuso Fisico/Violencia",
            "Abuso Sexual/Violencia",
            "Violacion",
            "Abuso/Violencia Emocional o Psicologica",
            "Neglicencia",
            "Abandono",
            "Trabajo Infantil (No en sus peores formas)",
            "Trabajo Peligroso",
            "Explotacion Sexual",
            "Esclavitud/Venta/Secuestro/Trata/Trabajo Forzoso",
            "En conflicto con la ley",
            "Asociado con fuerzas armadas o grupos",
            "Privado de libertad/en detencion",
            "Condicion Medica Grave",
            "Dificultad Funcional (Vista, incluso si usa lentes)",
            "Dificultad Funcional (Audicion, inscluso si usa audifonos)",
            "Dificultad Funcional (Caminar o usar partes de su cuerpo)",
            "Dificultad Funcional (recordar o concentrarse)",
            "Dificultad para cuidarse a si mismo, como alimentarse o vestirse",
            "Dificultad para comunicarse",
            "No acompañado",
            "Separado",
            "Huerfano",
            "DIficultad Psicosocial",
            "Trastorno Mental",
            "Abuso de sustancias y adiccion (niño)",
            "Pertenece al grupo marginado/discriminado",
            "Falta de documentacion/registro de nacimiento",
            "Matrimonio infantil",
            "Mutilacion Genital Femenina (MGF)",
            "Embarazo/Hijo Padre",
            "Denegacion de recursos, oportunidades o servicios",
            "Acuerdo de cuidado altamente Vulnerable",
            "Niño Sobreviviente de dispositivo Explosivo (DE)",
            "Otros, por favor especificar:"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 25);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(1106, 289);
            this.checkedListBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtAntecedentes
            // 
            this.txtAntecedentes.Location = new System.Drawing.Point(761, 293);
            this.txtAntecedentes.Multiline = true;
            this.txtAntecedentes.Name = "txtAntecedentes";
            this.txtAntecedentes.Size = new System.Drawing.Size(333, 89);
            this.txtAntecedentes.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(634, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 115;
            this.label10.Text = "Antecedentes";
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.Location = new System.Drawing.Point(761, 198);
            this.txtEvaluacion.Multiline = true;
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(333, 89);
            this.txtEvaluacion.TabIndex = 112;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(634, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 111;
            this.label11.Text = "Evaluacion";
            // 
            // TxtMotivoConsulta
            // 
            this.TxtMotivoConsulta.Location = new System.Drawing.Point(202, 293);
            this.TxtMotivoConsulta.Multiline = true;
            this.TxtMotivoConsulta.Name = "TxtMotivoConsulta";
            this.TxtMotivoConsulta.Size = new System.Drawing.Size(426, 89);
            this.TxtMotivoConsulta.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 109;
            this.label9.Text = "Motivo Consulta";
            // 
            // txtSistemaAuxiliar
            // 
            this.txtSistemaAuxiliar.Location = new System.Drawing.Point(202, 198);
            this.txtSistemaAuxiliar.Multiline = true;
            this.txtSistemaAuxiliar.Name = "txtSistemaAuxiliar";
            this.txtSistemaAuxiliar.Size = new System.Drawing.Size(426, 89);
            this.txtSistemaAuxiliar.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 24);
            this.label8.TabIndex = 107;
            this.label8.Text = "Sistema Familiar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resumen de Razones";
            // 
            // txtSinRiesgo
            // 
            this.txtSinRiesgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinRiesgo.Location = new System.Drawing.Point(146, 163);
            this.txtSinRiesgo.Name = "txtSinRiesgo";
            this.txtSinRiesgo.Size = new System.Drawing.Size(948, 29);
            this.txtSinRiesgo.TabIndex = 5;
            // 
            // txtRiesgoBajo
            // 
            this.txtRiesgoBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiesgoBajo.Location = new System.Drawing.Point(146, 128);
            this.txtRiesgoBajo.Name = "txtRiesgoBajo";
            this.txtRiesgoBajo.Size = new System.Drawing.Size(948, 29);
            this.txtRiesgoBajo.TabIndex = 4;
            // 
            // txtRiesgoMedio
            // 
            this.txtRiesgoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiesgoMedio.Location = new System.Drawing.Point(146, 93);
            this.txtRiesgoMedio.Name = "txtRiesgoMedio";
            this.txtRiesgoMedio.Size = new System.Drawing.Size(948, 29);
            this.txtRiesgoMedio.TabIndex = 3;
            // 
            // txtRiesgoAlto
            // 
            this.txtRiesgoAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiesgoAlto.Location = new System.Drawing.Point(146, 58);
            this.txtRiesgoAlto.Name = "txtRiesgoAlto";
            this.txtRiesgoAlto.Size = new System.Drawing.Size(948, 29);
            this.txtRiesgoAlto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nivel de Riesgo";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo",
            "No"});
            this.checkedListBox2.Location = new System.Drawing.Point(33, 58);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(98, 124);
            this.checkedListBox2.TabIndex = 0;
            // 
            // EvaluacionInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 712);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EvaluacionInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvaluacionInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtRiesgoAlto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.TextBox txtRiesgoMedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSinRiesgo;
        private System.Windows.Forms.TextBox txtRiesgoBajo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEvaluacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtMotivoConsulta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSistemaAuxiliar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAntecedentes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEvaluacionInicial;
    }
}