namespace SistemaDeCursos;

class Program
{
    static void Main(string[] args)
    {
        List<Curso> cursos = new List<Curso>
        {
            new Tecnico("Desenvolvimento de Sistemas", 360),
            new Superior("Cybersegurança", 500)
        };

        foreach(var curso in cursos)
        {
            curso.ExibirResumo();
        }
    }
}
