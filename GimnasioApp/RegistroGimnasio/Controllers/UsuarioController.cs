using Microsoft.AspNetCore.Mvc;
using RegistroGimnasio.Models;

namespace RegistroGimnasio.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario usuario)
        {
            UsuarioStorage.GuardarUsuario(usuario);
            ViewBag.Mensaje = $"Usuario {usuario.Nombre} registrado por {usuario.PeriodoMeses} meses.";
            return View();
        }

        public IActionResult Lista()
        {
            var usuarios = UsuarioStorage.LeerUsuarios();
            return View(usuarios);
        }
    }
}
