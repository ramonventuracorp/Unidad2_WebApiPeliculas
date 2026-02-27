using WebApiPeliculas.Entities;

namespace WebApiPeliculas.Features.Peliculas
{
    public class PeliculasDomainService
    {
        public PeliculasDomainService() { }

        /// <summary>
        /// Validaciones al momento de agregar una nueva pelicula
        /// </summary>
        /// <param name="pelicula"></param>
        public bool GuardarPelicula(Pelicula pelicula)
        {
            if (string.IsNullOrEmpty(pelicula.Nombre) || 
                string.IsNullOrEmpty(pelicula.Descripcion))
            {
                return false;
            }

            return true;
        }
    }
}
