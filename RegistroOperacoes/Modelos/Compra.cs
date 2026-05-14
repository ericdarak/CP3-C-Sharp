namespace RegistroOperacoes.Modelos
{
    public class Compra : Operacao
    {
        public override string Tipo
        {
            get { return "COMPRA"; }
        }

        public Compra(string codigoAtivo, int quantidade, decimal preco)
            : base(codigoAtivo, quantidade, preco)
        {
        }
    }
}
