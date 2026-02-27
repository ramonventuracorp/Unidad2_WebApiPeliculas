using WebApiPeliculas.Entities;

namespace WebApiPeliculas.Features.Peliculas
{
    public class PeliculasAppService
    {
        private List<Pelicula> peliculas = new List<Pelicula>();
        private PeliculasDomainService domain;

        public PeliculasAppService()
        {
            Pelicula pelicula1 = new Pelicula();
            pelicula1.Id = 1;
            pelicula1.Nombre = "Terminator";
            pelicula1.Categoria = "Accion";
            pelicula1.Sinopsis = "";
            pelicula1.FechaEstreno = new DateTime(2000, 01, 01);
            peliculas.Add(pelicula1);

            Pelicula pelicula2 = new Pelicula();
            pelicula2.Id = 2;
            pelicula2.Nombre = "Jurassic World";
            pelicula2.Categoria = "Accion";
            pelicula2.Sinopsis = "";
            pelicula2.FechaEstreno = new DateTime(2000, 01, 01);
            peliculas.Add(pelicula2);

            Pelicula pelicula3 = new Pelicula();
            pelicula3.Id = 3;
            pelicula3.Nombre = "El exorcista";
            pelicula3.Categoria = "Terror";
            pelicula3.Sinopsis = "";
            pelicula3.FechaEstreno = new DateTime(2000, 01, 01);
            peliculas.Add(pelicula3);

            Pelicula pelicula4 = new Pelicula();
            pelicula4.Id = 4;
            pelicula4.Nombre = "Viaje de Chijiro";
            pelicula4.Categoria = "Anime";
            pelicula4.Sinopsis = "";
            pelicula4.FechaEstreno = new DateTime(2000, 01, 01);
            peliculas.Add(pelicula4);

            Pelicula pelicula5 = new Pelicula();
            pelicula5.Id = 5;
            pelicula5.Nombre = "Rapido y Furioso 10";
            pelicula5.Categoria = "Autos";
            pelicula5.Sinopsis = "";
            pelicula5.FechaEstreno = new DateTime(2000, 01, 01);
            peliculas.Add(pelicula5);

            domain = new PeliculasDomainService();
        }

        /// <summary>
        /// Metodo para obtener el listado de todas las peliculas   
        /// </summary>
        /// <returns>Un listado de todas las peliculas</returns>
        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculas;
        }

        // Metodo para obtener pelicula por ID
        public Pelicula ObtenerPeliculaPorId(int id)
        {
            return peliculas.Where(x => x.Id == id).First();
        }

        // Metodo para agregar una nueva pelicula
        public void GuadarPelicula(Pelicula pelicula)
        {
            if (!domain.GuardarPelicula(pelicula))
            {
                return;
            }
            peliculas.Add(pelicula);
        }

        // Metodo para actualizar una pelicula existente
        public void ActualizarPelicula(Pelicula pelicula)
        {
            Pelicula? peliculaExistente = 
                peliculas.Where(x => x.Id  == pelicula.Id).FirstOrDefault();

            // En caso de no encontrarse, retornar
            if (peliculaExistente == null)
            {
                return;
            }

            // En caso de encontrar un registro
            peliculaExistente.Nombre = pelicula.Nombre;
            peliculaExistente.Descripcion = pelicula.Descripcion;
            peliculaExistente.Categoria = pelicula.Categoria;
            peliculaExistente.Sinopsis = pelicula.Sinopsis;
            peliculaExistente.FechaEstreno = pelicula.FechaEstreno;
        }

        public void EliminarPelicula(int id)
        {
            peliculas.RemoveAll(x => x.Id == id);
        }
    }
}
