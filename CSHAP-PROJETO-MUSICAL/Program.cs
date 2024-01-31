string mensagemBoasVindas = "Bem vindo ao melhor app de música";

List<string> listaDasBandas = new List<string>(); 

void ExibirLogo() 
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas);
}



void ExibirMenuDeOpcoes() {

    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: 
            RegistrarBanda();
            break;
        case 2:
            MostrarAsBandas();
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchauzinho ");
            break; 
        default: Console.WriteLine("Opção inválida");
            break;

    }
}

void RegistrarBanda() {
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirMenuDeOpcoes();
}

void MostrarAsBandas() 
{
    Console.Clear();
    Console.WriteLine("Bandas registradas");
    Console.WriteLine("------------------\n");
    
    // ao invés do foreach, também poderia usar o --- for (int i = 0; i < listaDasBandas.Count; i++){}
    foreach (string s in listaDasBandas) { Console.WriteLine($"Banda: {s}"); }
}

ExibirMenuDeOpcoes();
