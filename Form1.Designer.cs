namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CaixaResultado = new TextBox();
            BtIgual = new Button();
            BtVirgula = new Button();
            BtZero = new Button();
            BtTres = new Button();
            BtDois = new Button();
            BtUm = new Button();
            BtQuatro = new Button();
            BtCinco = new Button();
            BtSeis = new Button();
            BtNove = new Button();
            BtOito = new Button();
            BtSete = new Button();
            BtMais = new Button();
            BtMenos = new Button();
            Botaos = new GroupBox();
            BtApagar = new Button();
            BtDividir = new Button();
            BtVezes = new Button();
            Botaos.SuspendLayout();
            SuspendLayout();
            // 
            // CaixaResultado
            // 
            CaixaResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CaixaResultado.Location = new Point(6, 22);
            CaixaResultado.Multiline = true;
            CaixaResultado.Name = "CaixaResultado";
            CaixaResultado.ReadOnly = true;
            CaixaResultado.RightToLeft = RightToLeft.No;
            CaixaResultado.Size = new Size(270, 42);
            CaixaResultado.TabIndex = 0;
            CaixaResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // BtIgual
            // 
            BtIgual.Location = new Point(213, 218);
            BtIgual.Name = "BtIgual";
            BtIgual.Size = new Size(63, 106);
            BtIgual.TabIndex = 1;
            BtIgual.Text = "=";
            BtIgual.UseVisualStyleBackColor = true;
            BtIgual.Click += BtIgual_Click;
            // 
            // BtVirgula
            // 
            BtVirgula.Location = new Point(155, 274);
            BtVirgula.Name = "BtVirgula";
            BtVirgula.Size = new Size(52, 50);
            BtVirgula.TabIndex = 2;
            BtVirgula.Text = ",";
            BtVirgula.UseVisualStyleBackColor = true;
            BtVirgula.Click += BtVirgula_Click;
            // 
            // BtZero
            // 
            BtZero.Location = new Point(6, 274);
            BtZero.Name = "BtZero";
            BtZero.Size = new Size(143, 50);
            BtZero.TabIndex = 3;
            BtZero.Text = "0";
            BtZero.UseVisualStyleBackColor = true;
            BtZero.Click += BtZero_Click;
            // 
            // BtTres
            // 
            BtTres.Location = new Point(144, 218);
            BtTres.Name = "BtTres";
            BtTres.Size = new Size(63, 50);
            BtTres.TabIndex = 4;
            BtTres.Text = "3";
            BtTres.UseVisualStyleBackColor = true;
            BtTres.Click += BtTres_Click;
            // 
            // BtDois
            // 
            BtDois.Location = new Point(75, 218);
            BtDois.Name = "BtDois";
            BtDois.Size = new Size(63, 50);
            BtDois.TabIndex = 5;
            BtDois.Text = "2";
            BtDois.UseVisualStyleBackColor = true;
            BtDois.Click += BtDois_Click;
            // 
            // BtUm
            // 
            BtUm.Location = new Point(6, 218);
            BtUm.Name = "BtUm";
            BtUm.Size = new Size(63, 50);
            BtUm.TabIndex = 6;
            BtUm.Text = "1";
            BtUm.UseVisualStyleBackColor = true;
            BtUm.Click += BtUm_Click;
            // 
            // BtQuatro
            // 
            BtQuatro.Location = new Point(6, 162);
            BtQuatro.Name = "BtQuatro";
            BtQuatro.Size = new Size(63, 50);
            BtQuatro.TabIndex = 7;
            BtQuatro.Text = "4";
            BtQuatro.UseVisualStyleBackColor = true;
            BtQuatro.Click += BtQuatro_Click;
            // 
            // BtCinco
            // 
            BtCinco.Location = new Point(75, 162);
            BtCinco.Name = "BtCinco";
            BtCinco.Size = new Size(63, 50);
            BtCinco.TabIndex = 8;
            BtCinco.Text = "5";
            BtCinco.UseVisualStyleBackColor = true;
            BtCinco.Click += BtCinco_Click;
            // 
            // BtSeis
            // 
            BtSeis.Location = new Point(144, 162);
            BtSeis.Name = "BtSeis";
            BtSeis.Size = new Size(63, 50);
            BtSeis.TabIndex = 9;
            BtSeis.Text = "6";
            BtSeis.UseVisualStyleBackColor = true;
            BtSeis.Click += BtSeis_Click;
            // 
            // BtNove
            // 
            BtNove.Location = new Point(144, 106);
            BtNove.Name = "BtNove";
            BtNove.RightToLeft = RightToLeft.No;
            BtNove.Size = new Size(63, 50);
            BtNove.TabIndex = 10;
            BtNove.Text = "9";
            BtNove.UseVisualStyleBackColor = true;
            BtNove.Click += BtNove_Click;
            // 
            // BtOito
            // 
            BtOito.Location = new Point(75, 106);
            BtOito.Name = "BtOito";
            BtOito.Size = new Size(63, 50);
            BtOito.TabIndex = 11;
            BtOito.Text = "8";
            BtOito.UseVisualStyleBackColor = true;
            BtOito.Click += BtOito_Click;
            // 
            // BtSete
            // 
            BtSete.Location = new Point(6, 106);
            BtSete.Name = "BtSete";
            BtSete.Size = new Size(63, 50);
            BtSete.TabIndex = 12;
            BtSete.Text = "7";
            BtSete.UseVisualStyleBackColor = true;
            BtSete.Click += BtSete_Click;
            // 
            // BtMais
            // 
            BtMais.Location = new Point(213, 106);
            BtMais.Name = "BtMais";
            BtMais.Size = new Size(63, 106);
            BtMais.TabIndex = 13;
            BtMais.Text = "+";
            BtMais.UseVisualStyleBackColor = true;
            BtMais.Click += BtMais_Click;
            // 
            // BtMenos
            // 
            BtMenos.Location = new Point(213, 70);
            BtMenos.Name = "BtMenos";
            BtMenos.RightToLeft = RightToLeft.No;
            BtMenos.Size = new Size(63, 30);
            BtMenos.TabIndex = 14;
            BtMenos.Text = "-";
            BtMenos.UseVisualStyleBackColor = true;
            BtMenos.Click += BtMenos_Click;
            // 
            // Botaos
            // 
            Botaos.Controls.Add(BtApagar);
            Botaos.Controls.Add(CaixaResultado);
            Botaos.Controls.Add(BtDividir);
            Botaos.Controls.Add(BtVezes);
            Botaos.Controls.Add(BtIgual);
            Botaos.Controls.Add(BtMenos);
            Botaos.Controls.Add(BtVirgula);
            Botaos.Controls.Add(BtSete);
            Botaos.Controls.Add(BtMais);
            Botaos.Controls.Add(BtOito);
            Botaos.Controls.Add(BtZero);
            Botaos.Controls.Add(BtNove);
            Botaos.Controls.Add(BtTres);
            Botaos.Controls.Add(BtDois);
            Botaos.Controls.Add(BtSeis);
            Botaos.Controls.Add(BtUm);
            Botaos.Controls.Add(BtQuatro);
            Botaos.Controls.Add(BtCinco);
            Botaos.Location = new Point(12, 12);
            Botaos.Name = "Botaos";
            Botaos.Size = new Size(285, 337);
            Botaos.TabIndex = 15;
            Botaos.TabStop = false;
            Botaos.Enter += groupBox1_Enter;
            // 
            // BtApagar
            // 
            BtApagar.Location = new Point(6, 70);
            BtApagar.Name = "BtApagar";
            BtApagar.Size = new Size(63, 30);
            BtApagar.TabIndex = 17;
            BtApagar.Text = "C";
            BtApagar.UseVisualStyleBackColor = true;
            BtApagar.Click += BtApagar_Click;
            // 
            // BtDividir
            // 
            BtDividir.Location = new Point(75, 70);
            BtDividir.Name = "BtDividir";
            BtDividir.Size = new Size(63, 30);
            BtDividir.TabIndex = 16;
            BtDividir.Text = "/";
            BtDividir.UseVisualStyleBackColor = true;
            BtDividir.Click += BtDividir_Click;
            // 
            // BtVezes
            // 
            BtVezes.Location = new Point(144, 70);
            BtVezes.Name = "BtVezes";
            BtVezes.Size = new Size(63, 30);
            BtVezes.TabIndex = 15;
            BtVezes.Text = "x";
            BtVezes.UseVisualStyleBackColor = true;
            BtVezes.Click += BtVezes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(313, 359);
            Controls.Add(Botaos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Botaos.ResumeLayout(false);
            Botaos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox CaixaResultado;
        private Button BtIgual;
        private Button BtVirgula;
        private Button BtZero;
        private Button BtTres;
        private Button BtDois;
        private Button BtUm;
        private Button BtQuatro;
        private Button BtCinco;
        private Button BtSeis;
        private Button BtNove;
        private Button BtOito;
        private Button BtSete;
        private Button BtMais;
        private Button BtMenos;
        private GroupBox Botaos;
        private Button BtApagar;
        private Button BtDividir;
        private Button BtVezes;
    }
}