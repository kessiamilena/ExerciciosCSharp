using System.Runtime.InteropServices;

namespace Condicionais;

class Program
{
    static void Main(string[] args)
    {
        // int numero = -6;

        // if(numero > 0)
        // {
        //     Console.WriteLine("Número positivo");
        // }

        // Console.WriteLine("Número negativo");

        // Console.Write("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // if(numero > 0)
        // {
        //     Console.WriteLine("Positivo");
        // }
        // else if (numero == 0)
        // {
        //     Console.WriteLine("O número é zero");
        // }
        // else
        // {
        //     Console.WriteLine("Negativo");
        // }


        // Console.Write("Digite sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade < 16)
        // {
        //     Console.WriteLine("Não pode votar");
        // }
        // else if (idade < 18)
        // {
        //     Console.WriteLine("Voto opcional");
        // }
        // else
        // {
        //     Console.WriteLine("Voto obrigatório");
        // }

        // Console.Write("Digite a nota: ");
        // double nota = double.Parse(Console.ReadLine());

        // if(nota >= 7)
        // {
        //     Console.WriteLine("Aprovado!");

        //     if(nota >= 9)
        //     {
        //         Console.WriteLine("Aprovado e ganhou estrelinha!");
        //     }
        // }
        // else if(nota >= 5)
        // {
        //     Console.WriteLine("Recuperação");
        // }
        // else
        // {
        //     Console.WriteLine("Reprovado!");
        // }

        // int n1 = 5;
        // int n2 = 25;

        // if(n1 > n2)
        // {
        //     Console.WriteLine("Primeiro(n1) é maior");
        // }
        // else if(n2 > n1)
        // {
        //     Console.WriteLine("Segundo(n2) é maior");
        // }
        // else
        // {
        //     Console.WriteLine("Números iguais");
        // }


        // Console.Write("Usuario: ");
        // string usuario = Console.ReadLine();

        // Console.Write("Senha: ");
        // string senha = Console.ReadLine();

        // if(usuario == "admin" && senha == "1234")
        // {
        //     Console.WriteLine("Acesso permitido.");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado");
        // }

        // Console.Write("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // // if ternário
        // string resultado = numero % 2 == 0 ? "Par" : "Impar";

        // Console.WriteLine(resultado);

        // // if(numero % 2 == 0)
        // // {
        // //     Console.WriteLine("Par!");
        // // }
        // // else
        // // {
        // //     Console.WriteLine("Ímpar!");
        // // }


        // int idade = 18;

        // Console.WriteLine(idade >= 18 ? "Maior de idade" : "Menor de idade");

        // // Switch case
        // Console.Write("Digite um número de 1 a 3: ");
        // int opcao = int.Parse(Console.ReadLine());

        // switch (opcao)
        // {
        //     case 1: 
        //         Console.WriteLine("Você escolheu a opção 1.");
        //         break;
        //     case 2: 
        //         Console.WriteLine("Você escolheu a opção 2.");
        //         break;
        //     case 3:
        //         Console.WriteLine("Você escolheu a opção 3.");
        //         break;
        //     default:
        //         Console.WriteLine("Opção inválida!");
        //         break;
        // }


        Console.Write("Digite uma opção: (A, B ou C): ");
        string escolha = Console.ReadLine().ToUpper();

        switch(escolha)
        {
            case "A":
                Console.WriteLine("Você escolheu a opção A.");
                break;
            case "B":
                Console.WriteLine("Você escolheu a opção B.");
                break;
            case "C":
                Console.WriteLine("Você escolheu a opção C.");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        // Console.WriteLine("Olá!");
        //teste


    }
}
