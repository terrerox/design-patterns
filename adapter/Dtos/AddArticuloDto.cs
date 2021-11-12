namespace adapter.Dtos
{
    public class AddArticuloDto
    {
        public AddArticuloDto(int id, string nombre, int precio, string tipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Tipo = tipo;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Tipo { get; set; }
    }
}