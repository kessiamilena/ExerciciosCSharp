
namespace SistemaDeCursos
{
    public class Superior : Curso
    {
        public Superior(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor)
        {
        }

        public override double CalcularPreco()
        {
            return Horas * 40;
        }
    }
}