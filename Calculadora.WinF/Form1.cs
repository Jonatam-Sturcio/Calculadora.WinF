namespace Calculadora.WinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        private void LimparTela()
        {
            txtPrimeiroNum.Text = "";
            txtSegundoNum.Text = "";
            labelResultado.Text = "0";
            rbAdicao.Checked = false;
            rbSub.Checked = false;
            rbMulti.Checked = false;
            rbDiv.Checked = false;
        }
        private void RegistrarOperacao(int opSelecionada)
        {
            string op = "";
            if (opSelecionada == 0)
                op = "+";
            if (opSelecionada == 1)
                op = "-";
            if (opSelecionada == 2)
                op = "*";
            if (opSelecionada == 3)
                op = "/";

            string operacao = $"{txtPrimeiroNum.Text} {op} {txtSegundoNum.Text} = {labelResultado.Text}";
            lbHistorico.Items.Add(operacao);
        }
        private bool ValidaCampos()
        {
            if (txtPrimeiroNum.Text.Length == 0)
            {
                return false;
            }
            if (txtSegundoNum.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            int opSelecionada = 0;
            if (ValidaCampos())
            {
                if (rbAdicao.Checked)
                {
                    resultado = double.Parse(txtPrimeiroNum.Text) + double.Parse(txtSegundoNum.Text);
                    opSelecionada = 0;
                }
                else if (rbSub.Checked)
                {
                    resultado = double.Parse(txtPrimeiroNum.Text) - double.Parse(txtSegundoNum.Text);
                    opSelecionada = 1;
                }
                else if (rbMulti.Checked)
                {
                    resultado = double.Parse(txtPrimeiroNum.Text) * double.Parse(txtSegundoNum.Text);
                    opSelecionada = 2;
                }
                else if (rbDiv.Checked)
                {
                    resultado = double.Parse(txtPrimeiroNum.Text) / double.Parse(txtSegundoNum.Text);
                    opSelecionada = 3;
                }
                else
                {
                    MessageBox.Show("Deve ser selecionado uma operação ao menos",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                labelResultado.Text = resultado + "";
                RegistrarOperacao(opSelecionada);
                LimparTela();
            }
            else
            {
                MessageBox.Show("Os números devem ser preenchidos",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
