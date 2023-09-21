//Exercício calculando a média de 5 notas de um aluno

//Receber o nome do aluno e armazenar em uma variável do tipo string

//Receber a nota 1, converter e armazenar em uma variável int

//Receber a nota 2, converter e armazenar em uma variável int

//Receber a nota 3, converter e armazenar em uma variável int

//Receber a nota 4, converter e armazenar em uma variável int

//Receber a nota 5, converter e armazenar em uma variável int

//Declarar uma variável do tipo int, para receber a média das notas

//Exibir uma mensagem se o aluno está aprovado, considerando nota acima de 7


Console.WriteLine("Digite o nome do aluno");
string nomeAluno = Console.ReadLine();

Console.WriteLine("Digite a nota 1: ");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 2: ");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 3: ");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 4: ");
int nota4 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 5: ");
int nota5 = int.Parse(Console.ReadLine());

int calculoMedia = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

string passou = (calculoMedia >= 7) ? "Aprovado" : "Reproavado";
Console.WriteLine($"O aluno {nomeAluno} tirou {calculoMedia} e foi {passou}");