using System;
class Program
{
    //Método main é um ponto de entrada de um programa em c#
    public static void Main()
    {
        Console.WriteLine("Estou no método Main");
        Metodo();
        ImprimiDataHora();
        ContagemRegresiva(5);
        jogoQueNrSouEu();

        //Chamndo o método Somar  enviando os parâmetros 3 e 8  
        int resultadoSoma = Somar(3, 8);
        Console.WriteLine(resultadoSoma);
    }

    public static void Metodo()
    {
        Console.WriteLine("Estou no método / função");
    }

    public static void ImprimiDataHora()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.Hour.ToString());
        Console.WriteLine(DateTime.Now.ToString());
    }

    public static int Somar(int n1, int n2)
    {
        int soma = n1 + n2;
        return soma;
    }

    public static void ContagemRegresiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("BOOOOOOOOOM");
    }

    public static void jogoQueNrSouEu()
    {
        Console.WriteLine("* * * * * * * * * * *");
        Console.WriteLine("Bem vindo ao jogo!");
        Console.WriteLine("Sorteei um número de 1 a 20, tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * *");

        Random rdn = new Random();
        int nrSorteado = rdn.Next(20);
        int nrDigitado = -1;

        do {
            Console.WriteLine("Digite um número:");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            {
                Console.WriteLine("O número digitado é MAIOR que o sorteado");
            }
            else if (nrDigitado < nrSorteado)
            {
                Console.WriteLine("O número digitado é MENOR que o sorteado");
            }
        } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabéns, você acertou");
    }
}