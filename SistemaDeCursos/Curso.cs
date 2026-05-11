
namespace SistemaDeCursos
{
    public abstract class Curso
    {
        public string Nome { get; set; } = string.Empty; // ""
        public int Horas { get; set; }

        public Curso(string NomeConstrutor, int HorasConstrutor)
        {
            Nome = NomeConstrutor;
            Horas = HorasConstrutor;
        }


        public abstract double CalcularPreco();

        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Curso: {Nome}");
            Console.WriteLine($"Carga horária: {Horas}");
            Console.WriteLine($"Preço Final: R${CalcularPreco():F2}\n");
            
        }

    }
}