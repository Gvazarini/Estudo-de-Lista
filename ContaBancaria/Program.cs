using System.Globalization;
namespace ProjetoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta;
            Console.Write("Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicia? (s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor do deposito inicial: $");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(numero, titular, deposit);
            }
            else
            {
                Conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(Conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: $ ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Conta.Deposito(deposito);
            Console.WriteLine("Dados Atualizados: ");
            Console.Write(Conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para saque : $");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Saque(saque);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados");
            Console.Write(Conta);
        }
        
         

    }
}
