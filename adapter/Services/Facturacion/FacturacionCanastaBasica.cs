using System;
using adapter.Models;
using System.Collections.Generic;


namespace adapter.Services.Facturacion
{
    public class FacturacionCanastaBasica : IFacturacionService
    {
        public void Cobrar(List<DetallesFacturacion> detalles)
        {
            int Total = 0;
            int TotalCantidad = 0;
            Console.Clear();
            Console.WriteLine("Articulo  Precio  Cantidad  Importe");
            foreach (DetallesFacturacion detalle in detalles) {
                Total += detalle.Importe;
                TotalCantidad += detalle.Cantidad;
                Console.WriteLine($"{detalle.Nombre}      {detalle.Precio}      {detalle.Cantidad}        {detalle.Importe}");
            }
            Console.WriteLine($"Total                {TotalCantidad}      {Total}");
        }
    }
}