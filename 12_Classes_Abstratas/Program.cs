//Classe pai que será herdada - SuperClasse
class Animal {
    public string cor { get; set; }
    public virtual void EmitirSom() {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}

//Classe filha que herdará da classe Animal
class Cachorro : Animal {
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom() {
        Console.WriteLine($"Cachorro da cor {cor} está latindo");
    }
}

class Gato : Animal {
        public override void EmitirSom() {
        Console.WriteLine($"Gato da cor {cor} está miando");
    }

    public void Ronronar() {
        Console.WriteLine("O gato está ronronando");
    }
}

class Program {
    public static void Main(){
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}