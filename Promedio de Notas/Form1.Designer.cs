namespace Promedio_de_Notas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.btnpromediar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promedio de Notas";
            // 
            // txtnota1
            // 
            this.txtnota1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota1.Location = new System.Drawing.Point(58, 158);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 25);
            this.txtnota1.TabIndex = 1;
            // 
            // txtnota2
            // 
            this.txtnota2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota2.Location = new System.Drawing.Point(58, 203);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 25);
            this.txtnota2.TabIndex = 2;
            // 
            // txtnota3
            // 
            this.txtnota3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota3.Location = new System.Drawing.Point(58, 252);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 25);
            this.txtnota3.TabIndex = 3;
            // 
            // btnpromediar
            // 
            this.btnpromediar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpromediar.Location = new System.Drawing.Point(222, 180);
            this.btnpromediar.Name = "btnpromediar";
            this.btnpromediar.Size = new System.Drawing.Size(94, 30);
            this.btnpromediar.TabIndex = 4;
            this.btnpromediar.Text = "Promediar";
            this.btnpromediar.UseVisualStyleBackColor = true;
            this.btnpromediar.Click += new System.EventHandler(this.btnpromediar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(54, 297);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(21, 22);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese 3 notas del estudiante:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Promedio_de_Notas.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(292, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "1.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "2.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "3.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(420, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnpromediar);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Promedio de Notas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Button btnpromediar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

