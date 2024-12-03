using Codigo2024Clase31.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codigo2024Clase31.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
      
        [HttpGet]
        public List<string> ListarPaises()
        {
            List<string> paises = new List<string>();
            paises.Add("Perú");
            paises.Add("Bolivia");
            paises.Add("Arequipa");

            return paises;
        }
        [HttpGet]
        public List<string> ListarCiudades()
        {
            List<string> ciudades = new List<string>();
            ciudades.Add("Nasca");
            ciudades.Add("Ica");
            ciudades.Add("Chincha");

            return ciudades;
        }
        [HttpGet]
        public List<Persona> ListarPersonas()
        {
            List<Persona> personas = new List<Persona>();
            for (int i = 0; i < 100; i++)
            {                
                personas.Add(new Persona {
                    Id=i+1,
                    Apellidos = "Torrico", 
                    Nombres = "Hugo" });
            };


            return personas;
        }

        [HttpGet]
        public List<Producto> ListarProductos()
        {
            List<Producto> productos = new List<Producto>();
            for (int i = 0; i < 100; i++)
            {
                productos.Add(new Producto
                {
                    Id = i + 1,
                    Nombre = "Nombre",
                    Precio = 4000
                });
            };


            return productos;
        }
    }
}
