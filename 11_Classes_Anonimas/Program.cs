public class Program {
    public static void Main() {
        var pessoa1 = new { 
            nome = "João",
            idade = 20
            };

        var pessoa2 = new { 
            nome = "Maria",
            idade = 17 
            };

        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 {pessoa2.nome}");


        Console.WriteLine("Digite o nome da marca do carro: ");
        string marca2 = Console.ReadLine();
        Console.WriteLine("Digite o modelo do carro: ");
        string modelo2 = Console.ReadLine();
        Console.WriteLine("Digite o ano do carro: ");
        int ano2 = int.Parse(Console.ReadLine());

        var carro = new { 
            marca = marca2,
            modelo = modelo2,
            ano = ano2,
            };

        Console.WriteLine($"A marca do carro é {carro.marca}, o modelo é {carro.modelo} e o ano é {carro.ano}.");
    }
}