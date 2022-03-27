
namespace MapaniApp
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.datetimeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLote = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPrograma = new System.Windows.Forms.ComboBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.groupCantidad = new System.Windows.Forms.GroupBox();
            this.GroupAdd.SuspendLayout();
            this.groupCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdProducto.Location = new System.Drawing.Point(182, 18);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(110, 29);
            this.TxtIdProducto.TabIndex = 41;
            // 
            // datetimeVencimiento
            // 
            this.datetimeVencimiento.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.datetimeVencimiento.Checked = false;
            this.datetimeVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeVencimiento.Location = new System.Drawing.Point(305, 122);
            this.datetimeVencimiento.Name = "datetimeVencimiento";
            this.datetimeVencimiento.Size = new System.Drawing.Size(110, 29);
            this.datetimeVencimiento.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Id Producto";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(189, 157);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(226, 63);
            this.TxtDescripcion.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // TxtLote
            // 
            this.TxtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLote.Location = new System.Drawing.Point(189, 88);
            this.TxtLote.Name = "TxtLote";
            this.TxtLote.Size = new System.Drawing.Size(226, 29);
            this.TxtLote.TabIndex = 35;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(189, 17);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(226, 29);
            this.TxtNombre.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Lote";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(305, 24);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(110, 29);
            this.TxtCantidad.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 44;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(253, 384);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(82, 39);
            this.BtnSalir.TabIndex = 45;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Programa";
            // 
            // comboPrograma
            // 
            this.comboPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPrograma.FormattingEnabled = true;
            this.comboPrograma.Items.AddRange(new object[] {
            "IRC",
            "MAPANI",
            "Porte Poronte",
            "Accion Solidaria"});
            this.comboPrograma.Location = new System.Drawing.Point(189, 52);
            this.comboPrograma.Name = "comboPrograma";
            this.comboPrograma.Size = new System.Drawing.Size(226, 32);
            this.comboPrograma.TabIndex = 47;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(313, 12);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(95, 36);
            this.BtnCargar.TabIndex = 48;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // GroupAdd
            // 
            this.GroupAdd.Controls.Add(this.label1);
            this.GroupAdd.Controls.Add(this.label2);
            this.GroupAdd.Controls.Add(this.comboPrograma);
            this.GroupAdd.Controls.Add(this.TxtNombre);
            this.GroupAdd.Controls.Add(this.label7);
            this.GroupAdd.Controls.Add(this.TxtLote);
            this.GroupAdd.Controls.Add(this.label4);
            this.GroupAdd.Controls.Add(this.label3);
            this.GroupAdd.Controls.Add(this.TxtDescripcion);
            this.GroupAdd.Controls.Add(this.datetimeVencimiento);
            this.GroupAdd.Location = new System.Drawing.Point(16, 54);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(447, 246);
            this.GroupAdd.TabIndex = 49;
            this.GroupAdd.TabStop = false;
            this.GroupAdd.Text = "Nuevo Producto";
            this.GroupAdd.Visible = false;
            // 
            // groupCantidad
            // 
            this.groupCantidad.Controls.Add(this.label6);
            this.groupCantidad.Controls.Add(this.TxtCantidad);
            this.groupCantidad.Location = new System.Drawing.Point(16, 306);
            this.groupCantidad.Name = "groupCantidad";
            this.groupCantidad.Size = new System.Drawing.Size(447, 67);
            this.groupCantidad.TabIndex = 50;
            this.groupCantidad.TabStop = false;
            this.groupCantidad.Text = "Cantidad ";
            this.groupCantidad.Visible = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.groupCantidad);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.GroupAdd.ResumeLayout(false);
            this.GroupAdd.PerformLayout();
            this.groupCantidad.ResumeLayout(false);
            this.groupCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.DateTimePicker datetimeVencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLote;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPrograma;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.GroupBox GroupAdd;
        private System.Windows.Forms.GroupBox groupCantidad;
    }
}