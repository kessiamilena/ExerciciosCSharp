using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

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

        // /*
        //     Criar um programa que:

        //     1. Leia o nome de 3 alunos.
        //     2. Leia a nota de cada aluno.
        //     3. Use uma função para verificar se o aluno foi aprovado.
        //     4. Mostre o resultado final.
        // */

        // static string VerificarSituacao(double nota)
        // {
        //     if(nota >= 7)
        //     {
        //         return "Aprovado";
        //     }
        //     else
        //     {
        //         return "Reprovado";
        //     }

        // }

        // string[] alunos = new string[3];
        // double[] notas = new double[3];

        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.Write("Digite o nome do aluno: ");
        //     alunos[i] = Console.ReadLine();

        //     Console.WriteLine("Digite a nota: ");
        //     notas[i] = double.Parse(Console.ReadLine());
        // }
        // // alunos = ["Samuel", "Felipe", "Lucas"]
        // // notas = [7.0, 10.0, 9.5]
        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.WriteLine($"Aluno: {alunos[i]} - Nota: {notas[i]} - Situação: {VerificarSituacao(notas[i])}");
        // }

        // Funções matemáticas
        // // valor absoluto -> se tiver um valor negativo, transforma em positivo
        // int valor = Math.Abs(-10); // 10
        // Console.WriteLine(valor);

        // // potência
        // double potencia = Math.Pow(2,3);// elevado
        // Console.WriteLine(potencia);

        // // raiz quadrada
        // double raiz = Math.Sqrt(25); 
        // Console.WriteLine(raiz);

        // // Arredondamento
        // double numero = Math.Round(3.6);
        // Console.WriteLine(numero);

        // // Random (gerar números aleatórios)
        // Random random = new Random(); // cria o gerador de números automáticos
        // int numero = random.Next(1, 101); // gera os números entre 1 e 100
        // // int numero = random.Next(101); // gera os números começando em 0.

        // Console.WriteLine(numero);

        // Funções para String

        // // tamanho da string
        // string texto = "CSharp";
        // int tamanho = texto.Length;

        // Console.WriteLine(tamanho);

        // string frase = "Olá mundo!";
        // frase = frase.Replace("mundo","C#");

        // Console.WriteLine(frase);

        // //Contains
        // string frase = "Estou aprendendo C#";

        // if(frase.Contains("C#"))
        // {
        //     Console.WriteLine("A frase contem 'C#'");
        // }

        // bool existe = frase.Contains("C#");
        // Console.WriteLine(existe);

        // int[] numeros = {1, 2, 4, 12, 8};
        // // Array.Sort(numeros); // ordenando valores
        // // Console.WriteLine(string.Join(", ", numeros));

        // // inverter valores
        // Array.Reverse(numeros);
        // Console.WriteLine(string.Join(", ", numeros));


        // // Simular adicionar valores em array
        // string[] nomes = {"Ana", "Bruno", "Carlos"};

        // string novoNome = "Pedro";

        // string[] novoArray = new string[nomes.Length + 1];

        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     novoArray[i] = nomes[i];
        // }

        // novoArray[novoArray.Length - 1] = novoNome;
        // nomes = novoArray;

        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // Adicionando elementos com List
        // List<string> nomes = new List<string>();

        // // adicionando nomes na lista (Add)
        // nomes.Add("Ana");
        // nomes.Add("Bruno");
        // nomes.Add("Carlos");
        // nomes.Add("Pedro");

        // // removendo nomes da lista (Remove)
        // nomes.Remove("Bruno");

        // // foreach (string nome in nomes)
        // // {
        // //     Console.WriteLine(nome);
        // // }

        // // acessar pela posição(indice)
        // //Console.WriteLine(nomes[0]); // Ana

        // // tamanho da lista
        // // Console.WriteLine(nomes.Count);

        // // // Realizando busca dentro da Lista
        // // Console.Write("Digite o nome na busca: ");
        // // string nomeDigitado = Console.ReadLine();

        // // if(nomes.Contains(nomeDigitado))
        // // {
        // //     Console.WriteLine("Nome encontrado!");
        // // }

        // // Inserindo nome em posição específica
        // nomes.Insert(2, "Paula");

        // // Removendo nome na posição
        // nomes.RemoveAt(3);

        // // Limpando a lista
        // nomes.Clear();

        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }
        
        
        // // Sisteminha: Removendo item digitado
        // List<string> produtos = new List<string>();

        // produtos.Add("Mouse");
        // produtos.Add("Teclado");
        // produtos.Add("Monitor");

        // Console.Write("Digite o produto para remover: ");
        // string remover = Console.ReadLine();

        // if(produtos.Contains(remover))
        // {
        //     // vai remover o produto
        //     produtos.Remove(remover);

        //     foreach(string produto in produtos)
        //     {
        //         Console.WriteLine(produto);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Produto digitado não existe na lista.");
        // }


        // Criar um menu com List

        // Menu vai ter as seguintes opções:
        // 1 - Adicionar tarefa
        // 2 - Listar tarefas
        // 3 - Remover tarefa
        // 0 - Sair

        // Dica:
        // - Criar menu com switch case
        // - Precisa ter um loop

        List<string> tarefas = new List<string>();
        int opcao;

        do
        {
            // perguntar opções
            Console.WriteLine("Bem vindo(a) ao menu do sistema de tarefas! :)");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Remover tarefa");
            Console.WriteLine("0 - Sair");

            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Opcao escolhida: " + opcao);

            switch(opcao)
            {
                case 1: 
                    Console.Write("Digite a tarefa: ");
                    tarefas.Add(Console.ReadLine());
                    break;
                case 2: 
                    Console.WriteLine("Tarefas: ");
                    foreach(string tarefa in tarefas)
                    {
                        Console.WriteLine(tarefa);
                    }
                    break;
                case 3: 
                    Console.WriteLine("Digite a tarefa para remover: ");
                    tarefas.Remove(Console.ReadLine());
                    break;
                case 0: 
                    Console.WriteLine("Saindo....");
                    Console.WriteLine("Sistema encerrado");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        while(opcao != 0);



    }
}
