using Internal;
using System;
public class Program {
    public static void Main() {
        //O try serve para tratar um erro e não parar a execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe

        try {
            Console.WriteLine("Digitou um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o número {numero}");
        }
        //Tratando exeção de erro específico de formato
        catch (FormatException) {
            Console.WriteLine("Digite um número inteiro");
        }

        catch (OverflowException) {
            Console.WriteLine("O número digitado é maior que o limite aceito");
        }

        //catch é o tratamento do erro
        catch (Exception erro) {
            Console.WriteLine($"Ocorreu um erro: {erro.Message}");
        }
        finally {
            Console.WriteLine($"No bloco finally o programa entra independentemente de exeção");
        }
    }
}