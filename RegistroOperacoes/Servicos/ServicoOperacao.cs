using RegistroOperacoes.Modelos;

namespace RegistroOperacoes.Servicos
{
    public partial class ServicoOperacao
    {
        private List<Operacao> operacoes = new List<Operacao>();

        public void Adicionar(Operacao operacao)
        {
            operacoes.Add(operacao);
        }

        public decimal TotalCompras()
        {
            decimal total = 0;

            for (int i = 0; i < operacoes.Count; i++)
            {
                if (operacoes[i] is Compra)
                {
                    total = total + operacoes[i].ObterTotal();
                }
            }

            return total;
        }

        public decimal TotalVendas()
        {
            decimal total = 0;

            for (int i = 0; i < operacoes.Count; i++)
            {
                if (operacoes[i] is Venda)
                {
                    total = total + operacoes[i].ObterTotal();
                }
            }

            return total;
        }
    }
}
