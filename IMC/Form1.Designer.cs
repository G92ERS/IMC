namespace IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txbaltura = new System.Windows.Forms.TextBox();
            this.txbpeso = new System.Windows.Forms.TextBox();
            this.btnimc = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txbresultado = new System.Windows.Forms.TextBox();
            this.lblsaudavel = new System.Windows.Forms.Label();
            this.lblsaud = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(0, 5);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(240, 31);
            this.lblIMC.TabIndex = 0;
            this.lblIMC.Text = "Calculadora de IMC";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Jokerman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(12, 54);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(120, 39);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura:";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Jokerman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(12, 93);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(95, 39);
            this.lblpeso.TabIndex = 2;
            this.lblpeso.Text = "Peso:";
            // 
            // txbaltura
            // 
            this.txbaltura.Location = new System.Drawing.Point(128, 70);
            this.txbaltura.Name = "txbaltura";
            this.txbaltura.Size = new System.Drawing.Size(100, 20);
            this.txbaltura.TabIndex = 3;
            // 
            // txbpeso
            // 
            this.txbpeso.Location = new System.Drawing.Point(128, 109);
            this.txbpeso.Name = "txbpeso";
            this.txbpeso.Size = new System.Drawing.Size(100, 20);
            this.txbpeso.TabIndex = 4;
            // 
            // btnimc
            // 
            this.btnimc.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimc.Location = new System.Drawing.Point(6, 151);
            this.btnimc.Name = "btnimc";
            this.btnimc.Size = new System.Drawing.Size(234, 40);
            this.btnimc.TabIndex = 5;
            this.btnimc.Text = "Calcular IMC";
            this.btnimc.UseVisualStyleBackColor = true;
            this.btnimc.Click += new System.EventHandler(this.btnimc_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(27, 206);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(60, 28);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "IMC:";
            // 
            // txbresultado
            // 
            this.txbresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbresultado.Location = new System.Drawing.Point(128, 206);
            this.txbresultado.Name = "txbresultado";
            this.txbresultado.ReadOnly = true;
            this.txbresultado.Size = new System.Drawing.Size(100, 24);
            this.txbresultado.TabIndex = 7;
            // 
            // lblsaudavel
            // 
            this.lblsaudavel.AutoSize = true;
            this.lblsaudavel.Location = new System.Drawing.Point(32, 251);
            this.lblsaudavel.Name = "lblsaudavel";
            this.lblsaudavel.Size = new System.Drawing.Size(0, 13);
            this.lblsaudavel.TabIndex = 8;
            // 
            // lblsaud
            // 
            this.lblsaud.AutoSize = true;
            this.lblsaud.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaud.Location = new System.Drawing.Point(26, 238);
            this.lblsaud.Name = "lblsaud";
            this.lblsaud.Size = new System.Drawing.Size(20, 31);
            this.lblsaud.TabIndex = 9;
            this.lblsaud.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 276);
            this.Controls.Add(this.lblsaud);
            this.Controls.Add(this.lblsaudavel);
            this.Controls.Add(this.txbresultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnimc);
            this.Controls.Add(this.txbpeso);
            this.Controls.Add(this.txbaltura);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblIMC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txbaltura;
        private System.Windows.Forms.TextBox txbpeso;
        private System.Windows.Forms.Button btnimc;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txbresultado;
        private System.Windows.Forms.Label lblsaudavel;
        private System.Windows.Forms.Label lblsaud;
    }
}

