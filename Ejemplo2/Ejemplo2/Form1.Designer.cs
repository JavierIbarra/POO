namespace Ejemplo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.textBoxRut = new System.Windows.Forms.TextBox();
            this.labelRut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(90, 99);
            this.buttonVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(77, 36);
            this.buttonVerificar.TabIndex = 0;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // textBoxRut
            // 
            this.textBoxRut.Location = new System.Drawing.Point(120, 25);
            this.textBoxRut.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRut.Name = "textBoxRut";
            this.textBoxRut.Size = new System.Drawing.Size(132, 23);
            this.textBoxRut.TabIndex = 1;
            // 
            // labelRut
            // 
            this.labelRut.AutoSize = true;
            this.labelRut.Location = new System.Drawing.Point(33, 31);
            this.labelRut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRut.Name = "labelRut";
            this.labelRut.Size = new System.Drawing.Size(38, 17);
            this.labelRut.TabIndex = 2;
            this.labelRut.Text = "Rut: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 167);
            this.Controls.Add(this.labelRut);
            this.Controls.Add(this.textBoxRut);
            this.Controls.Add(this.buttonVerificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Verificador de RUT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.TextBox textBoxRut;
        private System.Windows.Forms.Label labelRut;
    }
}

