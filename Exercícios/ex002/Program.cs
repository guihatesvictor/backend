Console.WriteLine("Digite o ultimo número da placa: ");
string numPlaca = Console.ReadLine();

string ultimo = numPlaca.Substring(numPlaca.length);

if (ultimo == "1" || ultimo == "2"){
    Console.Write("Você não pode andar com seu veiculo segunda-feira!");
}

else if (ultimo == "3" || ultimo == "4"){
    Console.Write("Você não pode andar com seu veiculo terça-feira!");
}

else if (ultimo == "5" || ultimo == "6"){
    Console.Write("Você não pode andar com seu veiculo quarta-feira!");
}

else if (ultimo == "7" || ultimo == "8") {
    Console.Write("Você não pode andar com seu veiculo quinta-feira!");
}

else if (ultimo == "9" || ultimo == "0"){
    Console.Write("Você não pode andar com seu veiculo sexta-feira!");
}