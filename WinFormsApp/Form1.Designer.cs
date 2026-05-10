namespace WinFormsApp
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
            txtDisplay = new TextBox();
            btnPorcentagem = new Button();
            btnCE = new Button();
            btnDelete = new Button();
            btnDivisao = new Button();
            btnRaiz = new Button();
            btnQuadrado = new Button();
            btnFracao = new Button();
            btnMultiplicacao = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSubtracao = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSoma = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnIgual = new Button();
            btnPonto = new Button();
            btn0 = new Button();
            btnInversao = new Button();
            btnC = new Button();
            lblHistorico = new Label();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(2, 34);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(238, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.Location = new Point(2, 63);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(61, 42);
            btnPorcentagem.TabIndex = 1;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = true;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(61, 63);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(61, 42);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(179, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 42);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(179, 102);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(61, 42);
            btnDivisao.TabIndex = 8;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(119, 102);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(61, 42);
            btnRaiz.TabIndex = 7;
            btnRaiz.Text = "²√x";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnQuadrado
            // 
            btnQuadrado.Location = new Point(61, 102);
            btnQuadrado.Name = "btnQuadrado";
            btnQuadrado.Size = new Size(61, 42);
            btnQuadrado.TabIndex = 6;
            btnQuadrado.Text = "x²";
            btnQuadrado.UseVisualStyleBackColor = true;
            btnQuadrado.Click += btnQuadrado_Click;
            // 
            // btnFracao
            // 
            btnFracao.Location = new Point(2, 102);
            btnFracao.Name = "btnFracao";
            btnFracao.Size = new Size(61, 42);
            btnFracao.TabIndex = 5;
            btnFracao.Text = "½ ";
            btnFracao.UseVisualStyleBackColor = true;
            btnFracao.Click += btnFracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(179, 141);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(61, 42);
            btnMultiplicacao.TabIndex = 12;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(119, 141);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 42);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(61, 141);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 42);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(2, 141);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 42);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(179, 180);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(61, 42);
            btnSubtracao.TabIndex = 16;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(119, 180);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 42);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(61, 180);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 42);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(2, 180);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 42);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(179, 219);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(61, 42);
            btnSoma.TabIndex = 20;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(119, 219);
            btn9.Name = "btn9";
            btn9.Size = new Size(61, 42);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(61, 219);
            btn8.Name = "btn8";
            btn8.Size = new Size(61, 42);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(2, 219);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 42);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(179, 258);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(61, 42);
            btnIgual.TabIndex = 24;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnPonto
            // 
            btnPonto.Location = new Point(119, 258);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(61, 42);
            btnPonto.TabIndex = 23;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(61, 258);
            btn0.Name = "btn0";
            btn0.Size = new Size(61, 42);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnInversao
            // 
            btnInversao.Location = new Point(2, 258);
            btnInversao.Name = "btnInversao";
            btnInversao.Size = new Size(61, 42);
            btnInversao.TabIndex = 21;
            btnInversao.Text = "+/-";
            btnInversao.UseVisualStyleBackColor = true;
            btnInversao.Click += btnInversao_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(119, 63);
            btnC.Name = "btnC";
            btnC.Size = new Size(61, 42);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Location = new Point(2, 9);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(0, 15);
            lblHistorico.TabIndex = 25;
            lblHistorico.TextAlign = ContentAlignment.MiddleRight;
            lblHistorico.Click += lblHistorico_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(242, 302);
            Controls.Add(lblHistorico);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(btn0);
            Controls.Add(btnInversao);
            Controls.Add(btnSoma);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSubtracao);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDivisao);
            Controls.Add(btnRaiz);
            Controls.Add(btnQuadrado);
            Controls.Add(btnFracao);
            Controls.Add(btnDelete);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnPorcentagem);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnPorcentagem;
        private Button btnCE;
        private Button btnDelete;
        private Button btnDivisao;
        private Button btnRaiz;
        private Button btnQuadrado;
        private Button btnFracao;
        private Button btnMultiplicacao;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSubtracao;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnSoma;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnIgual;
        private Button btnPonto;
        private Button btn0;
        private Button btnInversao;
        private Button btnC;
        private Label lblHistorico;
    }
}
