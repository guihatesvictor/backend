namespace Sesi.Model {
//Declarando a classe aluno
    public class Aluno {
        //Declarando os atributos
        public string nome { get; set; }

        public int idade { get; set; }

        public string turma { get; set; }

        private int nrFaltas { get; set; }


        //Criando método
        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos, estudo na turma do {turma} e tenho {nrFaltas} faltas.");
        }

        public void AdicionarFaltas(int nr) {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr} faltas");
            nrFaltas = nrFaltas + nr;
        }

        
         public void ResumoFaltas() {
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas.");
        }
    }
}