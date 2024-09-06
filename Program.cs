internal class Program
{  enum opcao { Calculadora = 1, RecomendaçãoAleatoriaDeAnime, NumeroAlt, SimOuNão, CalculoIMC}
        
    private static void Main(string[] args)
    {  
        
        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine("Versão da aplicação: 1.0");
        bool continuar = true;
Loading();

Console.ReadKey();

while (continuar)
{

    Console.Clear();
    
    Intro();
    MenuEscolhas();

        Console.WriteLine("Obrigado por usar o progama\ndeseja continuar? (S/N)");
        string resposta = Console.ReadLine().ToUpper();

        if (resposta == "N")
        {
            continuar = false;
        }
    
        
    

}
    }
    static void Loading()

{   //double NumeroAleatorio2 = random.NextDouble();

    // geração de número aleatorio
    Random random = new Random();
    // declaramos a variável com o valor do numero aleatório
    //                  intervalo que iremos usar os numeros
    //                                  |
    //                                  v
    int NumeroAleatorio = random.Next(2, 4);
    int Contador = 0;

    while (Contador < 100)
    {
        Contador++;
        Contador *= NumeroAleatorio;
        if (Contador > 100)
        {
            Contador -= 100;
            Contador--;
            Contador = 100;
        }
        Console.WriteLine($"progresso em {Contador}%");

    }

    Console.WriteLine("Carregamento concluído.");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
}
    static void Intro()
{
    Console.WriteLine("Bem vindo ao progama Vitows\n" +
                      "escolha uma de nossas funções abaixo para continuar:");
    Console.WriteLine(
        "1 - calculadora\n" +
        "2 - Recomendação aleatória de anime\n" +
        "3 - Número aleatório\n" +
        "4 - Me pergunta algo e direi se vale a pena ou não\n"+
        "5 - Cálculo de IMC\n" +
        "6 - Fechar progama");

    
}
    static void MenuEscolhas()
{
    int escolha = int.Parse(Console.ReadLine());
    opcao NumeroEscolhido = (opcao)escolha;

    switch (NumeroEscolhido)
    {
        case opcao.Calculadora:
            MenudaCalculadora();
            break;
        case opcao.RecomendaçãoAleatoriaDeAnime:
            MenuAnimes();
            break;
        case opcao.CalculoIMC:
            MenuIMC();
            break;
        case opcao.SimOuNão:
            MenuDeDecisao();
            break;
        case opcao.NumeroAlt:
            MenuGeracaoDeNumero();
            break;
        default:
             break;
    }
}
    static void MenuAnimes()
{
    string[] animes ={"One piece","Mob psycho","Hunter vs Hunter","Nichijou","Death note","Another","Spy vs Family"};

    Random random = new Random();
    int NumeroAleatorio = random.Next(0 , 6);

    Console.WriteLine($"Seu anime do dia é: {animes[NumeroAleatorio]}");
    Console.ReadKey();


}
    static void MenuIMC()
{   // ARRAY COM INFORMAÇÕES COM BASE NO VALOR DO IMC.
    string[] informacoes = { "Magreza grave", "Magreza leve", "Eutrófico(Peso saudável)", "Sobrepeso", 
    "Obesidade I", "Obesidade sevéra","Obesidade mórbia"};

    //INTRDODUÇÃO AO IMC.
    Console.WriteLine("você está no menu IMC");
    Console.WriteLine("O que é IMC:\n" +
                      "O IMC(Índice de Massa Corporal) é uma medida internacional \r\n" +
                      "usada para calcular se uma pessoa está no peso ideal.");
    Console.WriteLine("Para começar,digite seu peso: ");

    int peso = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite sua altura: (Exemplo: 1,70)");

    float altura  = float.Parse(Console.ReadLine());

    Console.WriteLine("altura: " + altura +"m");
    Console.WriteLine("peso: " + peso +"kg");

    float imc = peso / ((float)altura * altura);

    //método para arrendondar o numero e limitar as casas decimais.
    float IMC_Com_Duas_Casas_Decimais = (float)Math.Round(imc, 2);

    Console.WriteLine($"seu IMC é: {IMC_Com_Duas_Casas_Decimais}");

    // SWITCH PARA A EXIBIÇÃO DE TIPO DE IMC BASEADO NO RESULTADO.
    switch(IMC_Com_Duas_Casas_Decimais)
    {
        case float n when (n < 17):
            Console.WriteLine($"tipo: {informacoes[0]}");
            break;
        case float n when (n < 18.5 && n >= 17):
            Console.WriteLine($"tipo: {informacoes[1]}");
            break;
        case float n when (n >= 18.5 && n <25 ):
            Console.WriteLine($"tipo: {informacoes[2]}");
            break;
        case float n when (n >= 25 && n < 30):
            Console.WriteLine($"tipo: {informacoes[3]}");
            break;
        case float n when (n >= 30 && n < 35):
            Console.WriteLine($"tipo: {informacoes[4]}");
            break;
        case float n when (n >= 35 && n <40):
            Console.WriteLine($"tipo: {informacoes[5]}");
            break;
        case float n when  (n > 40):
            Console.WriteLine($"tipo: {informacoes[6]}");
            break;
    }

    Console.WriteLine("Obs:os tipos mudam de acordo com a idade da pessoa, essa tabela\n" +
        "é planejada beseando-se em uma pessoa adulta. ");


}
    static void MenuDeDecisao()
{
    string[] respostas ={ "sim", "vale a pena", "não vale a pena","repense sobre isso","já procurou um medico?",
    "não","talvez"};
    string[] adjetivos ={ ", mero mortal,",", jovem,",", cabeça,","",};
    Random random = new Random();
    int NumeroAleatorio = random.Next(0, 6);
    int AdjetivoAleatorio = random.Next(0, 3);

    Console.WriteLine($"Me pergunte algo{adjetivos[AdjetivoAleatorio]} e lhe direi se vale a pena.");
    Console.ReadLine();
    Console.WriteLine(respostas[NumeroAleatorio]);

}
    static void MenudaCalculadora()
{
    string[] operacoes = { "+", "-", "*", "/" };
    int resultado = 0;

    Console.WriteLine("Por favor, digite um valor: ");
    int PrimeiroValorEscolhido = int.Parse(Console.ReadLine());

    Console.WriteLine("Escolha um operação: +, -, /, *");
    string OperacaoEscolhida = Console.ReadLine();

    Console.WriteLine("digite o segundo valor:");
    int SegundoValorEscolhido = int.Parse(Console.ReadLine());

    switch (OperacaoEscolhida)
    {
        case "+":
            resultado = PrimeiroValorEscolhido + SegundoValorEscolhido;
            Console.WriteLine($"o resultado de {PrimeiroValorEscolhido} {OperacaoEscolhida} {SegundoValorEscolhido} é: {resultado}");
            Console.ReadKey();
            break;
        case "-":
            resultado = PrimeiroValorEscolhido - SegundoValorEscolhido;
            Console.WriteLine($"o resultado de {PrimeiroValorEscolhido} {OperacaoEscolhida} {SegundoValorEscolhido} é: {resultado}");
            Console.ReadKey();
            break;
        case "*":
            resultado = PrimeiroValorEscolhido - SegundoValorEscolhido;
            Console.WriteLine($"o resultado de {PrimeiroValorEscolhido} {OperacaoEscolhida} {SegundoValorEscolhido} é: {resultado}");
            Console.ReadKey();
            break;
        case "/":
            float ResultadoEmFloat;
            ResultadoEmFloat = PrimeiroValorEscolhido / (float)SegundoValorEscolhido;

            Console.WriteLine($"o resultado de {PrimeiroValorEscolhido} {OperacaoEscolhida} {SegundoValorEscolhido} é: {ResultadoEmFloat}");
            Console.ReadKey();
            break;

    }


}
    static void MenuGeracaoDeNumero()
{
    Random random = new Random();
    int NumeroAleatorio = random.Next(0, 100);
    Console.WriteLine("seu número do dia é:" + NumeroAleatorio);
    Console.ReadKey();

}
}