namespace adapter.Models
{
    public class DetallesFacturacion
    {
        public DetallesFacturacion(string nombre, int precio, int cantidad, int importe)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Importe = importe;

        }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int Importe { get; set; }
    }
}