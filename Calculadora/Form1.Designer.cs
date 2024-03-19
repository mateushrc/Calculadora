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
            txtResultado = new TextBox();
            btnVirgula = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnMais = new Button();
            btnMenos = new Button();
            btnMultiplicacao = new Button();
            btnIgual = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = SystemColors.MenuText;
            txtResultado.Location = new Point(12, 26);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(278, 97);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(12, 393);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(65, 60);
            btnVirgula.TabIndex = 1;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 195);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 60);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 261);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 327);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 60);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(83, 327);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(83, 261);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 60);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(83, 195);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 60);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(83, 393);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 60);
            btn0.TabIndex = 5;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(154, 327);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 60);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(154, 261);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 60);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(154, 195);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 60);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnMais
            // 
            btnMais.Location = new Point(225, 327);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(65, 60);
            btnMais.TabIndex = 16;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            btnMais.Click += btnMais_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(225, 261);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(65, 60);
            btnMenos.TabIndex = 15;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(225, 195);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(65, 60);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(225, 393);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(65, 60);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(154, 393);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(65, 60);
            btnDivisao.TabIndex = 20;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(225, 129);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(65, 60);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(14, 129);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 22;
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 461);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMais);
            Controls.Add(btnMenos);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnIgual);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btnVirgula);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnVirgula;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn0;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btnMais;
        private Button btnMenos;
        private Button btnMultiplicacao;
        private Button btnIgual;
        private Button btnDivisao;
        private Button btnLimpar;
        private Label label1;
    }
}
