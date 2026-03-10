namespace WebApiExemploBiblioteca.Entidades
{
    public class AudioBook:Livro
    {
        public string Narrador { get; set; }
        public int DuracaoMinutos { get; set; }
    }
}
