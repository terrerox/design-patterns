namespace adapter.Models
{
    public abstract class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}