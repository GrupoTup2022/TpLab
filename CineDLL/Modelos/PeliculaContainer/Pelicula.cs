namespace LibreriaTp
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo_Local { get; set; }
        public string Titulo_Original { get; set; }
        public string Descripcion { get; set; }
        public Pais Pais { get; set; }
        public Clasificacion Clasificacion { get; set; }
        public DateTime Fecha_Estreno { get; set; }
        public int duracion { get; set; }
        public Distribuidora Distribuidora { get; set; }
    }
}
