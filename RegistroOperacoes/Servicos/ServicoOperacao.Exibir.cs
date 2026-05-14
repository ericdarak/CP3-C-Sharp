namespace RegistroOperacoes.Servicos
{
    public partial class ServicoOperacao
    {
        public void Listar()
        {
            if (operacoes.Count == 0)
            {
                Console.WriteLine("Nenhuma operacao registrada.");
                return;
            }

            Console.WriteLine("--- Historico de Operacoes ---");

            foreach (var op in operacoes)
            {
                Console.WriteLine(op.ObterDetalhes());
            }
        }

        public void MostrarTotais()
        {
            Console.WriteLine("Valor total de compras:  R$ " + TotalCompras().ToString("F2"));
            Console.WriteLine("Valor total de vendas:   R$ " + TotalVendas().ToString("F2"));
        }
    }
}
