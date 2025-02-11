using System;

// Atividades
// LISTA 2
//1) uma loja de eletrodomesticos permite que seus produtos sejam pagos em ate 5 parcelas crie uma rotina
//que calcule o valor que cada parcela a ser paga apos serem fornecidos o valor da compra, da entrada e a
//quantidade de parcelas
class Program
{      
    static void Main(string[] args)
    {
        int atividades;
        Console.WriteLine("=== Lista de atividades ===");
        Console.WriteLine("Escolha qual atividade:");
        atividades = int.Parse(Console.ReadLine());
        switch (atividades)
        {
            case 1:
                Lista2Exercicio1();
                break;
            case 2:
                Lista1Exercicio1();
                break;
            case 3:
                Lista1Exercicio2();
                break;
            case 4:
                Lista1Exercicio3();
                break;
            case 5:
                Lista1Exercicio4();
                break;
            case 6:
                Lista1Exercicio5();
                break;

        }      
    }
    static void Lista2Exercicio1()
    {
        double valorCompra;
        double entrada;
        double valorTotal;
        int quantidadeParcelas;


        Console.WriteLine("Digite a quantidade de parcelas: ");
        quantidadeParcelas = int.Parse(Console.ReadLine());

        if (quantidadeParcelas <= 5)
        {
            Console.WriteLine("Digite qual o valor da compra: ");
            valorCompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da entrada: ");
            entrada = double.Parse(Console.ReadLine());

            valorTotal = (valorCompra - entrada) / quantidadeParcelas;
            Console.WriteLine("O valor total eh " + valorTotal);

        }
        else
        {
            Console.WriteLine("O valor máximo de parcelas são 5!!! ");
        }

    }

    //LISTA 1

    //1)Crie um programa que receba as quatro notas que um aluno conquistou na matéria de
    //ano letivo. O programa deve calcular C exibir:
    //a) A média das notas;
    //b) A soma das notas;
    //c) A maior nota conquistada.
    static void Lista1Exercicio1()
    {
        double nota1;
        double nota2;
        double nota3;
        double nota4;
        double media;
        double somadasnotas;

        Console.WriteLine("Digite o valor da priemira nota");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da segunda nota");
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da terceira nota");
        nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da quarta nota");
        nota4 = double.Parse(Console.ReadLine());

        somadasnotas = nota1 + nota2 + nota3 + nota4;
        media = (nota1 + nota2 + nota3 + nota4) / 4;
       
        Console.WriteLine("A soma das notas e igual a " + somadasnotas);
        Console.WriteLine("A media das notas e igual a " + media);
    
    }
    // 2) Um motorista deseja colocar no seu tanque do seu carro X reais de gasolina.
    // Escreva um algoritimo para ler o preco do litro de gasolina,
    // o valor do pagamento e exibir quantos litros ele abastecera o carro. 
    static void Lista1Exercicio2()
    {
        double litroGasolina;
        double pagamento;
        double litroTotal;

        Console.WriteLine("Digite o valor do litro da gasolina: ");
        litroGasolina = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do pagamento: ");
        pagamento = double.Parse(Console.ReadLine());

        litroTotal = pagamento / litroGasolina;

        Console.WriteLine("O carro possui " + litroTotal + "litros de gasolina");
    }
    // 3) Em um restaurante self-service o quilo da refeicao e RS 58,00.
    // Escreva um algoritimo que leia o peso da refeicao de um cliente (em quilos) e imprima o valor a pagar
    static void Lista1Exercicio3()
    {
        double quiloCliente;
        double valorPagamento;
        double quilo = 58.00;

        Console.WriteLine("Digite o peso da refeicao: ");
        quiloCliente = double.Parse(Console.ReadLine());

        valorPagamento = quiloCliente * quilo;

        Console.WriteLine("O valor a ser pago e" + valorPagamento);
    }
    //4) Crie uma rotina que calcule o valor da area de um quadrado
    static void Lista1Exercicio4()
    {
        double valorLados;
        double area;

        Console.WriteLine("Digite o valor dos lados do quadrado: ");
        valorLados = double.Parse(Console.ReadLine());
        area= Math.Pow(valorLados, 2);

        Console.WriteLine("O valor da area e " + area);
    }
    // 5) Crie uma rotina que calcule os valores do perimetro e da area de um
    // retangulo a partir da leitura dos valores da base e da altura
    static void Lista1Exercicio5()
    {
        double largura;
        double altura;
        double area;
        double perimetro;


        Console.WriteLine("Digite o valor da largura do retangulo: ");
        largura = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do retangulo: ");
        altura = double.Parse(Console.ReadLine());

        perimetro = (largura*2)+(altura*2); 
        area= largura * altura;

        Console.WriteLine("A area e " + area);
        Console.WriteLine("O perimetro e " + perimetro);

    }
}   
