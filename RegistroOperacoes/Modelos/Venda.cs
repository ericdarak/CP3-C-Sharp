namespace RegistroOperacoes.Modelos
{
    public class Venda : Operacao
    {
        public override string Tipo
        {
            get { return "VENDA"; }
        }

        public Venda(string codigoAtivo, int quantidade, decimal preco)
            : base(codigoAtivo, quantidade, preco)
        {
        }
    }
}
