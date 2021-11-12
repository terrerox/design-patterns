namespace adapter.Models
{
    public class ArticuloDeVestir : Articulo
    {
        public ArticuloDeVestir(int id, string nombre, int precio, string size)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Size = size;

        }
        public string Size { get; set; }
    }
}