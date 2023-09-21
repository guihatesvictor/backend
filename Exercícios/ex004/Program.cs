class Program {
    public static void Main(){
        
        Console.WriteLine("Soma e dobro de: ");

        int nrDigitado = int.Parse(Console.ReadLine());


        Console.WriteLine("Digite um número para a tabuada: ");

        int tabuada = int.Parse(Console.ReadLine());


        
        Dobro(nrDigitado);
        Metade(nrDigitado);
        Tabuada(tabuada);
        SomaComDoWhile();
    }

    public static void Dobro(int n1){

        int dobro = n1 * 2;
        
        Console.WriteLine("Dobro do número:");
        Console.WriteLine(dobro);
    }

    public static void Metade(int n2) {
        int metade = n2 / 2;

        Console.WriteLine("Metade do número:");
        Console.WriteLine(metade);
    }

    public static void Tabuada(int n1) {

        int contador = 1;
        while (contador <= 10) {
            int resultado = n1 * contador;
            Console.WriteLine($"{n1} x {contador} = {resultado}");
            contador++;
        }
    }

    public static void SomaComDoWhile() {
        int num = int.Parse(Console.ReadLine());

        int maior = 0;

        int menor = 10000;

        int soma = 0;

        do {
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if (num > maior) {
                maior = num;
            }

            if (num < menor && num > 0) {
                menor = num;
            }

            if (num > 0) {
                soma = soma + num;
            }
        } while (num > 0);

        Console.WriteLine($"Menor nº {menor} - Maior nº {maior} - Soma de todos {soma}");
    }
}