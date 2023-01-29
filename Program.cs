using projetoPOO.Models;


// filmes disponiveis na programação do cinema

Cinema filme1 = new Cinema();
filme1.NomeFilme = "A profecia do mal";
filme1.horarioFilme1 = "14:00";
filme1.horarioFilme2 = "20:00";
filme1.salaFilme = "Sala 1";
filme1.tipoIdioma = "Legendado";

Cinema filme2 = new Cinema();
filme2.NomeFilme = "Avatar : O caminho da àgua";
filme2.horarioFilme1 = "18:00";
filme2.horarioFilme2 = "21:30";
filme2.salaFilme = "Sala 5";
filme2.tipoIdioma = "Dublado";

// Classe que representa o cliente comprando seu ingresso
Ingresso cliente = new Ingresso();




bool sistemaCinema = true;
bool sistemaCinemaParte2 = true;



while(sistemaCinema == true)   
{
    Console.WriteLine("             NOSSA PROGRAMAÇÃO  ");
    filme1.ExibirProgramacao();
    filme2.ExibirProgramacao();


    Console.WriteLine("Escolha o nome do filme :");
    string escolhendoFilme = Console.ReadLine();
    Console.WriteLine("Escolha um Horário :");
    string escolhendoHorario = Console.ReadLine();
    

    // validar o nome do filme
    if(escolhendoFilme == filme1.NomeFilme.ToUpper() || escolhendoFilme == filme2.NomeFilme.ToUpper()) 
    {
        cliente.NomeFilme = escolhendoFilme;
        cliente.HorarioEscolhido = escolhendoHorario;
        sistemaCinema = false;
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Nome inválido, veja se o filme realmente existe na Programação!");
        Console.ReadLine();
        Console.Clear();
    }
    

}


while(sistemaCinemaParte2 == true)
{
    Console.WriteLine("Escolha seu assento: ");
    string escolhendoAssento = Console.ReadLine();
    cliente.assento = escolhendoAssento;
    Console.Clear();

    Console.WriteLine(" TIPOS DE INGRESSO : Inteira 34,20  | Meia 19,20");
    Console.WriteLine("Escolha seu tipo: ");
    string escolhendoTipoIngresso = Console.ReadLine();
    cliente.tipoIngresso = escolhendoTipoIngresso;
    cliente.inserindoValorIngresso(escolhendoTipoIngresso);
    Console.Clear();


    Console.WriteLine(" ESCOLHA A FORMA DE PAGAMENTO");
    Console.WriteLine("1 - Cartão de crédito");
    Console.WriteLine("2 - Cartão de débito");
    Console.WriteLine("3 - PIX");
    Console.WriteLine("4 - Paypal");

    int formaPagamento = Convert.ToInt32(Console.ReadLine());

    switch(formaPagamento)
    {
        case 1:
            cliente.formaPagamento = "Cartão de crédito";
            Console.Clear();
            cliente.exibirIngressoCliente();
            sistemaCinemaParte2 = false;
            break;
        case 2:
            cliente.formaPagamento = "Cartão de débito";
            Console.Clear();
            cliente.exibirIngressoCliente();
            sistemaCinemaParte2 = false;
            break;
        case 3:
            cliente.formaPagamento = "PIX";
            Console.Clear();
            cliente.exibirIngressoCliente();
            sistemaCinemaParte2 = false;
            break;
        case 4:
            cliente.formaPagamento = "Paypal";
            Console.Clear();
            cliente.exibirIngressoCliente();
            sistemaCinemaParte2 = false;
            break;
        default:
            Console.WriteLine("Ação inválida, tente novamente!");
            break;

    }



}

