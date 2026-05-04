namespace Funcoes;

class Program
{
    static void Main(string[] args)
    {
        /*
            tipoDeRetorno NomeDaFuncao(parametros) 
            {
                    comandos da função
            }
        */

        // //! sem parametros e sem retorno
        // static void MostrarMensagem()
        // {
        //     Console.WriteLine("Olá! Boa tarde!");
        // }

        // // chamando a função
        // MostrarMensagem();

        // //! função com parâmetro
        // // parâmetro -> string nome
        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Olá, {nome}!");
        //     // Console.WriteLine("Olá" + nome);
        // }

        // Saudacao("Késsia");

        // //! função com retorno
        // // parametros a,b 
        // // retorno é a soma
        // static int Somar(int a, int b)
        // {
        //     return a + b;
        // }

        // int resultado = Somar(10, 2);
        // Console.WriteLine(resultado);

        // static void ExibirDobro(int num)
        // {
        //     Console.WriteLine(num * 2);
        // }

        // ExibirDobro(10);

        // // Arrays -> armazena vários valores do mesmo tipo em uma única variável
        // int[] numeros = new int[5];

        // Console.WriteLine(numeros);
        
        // numeros[0] = 2;
        // numeros[1] = 5;
        // numeros[2] = 8;
        // numeros[3] = 15;
        // numeros[4] = 20;

        // Console.WriteLine(numeros);

        // // solução alternativa para mostrar o array (impresso em string)
        // Console.WriteLine(string.Join(", ", numeros));

        // string[] nomes = {"Penelope", "Juan", "Davi"};

        // // percorrendo com for
        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }

        // // percorrendo com foreach
        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // Função + Array
        // static double CalcularMedia(double[] notas)
        // {
        //     double soma = 0;

        //     // notas = [10, 5, 2]
        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         soma += notas[i];
        //         // soma = soma + nota[posicao]
        //     }

        //     return soma / notas.Length;
        // }

        // double[] notasAluno = {8.0, 7.5, 9.0, 6.5};

        // double media = CalcularMedia(notasAluno);

        // Console.WriteLine($"Média final: {media}");

        // // outro exemplo
        // int[] numeros = new int[5];
        // int soma = 0;

        // for(int i = 0; i < numeros.Length; i++)
        // {
        //     Console.WriteLine($"Digite o {i + 1}º número: ");
        //     numeros[i] = int.Parse(Console.ReadLine());

        //     soma += numeros[i];
        // }

        // Console.WriteLine(string.Join(", ", numeros));
        // Console.WriteLine($"A soma dos números é: {soma}");

        /*
            Criar um programa que:

            1. Leia o nome de 3 alunos.
            2. Leia a nota de cada aluno.
            3. Use uma função para verificar se o aluno foi aprovado.
            4. Mostre o resultado final.
        */

        static string VerificarSituacao(double nota)
        {
            if(nota >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }

        }

        string[] alunos = new string[3];
        double[] notas = new double[3];

        for(int i = 0; i < alunos.Length; i++)
        {
            Console.Write("Digite o nome do aluno: ");
            alunos[i] = Console.ReadLine();

            Console.WriteLine("Digite a nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        // alunos = ["Samuel", "Felipe", "Lucas"]
        // notas = [7.0, 10.0, 9.5]
        for(int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno: {alunos[i]} - Nota: {notas[i]} - Situação: {VerificarSituacao(notas[i])}");
        }


    }
}
