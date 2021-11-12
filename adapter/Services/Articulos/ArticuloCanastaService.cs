using adapter.Dtos;
using adapter.Models;
using System;
namespace adapter.Services.Articulos
{
    public class ArticuloCanastaService : IArticulosService
    {
        public AddArticuloDto create()
        {
            Console.Write("Ingrese id: ");
            int idValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nombre: ");
            string nombreValue = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            int precioValue = int.Parse(Console.ReadLine());

            ArticuloCanastaBasica articulo = new ArticuloCanastaBasica(
                idValue,
                nombreValue,
                precioValue
            );

            return new AddArticuloDto(
                articulo.Id,
                articulo.Nombre,
                articulo.Precio,
                "Canasta"
            );
        }
    }
}