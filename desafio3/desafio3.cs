
//Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas(adição, subtração, divisão e multiplicação),
//utilizando interpolação de strings.

void operacoesDoisNumeros() {

    Console.Write("Escolha um número: ");
    double a = double.Parse(Console.ReadLine()!);

    Console.Write("Agora escolha outro número: ");
    double b = double.Parse(Console.ReadLine()!);

    Console.WriteLine($"A soma de {a} com {b} é igual a {a + b}");
    Console.WriteLine($"A subtração de {a} com {b} é igual a {a - b}");
    Console.WriteLine($"A multiplicação de {a} com {b} é igual a {a * b}");
    Console.WriteLine($"A divisão de {a} com {b} é igual a {a / b}");
}



//Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
//Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

void listarBandas() {

    List<String> listaDeBandas = new List<string>();

    listaDeBandas.Add("Radiohead");
    listaDeBandas.Add("Rage Against The Machine");
    listaDeBandas.Add("Deftones");
    listaDeBandas.Add("Limp Bizkit");
    listaDeBandas.Add("System of a down");

    for (int i = 0; i < listaDeBandas.Count; i++)
    {
        Console.WriteLine(listaDeBandas[i]);

    }
} 



//Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

int somaLista() {
    List<int> lista = new List<int>(); 
    lista.Add(2);
    lista.Add(8);
    lista.Add(6);
    lista.Add(46);
    lista.Add(99);

    int sum = 0;

    foreach (int i in lista)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine(somaLista());