namespace adapter.Models
{
    public class ArticuloCanastaBasica : Articulo
    {
        public ArticuloCanastaBasica(int id, string nombre, int precio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;

        }
    }
}