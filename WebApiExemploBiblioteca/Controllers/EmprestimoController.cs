using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;

namespace WebApiExemploBiblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        [HttpGet("MostrarDadoEmprestimo")]

        public string MostrarEmprestimo(int idEmprestimo, int IdLivro, int IdCliente, DateTime dataEmprestimo)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo. Id = idEmprestimo;
            emprestimo.IdLivro = IdLivro;
            emprestimo.IdCliente = IdCliente;
            emprestimo.DataEmprestimo = dataEmprestimo;
            string resultado = $"Dados do emprestimo\r\n" +
                               $"Id do Emprestimo: {emprestimo.Id}\r\n"+
                               $"Id do Livro Emprestado : {emprestimo.IdLivro}\r\n"+
                               $"Id Cliente: {emprestimo.IdCliente}\r\n"+
                               $"Data do Empretimo:{emprestimo.DataEmprestimo}";
            return resultado;
        }
    }
}
