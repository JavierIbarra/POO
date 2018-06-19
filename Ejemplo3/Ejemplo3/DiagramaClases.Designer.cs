namespace Ejemplo3
{
    partial class DiagramaClases
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
            this.label5 = new System.Windows.Forms.Label();
            this.listparametros = new System.Windows.Forms.ListBox();
            this.ClaseAnt = new System.Windows.Forms.Button();
            this.ClaseSig = new System.Windows.Forms.Button();
            this.NClase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listAtributos = new System.Windows.Forms.ListBox();
            this.listMetodos = new System.Windows.Forms.ListBox();
            this.listClases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Constructores";
            // 
            // listparametros
            // 
            this.listparametros.FormattingEnabled = true;
            this.listparametros.ItemHeight = 16;
            this.listparametros.Location = new System.Drawing.Point(25, 345);
            this.listparametros.Name = "listparametros";
            this.listparametros.Size = new System.Drawing.Size(1116, 116);
            this.listparametros.TabIndex = 22;
            // 
            // ClaseAnt
            // 
            this.ClaseAnt.BackColor = System.Drawing.Color.Maroon;
            this.ClaseAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClaseAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaseAnt.Location = new System.Drawing.Point(365, 489);
            this.ClaseAnt.Name = "ClaseAnt";
            this.ClaseAnt.Size = new System.Drawing.Size(182, 59);
            this.ClaseAnt.TabIndex = 21;
            this.ClaseAnt.Text = "Clase Anterior";
            this.ClaseAnt.UseVisualStyleBackColor = false;
            this.ClaseAnt.Click += new System.EventHandler(this.ClaseAnt_Click);
            // 
            // ClaseSig
            // 
            this.ClaseSig.BackColor = System.Drawing.Color.Green;
            this.ClaseSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClaseSig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaseSig.Location = new System.Drawing.Point(657, 489);
            this.ClaseSig.Name = "ClaseSig";
            this.ClaseSig.Size = new System.Drawing.Size(182, 59);
            this.ClaseSig.TabIndex = 20;
            this.ClaseSig.Text = "Clase Siguiente";
            this.ClaseSig.UseVisualStyleBackColor = false;
            this.ClaseSig.Click += new System.EventHandler(this.ClaseSig_Click);
            // 
            // NClase
            // 
            this.NClase.AutoSize = true;
            this.NClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NClase.Location = new System.Drawing.Point(20, 22);
            this.NClase.Name = "NClase";
            this.NClase.Size = new System.Drawing.Size(87, 29);
            this.NClase.TabIndex = 19;
            this.NClase.Text = "Clase: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lista Atributos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista Metodos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lista Clases";
            // 
            // listAtributos
            // 
            this.listAtributos.FormattingEnabled = true;
            this.listAtributos.ItemHeight = 16;
            this.listAtributos.Location = new System.Drawing.Point(840, 96);
            this.listAtributos.Name = "listAtributos";
            this.listAtributos.Size = new System.Drawing.Size(293, 196);
            this.listAtributos.TabIndex = 15;
            // 
            // listMetodos
            // 
            this.listMetodos.FormattingEnabled = true;
            this.listMetodos.ItemHeight = 16;
            this.listMetodos.Location = new System.Drawing.Point(422, 96);
            this.listMetodos.Name = "listMetodos";
            this.listMetodos.Size = new System.Drawing.Size(293, 196);
            this.listMetodos.TabIndex = 14;
            // 
            // listClases
            // 
            this.listClases.FormattingEnabled = true;
            this.listClases.ItemHeight = 16;
            this.listClases.Location = new System.Drawing.Point(22, 96);
            this.listClases.Name = "listClases";
            this.listClases.Size = new System.Drawing.Size(278, 196);
            this.listClases.TabIndex = 13;
            // 
            // DiagramaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listparametros);
            this.Controls.Add(this.ClaseAnt);
            this.Controls.Add(this.ClaseSig);
            this.Controls.Add(this.NClase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAtributos);
            this.Controls.Add(this.listMetodos);
            this.Controls.Add(this.listClases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagramaClases";
            this.Text = "DiagramaClases";
            this.Load += new System.EventHandler(this.DiagramaClases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listparametros;
        private System.Windows.Forms.Button ClaseAnt;
        private System.Windows.Forms.Button ClaseSig;
        private System.Windows.Forms.Label NClase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAtributos;
        private System.Windows.Forms.ListBox listMetodos;
        private System.Windows.Forms.ListBox listClases;
    }
}