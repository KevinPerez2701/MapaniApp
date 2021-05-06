
namespace MapaniApp
{
    partial class Almacen
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAddAlmacen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver Productos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(205, 98);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(180, 67);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Agregar Producto Bodega";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(391, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Entregar Producto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAddAlmacen
            // 
            this.BtnAddAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAlmacen.Location = new System.Drawing.Point(19, 98);
            this.BtnAddAlmacen.Name = "BtnAddAlmacen";
            this.BtnAddAlmacen.Size = new System.Drawing.Size(180, 67);
            this.BtnAddAlmacen.TabIndex = 3;
            this.BtnAddAlmacen.Text = "Agregar Producto Almacen";
            this.BtnAddAlmacen.UseVisualStyleBackColor = true;
            this.BtnAddAlmacen.Click += new System.EventHandler(this.BtnAddAlmacen_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(205, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ver Bodega";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnAddAlmacen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.button1);
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAddAlmacen;
        private System.Windows.Forms.Button button3;
    }
}