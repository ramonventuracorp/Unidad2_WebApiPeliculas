namespace WebApiPeliculas.Entities
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Sinopsis { get; set; }
        public DateTime FechaEstreno { get; set; }

    }
}
