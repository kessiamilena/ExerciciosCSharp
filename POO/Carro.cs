
namespace POO
{
    // classe derivada (subclasse) -> herda informações de veiculo
    public class Carro : Veiculo
    {
        // Atributos da classe
        // public string Marca;
        public string Modelo;
        // public int Ano;

        // Métodos (ações que a classe pode realizar)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}