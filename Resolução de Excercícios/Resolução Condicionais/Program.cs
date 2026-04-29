using System.Net.NetworkInformation;

namespace Resolução_Condicionais;

class Program
{
    static void Main(string[] args)
    {
        // //! Facil - 1
        // Console.Write("Digite a temperatura: ");
        // double temperatura = double.Parse(Console.ReadLine());

        // if(temperatura < 15)
        // {
        //     Console.WriteLine("Frio");
        // }
        // else
        // {
        //     Console.WriteLine("Agradavel/quente");
        // }

        // //! Facil - 2
        // int numero = 200;

        // if(numero > 100)
        // {
        //     Console.WriteLine("Maior que 100");
        // }
        // else
        // {
        //     Console.WriteLine("Não é maior que 100.");
        // }

        // //! Facil - 3
        // string senha = "4567";

        // if(senha == "123")
        // {
        //     Console.WriteLine("Senha correta.");
        // }
        // else
        // {
        //     Console.WriteLine("Senha incorreta");
        // }

        // //! Facil - 4
        // int num = 5;

        // if(num < 0)
        // {
        //     Console.WriteLine("Número inválido.");
        // }

        // Console.WriteLine("Número válido.");

        // //! Facil - 5
        // Console.Write("Digite sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // Console.WriteLine(idade >= 16 ? "Cadastro permitido" : "Cadastro não permitido");

        // //! Facil - 6
        // Console.Write("Digite o número do turno: (1 - manhã / 2 - tarde / 3 - noite): ");

        // int turno = int.Parse(Console.ReadLine());

        // switch(turno)
        // {
        //     case 1:
        //         Console.WriteLine("Manhã");
        //         break;
        //     case 2:
        //         Console.WriteLine("Tarde");
        //         break;
        //     case 3:
        //         Console.WriteLine("Noite");
        //         break;
        //     default:
        //         Console.WriteLine("Turno inválido.");
        //         break;
        // }

        // //! Facil - 7
        // Console.Write("Digite uma opção: (1 - Novo jogo / 2 - Carregar jogo / 3 - Sair): ");

        // int opcao = int.Parse(Console.ReadLine());

        // switch(opcao)
        // {
        //     case 1:
        //         Console.WriteLine("Novo jogo");
        //         break;
        //     case 2:
        //         Console.WriteLine("Carregar jogo");
        //         break;
        //     case 3: 
        //         Console.WriteLine("Sair");
        //         break;
        //     default:
        //         Console.WriteLine("Opção inválida.");
        //         break;
        // }

        // //! Médio - 1
        // Console.WriteLine("Digite a idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade <= 12)
        // {
        //     Console.WriteLine("Criança");
        // }
        // else if (idade >= 13 && idade <= 17)
        // {
        //     Console.WriteLine("Adolescente");
        // }
        // else
        // {
        //     Console.WriteLine("Adulto");
        // }

        // //! Médio - 2
        // int a = 50;
        // int b = 2;

        // int maior = a > b ? a : b;

        // Console.WriteLine(maior);

        // //! Médio - 3
        // int idade = 20;
        // bool ingresso = false;

        // if(idade > 18 || ingresso)
        // {
        //     Console.WriteLine("Entrada permitida");
        // }
        // else
        // {
        //     Console.WriteLine("Entrada negada.");
        // }

        // //! Médio - 4
        // int num = 2;

        // if(num < 0 || num > 10)
        // {
        //     Console.WriteLine("Valor inválido.");
        // }

        // //! Médio - 5
        // int idade = 5;

        // if(idade < 18)
        // {
        //     Console.WriteLine("Sem desconto");
        // }
        // else if(idade >= 18 && idade <= 59)
        // {
        //     Console.WriteLine("10% de desconto");
        // }
        // else
        // {
        //     Console.WriteLine("20% de desconto");
        // }

        // //! Médio - 6
        // decimal valor = 850m;

        // decimal final = valor >= 200 ? valor * 0.85m : valor * 0.95m;

        // Console.WriteLine(final);

        // //! Médio - 7
        // Console.Write("Digite o primeiro valor: ");
        // double a = double.Parse(Console.ReadLine());

        // Console.Write("Digite o segundo valor: ");
        // double b = double.Parse(Console.ReadLine());

        // Console.Write("Digite a operação desejada (+, -, * ou /): ");
        // string op = Console.ReadLine();

        // switch(op)
        // {
        //     case "+":
        //         Console.WriteLine("Resultado: " + (a + b));
        //         break;
        //     case "-":
        //         Console.WriteLine("Resultado: " + (a - b));
        //         break;
        //     case "*":
        //         Console.WriteLine("Resultado: " + (a * b));
        //         break;
        //     case "/":
        //         Console.WriteLine("Resultado: " + (a / b));
        //         break;
        //     default:
        //         Console.WriteLine("Opção inválida!");
        //         break;
        // }
        
        // //! Médio - 8
        // Console.Write("Digite o dia: ");
        // int dia = int.Parse(Console.ReadLine());

        // switch(dia)
        // {
        //     case 1:
        //     case 7:
        //         Console.WriteLine("Fim de semana");
        //         break;
        //     case 2:
        //     case 3:
        //     case 4:
        //     case 5:
        //     case 6:
        //         Console.WriteLine("Dia útil");
        //         break;
        //     default:
        //         Console.WriteLine("Dia inválido");
        //         break;

        // }
        
        // //! Médio - 9
        // Console.Write("Digite o plano (Básico | Intermediário | Premium): ");
        // string plano = Console.ReadLine().ToLower();
        // // ToLower() -> deixa o texto em minúsculo

        // switch(plano)
        // {
        //     case "básico":
        //         Console.WriteLine("10MB");
        //         break;
        //     case "Intermediário":
        //         Console.WriteLine("50MB");
        //         break;
        //     case "Premium":
        //         Console.WriteLine("100MB");
        //         break;
        //     default:
        //         Console.WriteLine("Plano inválido");
        //         break;
        // }

        // //! Difícil - 1
        // double nota = 5.0;

        // if(nota < 0 || nota > 10)
        // {
        //     Console.WriteLine("Nota inválida");
        // }
        // else if (nota >= 7)
        // {
        //     Console.WriteLine("Aprovado");
        // }
        // else if (nota >= 5)
        // {
        //     Console.WriteLine("Recuperação");
        // }
        // else
        // {
        //     Console.WriteLine("Reprovado");
        // }

        // //! Difícil - 2
        // int a = 10;
        // int b = -5;
        // int c = 3;

        // if(a > 0 && b > 0 && c > 0)
        // {
        //     Console.WriteLine("Pode formar um triângulo");
        // }
        // else
        // {
        //     Console.WriteLine("Inválido");
        // }

        // //! Difícil - 3
        // Console.Write("Digite o primeiro valor: ");
        // double a = double.Parse(Console.ReadLine());

        // Console.Write("Digite o segundo valor: ");
        // double b = double.Parse(Console.ReadLine());

        // Console.Write("Digite a operação desejada (+, -, * ou /): ");
        // string op = Console.ReadLine();

        // if(op == "+")
        // {
        //     Console.WriteLine("Resultado: " + (a + b));
        // }
        // else if(op == "-")
        // {
        //     Console.WriteLine("Resultado: " + (a - b));
        // }

        // else if(op == "*")
        // {
        //     Console.WriteLine("Resultado: " + (a * b));
        // }
        // else if(op == "/")
        // {
        //     Console.WriteLine("Resultado: " + (a / b));
        // }
        // else
        // {
        //     Console.WriteLine("Operação inválida.");
        // }

        // //! Difícil - 4
        // string usuario = "kessia";
        // string senha = "1234";

        // if(usuario == "admin" && senha == "1234")
        // {
        //     Console.WriteLine("Acesso liberado.");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado");
        // }

        // //! Difícil - 5
        // int numero = 5;

        // string resultado = numero > 0 ? "Positivo" : numero == 0 ? "Zero" : "Negativo";

        // Console.WriteLine(resultado);

        // //! Difícil - 6
        // Console.Write("Digite o primeiro valor: ");
        // double a = double.Parse(Console.ReadLine());

        // Console.Write("Digite o segundo valor: ");
        // double b = double.Parse(Console.ReadLine());

        // Console.Write("Digite a operação desejada (+, -, * ou /): ");
        // string op = Console.ReadLine();

        // switch(op)
        // {
        //     case "+":
        //         Console.WriteLine("Resultado: " + (a + b));
        //         break;
        //     case "-":
        //         Console.WriteLine("Resultado: " + (a - b));
        //         break;
        //     case "*":
        //         Console.WriteLine("Resultado: " + (a * b));
        //         break;
        //     case "/":
        //         if(a == 0 || b == 0)
        //         {
        //             Console.WriteLine("Erro: não podemos dividir por zero");
        //         }

        //         Console.WriteLine("Resultado: " + (a / b));
        //         break;
        //     default:
        //         Console.WriteLine("Opção inválida!");
        //         break;
        // }

        // //! Difícil - 7
        // Console.Write("Digite uma opção (1 - Água / 2 - Refrigerante / 3 - Suco): ");
        // int opcao = int.Parse(Console.ReadLine());

        // switch(opcao)
        // {
        //     case 1:
        //         Console.WriteLine("Água - R$2");
        //         break;
        //     case 2:
        //         Console.WriteLine("Refrigerante - R$5");
        //         break;
        //     case 3:
        //         Console.WriteLine("Suco - R$4");
        //         break;
        //     default:
        //         Console.WriteLine("Opção inválida.");
        //         break;
        // }
    }
}
