namespace Calculadora
{
    public partial class Form1 : Form
    {


        private enum operacoes
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        private operacoes OperacaoSelecionada { get; set; }

        public decimal Igual { get; set; }
        public decimal Valor { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtZero_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "0";
        }

        private void BtUm_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "1";
        }

        private void BtDois_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "2";
        }

        private void BtTres_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "3";
        }

        private void BtQuatro_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "4";
        }

        private void BtCinco_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "5";
        }

        private void BtSeis_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "6";
        }

        private void BtSete_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "7";
        }

        private void BtOito_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "8";
        }

        private void BtNove_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += "9";
        }

        //Operadores



        private void BtMais_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = operacoes.Adicao;

                Valor = Convert.ToDecimal(CaixaResultado.Text);
                CaixaResultado.Text = " ";
            }
            catch (Exception) { MessageBox.Show("Digite um número antes"); }
        }

        private void BtMenos_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = operacoes.Subtracao;

                Valor = Convert.ToDecimal(CaixaResultado.Text);
                CaixaResultado.Text = " ";

            }
            catch (Exception) { MessageBox.Show("Digite um numero antes"); }
        }

        private void BtVezes_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = operacoes.Multiplicacao;

                Valor = Convert.ToDecimal(CaixaResultado.Text);
                CaixaResultado.Text = " ";

            }
            catch (Exception) { MessageBox.Show("Digite um numero antes"); }
        }

        private void BtDividir_Click(object sender, EventArgs e)
        {
            try
            {
                OperacaoSelecionada = operacoes.Divisao;

                Valor = Convert.ToDecimal(CaixaResultado.Text);
                CaixaResultado.Text = " ";

            }
            catch (Exception) { MessageBox.Show("Digite um numero antes"); }
        }



        private void BtIgual_Click(object sender, EventArgs e)
        {

            switch (OperacaoSelecionada)
            {
                case operacoes.Adicao:

                    try
                    {
                        Igual = Valor + Convert.ToDecimal(CaixaResultado.Text);
                    }
                    catch (Exception) { MessageBox.Show("Digite um número antes"); }

                    break;

                case operacoes.Divisao:

                    Igual = Valor / Convert.ToDecimal(CaixaResultado.Text);

                    break;

                case operacoes.Subtracao:

                    Igual = Valor - Convert.ToDecimal(CaixaResultado.Text);

                    break;

                case operacoes.Multiplicacao:

                    Igual = Valor * Convert.ToDecimal(CaixaResultado.Text);

                    break;

            }

            CaixaResultado.Text = Convert.ToString(Igual);

            var texto = string.Empty;
        }

        private void BtVirgula_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text += ",";
        }

        private void BtApagar_Click(object sender, EventArgs e)
        {
            CaixaResultado.Text = null;
        }


    }
}