using System.ComponentModel;

namespace POO;

class Program
{
    static void Main(string[] args)
    {
        // instanciando o objeto da classe carro
        Carro meuCarro = new Carro();

        // definindo valores para os atributos
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2022;

        // chamando o método
        meuCarro.ExibirInformacoes();

        // instanciando o objeto moto
        Moto minhaMoto = new Moto();
        minhaMoto.Marca = "Honda";
        minhaMoto.Ano = 2021;
        minhaMoto.TemPartidaEletrica = true;

        minhaMoto.ExibirDetalhesMoto();
    }
}
