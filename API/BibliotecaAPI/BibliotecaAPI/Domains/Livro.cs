using System.Reflection.Metadata;

namespace BibliotecaAPI.Domains
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor {  get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel { get; set; } = true;
    }
}
