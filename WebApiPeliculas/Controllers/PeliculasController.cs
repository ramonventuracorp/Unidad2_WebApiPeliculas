using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPeliculas.Entities;
using WebApiPeliculas.Features.Peliculas;

namespace WebApiPeliculas.Controllers
{
    [Route("api/PelisController")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly PeliculasAppService peliculasAppService;
        public PeliculasController(PeliculasAppService peliculasAppService)
        {
            this.peliculasAppService = peliculasAppService;
        }

        // Endpoint para listar todas las peliculas
        [HttpGet("ListarPeliculas")]
        public IActionResult ObtenerPeliculas()
        {
            List<Pelicula> peliculas = peliculasAppService.ObtenerPeliculas();
            return Ok(peliculas);
        }

        // Endpoint para listar peliculas por categoria
        [HttpGet]
        [Route("ListarPeliculasPorCategoria")]
        public IActionResult ObtenerPeliculasPorCategoria()
        {
            return Ok("Peliculas por categoria");
        }

        // Endpoint para obtener una pelicula por su id
        [HttpGet]
        [Route("ObtenerPeliculaPorId/{id}")]
        public IActionResult ObtenerPeliculaPorId([FromRoute] int id)
        {
            return Ok(peliculasAppService.ObtenerPeliculaPorId(id));
        }

        // Endpoint para agregar una nueva pelicula
        [HttpPost]
        [Route("AgregarPelicula")]
        public IActionResult GuadarPelicual([FromBody] Pelicula pelicula)
        {
            peliculasAppService.GuadarPelicula(pelicula);
            return Ok("Pelicula agregada exitosamente.");
        }

        // Endpoint para actualizar una pelicula existente
        [HttpPut]
        [Route("ActualizarPelicula")]
        public IActionResult ActualizarPelicula([FromBody] Pelicula pelicula)
        {
            peliculasAppService.ActualizarPelicula(pelicula);
            return Ok("Pelicula actualizada exitosamente");
        }

        // Endpoint para borrar una pelicula existente
        [HttpDelete]
        [Route("EliminarPelicula/{id}")]
        public IActionResult EliminarPelicula([FromRoute] int id)
        {
            peliculasAppService.EliminarPelicula(id);
            return Ok("Pelicula eliminada exitosamente");
        }
    }
}
