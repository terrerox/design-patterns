using System.Collections.Generic;
using System;
using adapter.Models;

namespace adapter.Services.Facturacion.Electronico
{
    public class FacturacionArticuloElectronicoAdapter : IFacturacionService
    {
        public void Cobrar(List<DetallesFacturacion> detalles)
        {
            int Subtotal = 0;
            int TotalCantidad = 0;
            int Impuestos = 0;
            
            Console.Clear();
            Console.WriteLine("Articulo  Precio  Cantidad  Importe");
            foreach (DetallesFacturacion detalle in detalles) {
                Subtotal += detalle.Importe;
                TotalCantidad += detalle.Cantidad;
                Impuestos += FacturacionArticuloElectronico.ITBISAndISC(detalle.Precio) * detalle.Cantidad;
                Console.WriteLine($"{detalle.Nombre}      {detalle.Precio}      {detalle.Cantidad}        {detalle.Importe}");
            }
            Console.WriteLine($"Subtotal                    {Subtotal}");
            Console.WriteLine($"Impuestos                   {Impuestos}");
            Console.WriteLine($"Total                {TotalCantidad}      {Subtotal + Impuestos}");
        }
    }
}