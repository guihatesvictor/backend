namespace Sesi.Models {
    public class Gato : Animal {
        public string nome { get; set; }
        public int idade { get; set; }
        public string genero { get; set; }


        public void EmitirSom() {
            Console.WriteLine("Emitindo som");
        }
    }
}