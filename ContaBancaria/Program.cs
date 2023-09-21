using banco;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine(" * * * * * * * * * * * * *  ");
        Console.WriteLine("*                          *");
        Console.WriteLine("* BEM VINDO AO NOSSO BANCO *");
        Console.WriteLine("*                          *");
        Console.WriteLine(" * * * * * * * * * * * * *  ");

        Thread.Sleep(1500);

        Console.WriteLine("Digite o nome do titular da conta");
        string nomeTitular = Console.ReadLine();

        Console.WriteLine("Digite seu saldo inicial na conta");
        double saldoInicial = Convert.ToDouble(Console.ReadLine());

        contaCorrente conta = new contaCorrente(nomeTitular, saldoInicial);
        string opcao;

        do {
            Console.WriteLine("* * * * * * * * * * * * * *");
            Console.WriteLine("*          MENU           *");
            Console.WriteLine("*   1 = Consultar Saldo   *");
            Console.WriteLine("*   2 = Depositar         *");
            Console.WriteLine("*   3 = Sacar Dinheiro    *");
            Console.WriteLine("*   4 = Sair              *");
            Console.WriteLine("* * * * * * * * * * * * * *");

            opcao = Console.ReadLine();

            Console.Clear();

            switch (opcao) {
                case "1":
                    conta.consultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite o valor a ser depositado");
                    double valorDeposito = Convert.ToDouble(Console.ReadLine());
                    conta.depositar(valorDeposito);
                    break;
                case "3":
                    Console.WriteLine("Digite o valor a ser sacado");
                    double valorSaque = Convert.ToDouble(Console.ReadLine());
                    conta.sacar(valorSaque);
                    break;
                case "4":
                    Console.WriteLine("Você saiu do sistema.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != "4");
    }
}