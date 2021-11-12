using System;
using adapter.Dtos;
using adapter.Models;

namespace adapter.Services.Articulos
{
    public class ArticuloDeVestirService : IArticulosService
    {
        public AddArticuloDto create()
        {
            Console.Write("Ingrese id: ");
            int idValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nombre: ");
            string nombreValue = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            int precioValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese size: ");
            string sizeValue = Console.ReadLine();

            ArticuloDeVestir articuloDeVestir = new ArticuloDeVestir(
                idValue,
                nombreValue,
                precioValue,
                sizeValue
            );

            return new AddArticuloDto(
                articuloDeVestir.Id,
                articuloDeVestir.Nombre,
                articuloDeVestir.Precio,
                "Vestir"
            );
        }
    }
}