namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
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
            txtResultado.BackColor = Color.FromArgb(32, 32, 32);
            txtResultado.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.White;
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
            btnVirgula.BackColor = Color.FromArgb(50, 50, 50);
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(12, 393);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(65, 60);
            btnVirgula.TabIndex = 1;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(59, 59, 59);
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Segoe UI", 14.25F);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(12, 195);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 60);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(59, 59, 59);
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Segoe UI", 14.25F);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(12, 261);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(59, 59, 59);
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Segoe UI", 14.25F);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(12, 327);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 60);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(59, 59, 59);
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Segoe UI", 14.25F);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(83, 327);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(59, 59, 59);
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Segoe UI", 14.25F);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(83, 261);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 60);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(59, 59, 59);
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Segoe UI", 14.25F);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(83, 195);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 60);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(59, 59, 59);
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Segoe UI", 14.25F);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(83, 393);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 60);
            btn0.TabIndex = 5;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(59, 59, 59);
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Segoe UI", 14.25F);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(154, 327);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 60);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(59, 59, 59);
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Segoe UI", 14.25F);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(154, 261);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 60);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(59, 59, 59);
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Segoe UI", 14.25F);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(154, 195);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 60);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnMais
            // 
            btnMais.BackColor = Color.FromArgb(50, 50, 50);
            btnMais.FlatStyle = FlatStyle.Popup;
            btnMais.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMais.ForeColor = Color.White;
            btnMais.Location = new Point(225, 327);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(65, 60);
            btnMais.TabIndex = 16;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = false;
            btnMais.Click += btnMais_Click;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = Color.FromArgb(50, 50, 50);
            btnMenos.FlatStyle = FlatStyle.Popup;
            btnMenos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenos.ForeColor = Color.White;
            btnMenos.Location = new Point(225, 261);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(65, 60);
            btnMenos.TabIndex = 15;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.FromArgb(50, 50, 50);
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicacao.ForeColor = Color.White;
            btnMultiplicacao.Location = new Point(225, 195);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(65, 60);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(50, 50, 50);
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(225, 393);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(65, 60);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.FromArgb(50, 50, 50);
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(154, 393);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(65, 60);
            btnDivisao.TabIndex = 20;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Coral;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(225, 129);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(65, 60);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
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
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(304, 463);
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
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculadora";
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
