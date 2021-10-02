
namespace d11
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
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_altura = new System.Windows.Forms.TextBox();
            this.radio_homem = new System.Windows.Forms.RadioButton();
            this.radio_mulher = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_peso_atual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Location = new System.Drawing.Point(156, 256);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(266, 47);
            this.cmd_calcular.TabIndex = 0;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cálculo do Peso Ideal";
            // 
            // text_altura
            // 
            this.text_altura.Location = new System.Drawing.Point(158, 196);
            this.text_altura.Name = "text_altura";
            this.text_altura.Size = new System.Drawing.Size(101, 22);
            this.text_altura.TabIndex = 2;
            this.text_altura.TextChanged += new System.EventHandler(this.text_altura_TextChanged);
            // 
            // radio_homem
            // 
            this.radio_homem.AutoSize = true;
            this.radio_homem.Checked = true;
            this.radio_homem.Location = new System.Drawing.Point(158, 124);
            this.radio_homem.Name = "radio_homem";
            this.radio_homem.Size = new System.Drawing.Size(77, 21);
            this.radio_homem.TabIndex = 3;
            this.radio_homem.TabStop = true;
            this.radio_homem.Text = "Homem";
            this.radio_homem.UseVisualStyleBackColor = true;
            // 
            // radio_mulher
            // 
            this.radio_mulher.AutoSize = true;
            this.radio_mulher.Location = new System.Drawing.Point(352, 124);
            this.radio_mulher.Name = "radio_mulher";
            this.radio_mulher.Size = new System.Drawing.Size(72, 21);
            this.radio_mulher.TabIndex = 4;
            this.radio_mulher.Text = "Mulher";
            this.radio_mulher.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura (metros):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Peso (Kg.):";
            // 
            // text_peso_atual
            // 
            this.text_peso_atual.Location = new System.Drawing.Point(321, 196);
            this.text_peso_atual.Name = "text_peso_atual";
            this.text_peso_atual.Size = new System.Drawing.Size(101, 22);
            this.text_peso_atual.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_peso_atual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio_mulher);
            this.Controls.Add(this.radio_homem);
            this.Controls.Add(this.text_altura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_calcular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_altura;
        private System.Windows.Forms.RadioButton radio_homem;
        private System.Windows.Forms.RadioButton radio_mulher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_peso_atual;
    }
}

