using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;

namespace WebApiExemploBiblioteca.Controllers
{
    public class LivroController : Controller
    {

        [HttpGet("MostrarLivroFisico")]

        public string MostrarLivro(int IdLivro, string nomeLivro)
        {
            LivroFisico livro = new LivroFisico();
            livro.Titulo = nomeLivro;
            livro.Id = IdLivro;
            string resultado = $"Livro : (livro.Id) - Nome (livro. Titulo)";
            return resultado;


        }
        [HttpPost("MostrarLivroFisicoJSON")]

        public IActionResult MostrarLivroJSON(int IdLivroUsuario,
                                               string nomeLivroUsuario,
                                               string autorLivroUsuario,
                                               string editoraLivroUsuario,
                                               DateTime dataPublicacaoLivro,
                                               string corredorLivro)

        {
            LivroFisico livro = new LivroFisico();
            livro.Titulo = nomeLivroUsuario;
            livro.Id = IdLivroUsuario;
            livro.Autor = autorLivroUsuario;
            livro.Editora = editoraLivroUsuario;
            livro.DataPublicacao = dataPublicacaoLivro;
            livro.Corredor = corredorLivro;

            return Ok(livro);
        }
       }
    }
}
