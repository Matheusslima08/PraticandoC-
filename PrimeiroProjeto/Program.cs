//Matheus Sound
string mensagemDeBoasVindas = "Boas Vindas ao Matheus Sound";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calipso" };
void ExibirLogo()
{
    Console.WriteLine(@"
        
███╗░░░███╗░█████╗░████████╗██╗░░██╗███████╗██╗░░░██╗░██████╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
████╗░████║██╔══██╗╚══██╔══╝██║░░██║██╔════╝██║░░░██║██╔════╝  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
██╔████╔██║███████║░░░██║░░░███████║█████╗░░██║░░░██║╚█████╗░  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
██║╚██╔╝██║██╔══██║░░░██║░░░██╔══██║██╔══╝░░██║░░░██║░╚═══██╗  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██║░╚═╝░██║██║░░██║░░░██║░░░██║░░██║███████╗╚██████╔╝██████╔╝  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝░╚═════╝░╚═════╝░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Voce escolheu a opcção" + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opcção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("******************************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi  registrada com sucesso!");
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //  Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }
    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();

