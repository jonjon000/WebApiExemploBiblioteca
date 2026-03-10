using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;

namespace WebApiExemploBiblioteca.Controllers
{ 

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("MostrarUsuario")]
        public string MostrarUsuario(int idUsuario ,string cpfUsuario , string nomeUsuario , string enderecoUsuario , string cidadeUsuario , string telefoneUsuario )
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nomeUsuario;
            usuario.Id = idUsuario;
            usuario.Cpf = cpfUsuario;
            usuario .Endereco = enderecoUsuario;
            usuario.Cidade = cidadeUsuario;
            usuario.TelefoneCelular= telefoneUsuario;



            string resultado = $"Usuario : {usuario.Id}\r\n/" +
                               $" Nome: {usuario.Nome} \r\n" +
                               $" CPF: {usuario.Cpf} \r\n " +
                               $"Endereco: {usuario.Endereco}\r\n"+
                               $"Cidade: {usuario.Cidade}\\r\n"+
                               $"Telefone: {usuario. TelefoneCelular}";


            return resultado;
           
        }
        [HttpGet("MostrarUsuarioJSON")]
        public IActionResult MostrarUsuarioJSON(int idUsuario, string cpfUsuario, string nomeUsuario, string enderecoUsuario, string cidadeUsuario, string telefoneUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nomeUsuario;
            usuario.Id = idUsuario;
            usuario.Cpf = cpfUsuario;
            usuario.Endereco = enderecoUsuario;
            usuario.Cidade = cidadeUsuario;
            usuario.TelefoneCelular = telefoneUsuario;

            return Ok(usuario);
        }
    }
}
