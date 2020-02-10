using System.Web.Http;
using System.Web.Http.Results;
using WebApiAula.Models;

namespace WebApiAula.Controllers
{
    public class UsuariosController : ApiController
    {
        /// <summary>
        /// Método responsável pela autenticação de usuário
        /// </summary>
        /// <param name="usuario">Objeto Usuario</param>
        /// <returns>Objeto Usuario no formato Json</returns>
        public JsonResult<Usuario> Login(Usuario usuario)
        {
            if (usuario.User.Equals("Admin") && usuario.Senha.Equals("Admin"))
                usuario.Mensagem = "Login realizado com sucesso.";
            else
                usuario.Mensagem = "Erro ao efetuar login.";

            return Json(usuario);
        } 
    }
}
