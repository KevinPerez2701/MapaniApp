
namespace MapaniApp
{
    partial class AddOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrden));
            this.TxtIdNMB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboPediatra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrograma = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddOrden = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtIdNMB
            // 
            resources.ApplyResources(this.TxtIdNMB, "TxtIdNMB");
            this.TxtIdNMB.Name = "TxtIdNMB";
            this.TxtIdNMB.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // TxtCantidad
            // 
            resources.ApplyResources(this.TxtCantidad, "TxtCantidad");
            this.TxtCantidad.Name = "TxtCantidad";
            // 
            // TxtNombre
            // 
            resources.ApplyResources(this.TxtNombre, "TxtNombre");
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // ComboPediatra
            // 
            resources.ApplyResources(this.ComboPediatra, "ComboPediatra");
            this.ComboPediatra.FormattingEnabled = true;
            this.ComboPediatra.Items.AddRange(new object[] {
            resources.GetString("ComboPediatra.Items"),
            resources.GetString("ComboPediatra.Items1")});
            this.ComboPediatra.Name = "ComboPediatra";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // TxtPrograma
            // 
            resources.ApplyResources(this.TxtPrograma, "TxtPrograma");
            this.TxtPrograma.Name = "TxtPrograma";
            this.TxtPrograma.ReadOnly = true;
            // 
            // TxtIdProducto
            // 
            resources.ApplyResources(this.TxtIdProducto, "TxtIdProducto");
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // BtnAddOrden
            // 
            resources.ApplyResources(this.BtnAddOrden, "BtnAddOrden");
            this.BtnAddOrden.Name = "BtnAddOrden";
            this.BtnAddOrden.UseVisualStyleBackColor = true;
            this.BtnAddOrden.Click += new System.EventHandler(this.BtnAddOrden_Click);
            // 
            // BtnSalir
            // 
            resources.ApplyResources(this.BtnSalir, "BtnSalir");
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // txtCantidadDisponible
            // 
            resources.ApplyResources(this.txtCantidadDisponible, "txtCantidadDisponible");
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            // 
            // AddOrden
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidadDisponible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAddOrden);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPrograma);
            this.Controls.Add(this.ComboPediatra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdNMB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrden";
            this.Load += new System.EventHandler(this.AddOrden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdNMB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboPediatra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrograma;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAddOrden;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
    }
}