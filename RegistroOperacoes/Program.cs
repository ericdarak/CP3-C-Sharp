using System.Globalization;
using RegistroOperacoes.Modelos;
using RegistroOperacoes.Servicos;

namespace RegistroOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            ServicoOperacao servico = new ServicoOperacao();
            string opcao = "";

            do
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("   REGISTRO DE OPERACOES FINANCEIRAS");
                Console.WriteLine("===========================================");
                Console.WriteLine("1 - Registrar operacao");
                Console.WriteLine("2 - Listar operacoes");
                Console.WriteLine("3 - Mostrar valor total");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opcao: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RegistrarOperacao(servico);
                        break;
                    case "2":
                        servico.Listar();
                        break;
                    case "3":
                        servico.MostrarTotais();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando o sistema...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }

                if (opcao != "0")
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (opcao != "0");
        }

        static void RegistrarOperacao(ServicoOperacao servico)
        {
            try
            {
                Console.Write("Tipo (1=Compra, 2=Venda): ");
                string tipo = Console.ReadLine();

                if (tipo != "1" && tipo != "2")
                {
                    throw new Exception("Tipo invalido. Use 1 para Compra ou 2 para Venda.");
                }

                Console.Write("Codigo do ativo (ex: PETR4): ");
                string codigo = Console.ReadLine();

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.Write("Preco: ");
                decimal preco = decimal.Parse(Console.ReadLine());

                Operacao op;

                if (tipo == "1")
                {
                    op = new Compra(codigo, quantidade, preco);
                }
                else
                {
                    op = new Venda(codigo, quantidade, preco);
                }

                servico.Adicionar(op);

                Console.WriteLine(op.Tipo + " registrada com sucesso! ID: " + op.Id.ToString("D3"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: valor digitado nao e um numero valido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: valor digitado e muito grande.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
