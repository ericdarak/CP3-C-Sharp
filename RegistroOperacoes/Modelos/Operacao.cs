namespace RegistroOperacoes.Modelos
{
    public abstract class Operacao : IOperacao
    {
        private static int proximoId = 1;

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string CodigoAtivo { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public abstract string Tipo { get; }

        public Operacao(string codigoAtivo, int quantidade, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(codigoAtivo))
            {
                throw new Exception("Codigo do ativo nao pode ser vazio.");
            }

            if (quantidade <= 0)
            {
                throw new Exception("Quantidade deve ser maior que zero.");
            }

            if (preco <= 0)
            {
                throw new Exception("Preco deve ser maior que zero.");
            }

            Id = proximoId;
            proximoId = proximoId + 1;

            Data = DateTime.Now;
            CodigoAtivo = codigoAtivo.ToUpper();
            Quantidade = quantidade;
            Preco = preco;
        }

        public decimal ObterTotal()
        {
            return Quantidade * Preco;
        }

        public virtual string ObterDetalhes()
        {
            string idFormatado = Id.ToString("D3");
            string dataFormatada = Data.ToString("dd/MM/yyyy HH:mm");
            string precoFormatado = Preco.ToString("F2");
            string totalFormatado = ObterTotal().ToString("F2");

            return Tipo + ": [" + idFormatado + "] " + dataFormatada
                + " - " + CodigoAtivo + " x" + Quantidade
                + " @ R$ " + precoFormatado
                + " = R$ " + totalFormatado;
        }
    }
}
