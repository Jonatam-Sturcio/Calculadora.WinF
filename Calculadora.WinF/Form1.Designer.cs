namespace Calculadora.WinF
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
            label1 = new Label();
            label2 = new Label();
            txtPrimeiroNum = new TextBox();
            txtSegundoNum = new TextBox();
            labelResultado = new Label();
            groupBox1 = new GroupBox();
            rbDiv = new RadioButton();
            rbMulti = new RadioButton();
            rbSub = new RadioButton();
            rbAdicao = new RadioButton();
            btCalcular = new Button();
            btLimpar = new Button();
            lbHistorico = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Primeiro Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Segundo Número";
            // 
            // txtPrimeiroNum
            // 
            txtPrimeiroNum.Location = new Point(116, 22);
            txtPrimeiroNum.Name = "txtPrimeiroNum";
            txtPrimeiroNum.Size = new Size(75, 23);
            txtPrimeiroNum.TabIndex = 2;
            // 
            // txtSegundoNum
            // 
            txtSegundoNum.Location = new Point(116, 57);
            txtSegundoNum.Name = "txtSegundoNum";
            txtSegundoNum.Size = new Size(75, 23);
            txtSegundoNum.TabIndex = 3;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(247, 31);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(32, 37);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDiv);
            groupBox1.Controls.Add(rbMulti);
            groupBox1.Controls.Add(rbSub);
            groupBox1.Controls.Add(rbAdicao);
            groupBox1.Location = new Point(11, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 126);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione a operação:";
            // 
            // rbDiv
            // 
            rbDiv.AutoSize = true;
            rbDiv.Location = new Point(6, 97);
            rbDiv.Name = "rbDiv";
            rbDiv.Size = new Size(63, 19);
            rbDiv.TabIndex = 3;
            rbDiv.TabStop = true;
            rbDiv.Text = "Divisão";
            rbDiv.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            rbMulti.AutoSize = true;
            rbMulti.Location = new Point(6, 72);
            rbMulti.Name = "rbMulti";
            rbMulti.Size = new Size(97, 19);
            rbMulti.TabIndex = 2;
            rbMulti.TabStop = true;
            rbMulti.Text = "Multiplicação";
            rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            rbSub.AutoSize = true;
            rbSub.Location = new Point(6, 47);
            rbSub.Name = "rbSub";
            rbSub.Size = new Size(83, 19);
            rbSub.TabIndex = 1;
            rbSub.TabStop = true;
            rbSub.Text = "Substração";
            rbSub.UseVisualStyleBackColor = true;
            // 
            // rbAdicao
            // 
            rbAdicao.AutoSize = true;
            rbAdicao.Location = new Point(6, 22);
            rbAdicao.Name = "rbAdicao";
            rbAdicao.Size = new Size(62, 19);
            rbAdicao.TabIndex = 0;
            rbAdicao.TabStop = true;
            rbAdicao.Text = "Adição";
            rbAdicao.UseVisualStyleBackColor = true;
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(11, 233);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(300, 23);
            btCalcular.TabIndex = 6;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(11, 259);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(300, 23);
            btLimpar.TabIndex = 7;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // lbHistorico
            // 
            lbHistorico.FormattingEnabled = true;
            lbHistorico.ItemHeight = 15;
            lbHistorico.Location = new Point(11, 288);
            lbHistorico.Name = "lbHistorico";
            lbHistorico.Size = new Size(300, 139);
            lbHistorico.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 429);
            Controls.Add(lbHistorico);
            Controls.Add(btLimpar);
            Controls.Add(btCalcular);
            Controls.Add(groupBox1);
            Controls.Add(labelResultado);
            Controls.Add(txtSegundoNum);
            Controls.Add(txtPrimeiroNum);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculadora?";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPrimeiroNum;
        private TextBox txtSegundoNum;
        private Label labelResultado;
        private GroupBox groupBox1;
        private RadioButton rbDiv;
        private RadioButton rbMulti;
        private RadioButton rbSub;
        private RadioButton rbAdicao;
        private Button btCalcular;
        private Button btLimpar;
        private ListBox lbHistorico;
    }
}
