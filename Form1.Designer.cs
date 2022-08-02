namespace Calculadora_de_IMC
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnCalculoImc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o seu peso";
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(16, 80);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(137, 20);
            this.tbPeso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado do IMC";
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(16, 200);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(137, 20);
            this.tbResultado.TabIndex = 4;
            this.tbResultado.TextChanged += new System.EventHandler(this.tbResultado_TextChanged);
            // 
            // btnCalculoImc
            // 
            this.btnCalculoImc.Location = new System.Drawing.Point(16, 150);
            this.btnCalculoImc.Name = "btnCalculoImc";
            this.btnCalculoImc.Size = new System.Drawing.Size(137, 23);
            this.btnCalculoImc.TabIndex = 5;
            this.btnCalculoImc.Text = "Calcular IMC";
            this.btnCalculoImc.UseVisualStyleBackColor = true;
            this.btnCalculoImc.Click += new System.EventHandler(this.btnCalculoImc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite sua altura";
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(16, 124);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(137, 20);
            this.tbAltura.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 235);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculoImc);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnCalculoImc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAltura;
    }
}

