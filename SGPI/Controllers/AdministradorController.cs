using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System.Linq;


namespace SGPI.Controllers
{
    public class AdministradorController : Controller
    {

        SGPIDBContext context= new SGPIDBContext();

        [HttpPost]
        public IActionResult Login(Usuario user)
        {

            var usuario = context.Usuarios
                .Where(consulta => consulta.NumeroDocumento == user.NumeroDocumento
                && consulta.Password == user.Password).FirstOrDefault();

            if (usuario != null)
            {
                if(usuario.IdRol == 1){ 
                    return View("MenuAdmBuscar");
                }
                else if(usuario.IdRol == 2){
                    return Redirect("Coordinador/MenuCoordinadorBuscar");
                }
                else if (usuario.IdRol == 3){
                    return Redirect("Estudiante/ActualizarEstudiante");
                }
                else{
                
                }
            }
            else{ }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult OlvidarContrasena()
        {
            return View();
        }

        public IActionResult MenuRegistro()
        {
            return View();
        }

        public IActionResult MenuAdmBuscar()
        {
            return View();
        }

        public IActionResult MenuAdmModificar()
        {
            return View();
        }

        public IActionResult Reportes()
        {
            return View();
        }
    }
}
