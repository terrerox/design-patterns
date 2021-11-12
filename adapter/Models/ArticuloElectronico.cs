namespace adapter.Models
{
    public class ArticuloElectronico : Articulo
    {
        public ArticuloElectronico(
            int id, 
            string nombre, 
            int precio, 
            string marca, 
            string modelo
        )
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Marca = marca;
            this.Modelo = modelo;

        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}