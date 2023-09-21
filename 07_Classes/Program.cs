using Sesi.Models;

class Program{
    public static void Main() {
        Gato meuGato = new Gato();
        meuGato.nome = "Garfield";
        meuGato.cor = "Preto";
        meuGato.idade = 2;
        meuGato.especie = "bichano";
        meuGato.genero = "Macho";
        meuGato.peso = 3;


        Peixe meuPeixe = new Peixe();
        meuGato.cor = "Laranja";
        meuGato.especie = "Palhaço";
        meuGato.tamanho = 0.20M;
        meuGato.peso = 0.100M;
    }
}