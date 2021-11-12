using adapter.Dtos;
using adapter.Models;
using System;

namespace adapter.Services.Articulos
{
    public class ArticuloElectronicoService : IArticulosService
    {
        public AddArticuloDto create()
        {
            Console.Write("Ingrese id: ");
            int idValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nombre: ");
            string nombreValue = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            int precioValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese marca: ");
            string marcaValue = Console.ReadLine();
            Console.Write("Ingrese modelo: ");
            string modeloValue = Console.ReadLine();

            ArticuloElectronico articuloElectronico = new ArticuloElectronico(
                idValue,
                nombreValue,
                precioValue,
                marcaValue,
                modeloValue
            );

            return new AddArticuloDto(
                articuloElectronico.Id,
                articuloElectronico.Nombre,
                articuloElectronico.Precio,
                "Electronico"
            );
        }
    }
}