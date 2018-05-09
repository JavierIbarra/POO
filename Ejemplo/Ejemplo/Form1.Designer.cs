namespace Ejemplo
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
            this.ButtonVerificar = new System.Windows.Forms.Button();
            this.LabelRut = new System.Windows.Forms.Label();
            this.TextBox_Rut = new System.Windows.Forms.TextBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.ButtonRegistrar = new System.Windows.Forms.Button();
            this.ButtonOcultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonVerificar
            // 
            this.ButtonVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVerificar.Location = new System.Drawing.Point(308, 235);
            this.ButtonVerificar.Name = "ButtonVerificar";
            this.ButtonVerificar.Size = new System.Drawing.Size(85, 42);
            this.ButtonVerificar.TabIndex = 0;
            this.ButtonVerificar.Text = "Verificar";
            this.ButtonVerificar.UseVisualStyleBackColor = true;
            this.ButtonVerificar.Click += new System.EventHandler(this.ButtonVerificar_Click);
            // 
            // LabelRut
            // 
            this.LabelRut.AutoSize = true;
            this.LabelRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRut.Location = new System.Drawing.Point(249, 104);
            this.LabelRut.Name = "LabelRut";
            this.LabelRut.Size = new System.Drawing.Size(30, 17);
            this.LabelRut.TabIndex = 1;
            this.LabelRut.Text = "Rut";
            // 
            // TextBox_Rut
            // 
            this.TextBox_Rut.Location = new System.Drawing.Point(321, 101);
            this.TextBox_Rut.Name = "TextBox_Rut";
            this.TextBox_Rut.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Rut.TabIndex = 2;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(302, 22);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(91, 37);
            this.LabelTitulo.TabIndex = 3;
            this.LabelTitulo.Text = "Inicio";
            // 
            // ButtonRegistrar
            // 
            this.ButtonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegistrar.Location = new System.Drawing.Point(95, 235);
            this.ButtonRegistrar.Name = "ButtonRegistrar";
            this.ButtonRegistrar.Size = new System.Drawing.Size(85, 42);
            this.ButtonRegistrar.TabIndex = 4;
            this.ButtonRegistrar.Text = "Registrar";
            this.ButtonRegistrar.UseVisualStyleBackColor = true;
            this.ButtonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // ButtonOcultar
            // 
            this.ButtonOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOcultar.Location = new System.Drawing.Point(526, 235);
            this.ButtonOcultar.Name = "ButtonOcultar";
            this.ButtonOcultar.Size = new System.Drawing.Size(85, 42);
            this.ButtonOcultar.TabIndex = 5;
            this.ButtonOcultar.Text = "Ocultar";
            this.ButtonOcultar.UseVisualStyleBackColor = true;
            this.ButtonOcultar.Click += new System.EventHandler(this.ButtonOcultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 445);
            this.Controls.Add(this.ButtonOcultar);
            this.Controls.Add(this.ButtonRegistrar);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.TextBox_Rut);
            this.Controls.Add(this.LabelRut);
            this.Controls.Add(this.ButtonVerificar);
            this.Name = "Form1";
            this.Text = "Ejemplo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonVerificar;
        private System.Windows.Forms.Label LabelRut;
        private System.Windows.Forms.TextBox TextBox_Rut;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Button ButtonRegistrar;
        private System.Windows.Forms.Button ButtonOcultar;
    }
}

