class Program {

    public static void Main() {
        ListaDoChurrasco();
        SonhosDeConsumo();
    }
    public static void ListaDoChurrasco() {
        string[] produtos = new string[6];

        for (int i = 0; i < produtos.Length; i++) {
            Console.WriteLine("Informe o produto: ");
            string produto = Console.ReadLine();
            produtos[i] = produto;
        }

        Array.Sort(produtos);

        foreach (string item in produtos) {
            Console.WriteLine($"Item {item}");
        }
    }

    public static void SonhosDeConsumo() {
        string[] sonhos = new string[3];

        int[] valor = new int[3];

        int numero = 0;

        for (int i = 0; i < sonhos.Length; i++) {
            Console.WriteLine("Digite seu sonho de consumo: ");
            sonhos[i] = Console.ReadLine();
            Console.WriteLine("Digite o preço desse sonho: ");
            valor[i] = int.Parse(Console.ReadLine());
            numero = valor[i];
        }

        Array.Sort(sonhos);

        foreach (string item in sonhos) {
            Console.WriteLine($"Sonho: {item} Preço: {numero}");
        }
    }
}