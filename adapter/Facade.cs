using System;
using System.Collections.Generic;
using adapter.Dtos;
using adapter.Models; 
using adapter.Services.Facturacion;
using adapter.Services.Articulos;

namespace adapter
{
    public class Facade
    {
        private List<AddArticuloDto> articulos = new List<AddArticuloDto>();
        private List<DetallesFacturacion> detalles = new List<DetallesFacturacion>();
        private IFacturacionService facturacion;
        private DetallesFacturacion detalle;
        public void AgregarArticulo ()
        {
            Console.Clear();
            Console.Write("¿Cuál tipo de articulo desea agregar?\n");
            Console.Write("1) Artículo de canasta básica \n");
            Console.Write("2) Artículo electrónico \n");
            Console.Write("Cualquier otro nùmero) Artículo de vestir  \n");
            Console.Write("Ingrese el número que desee: ");
            int option = int.Parse(Console.ReadLine());
            
            IArticulosService agregarArticulo = Factory.GetArticulo(option);

            articulos.Add(agregarArticulo.create());

            Console.Write("Articulo agregado correctamente!");
        }
        public void VenderArticulo ()
        {
            Console.Clear();
            bool option = true;
            do {
                string TipoDeArticulo = PreguntarTipoArticuloParaVender();
                GetAllArticulos(TipoDeArticulo);
                Console.WriteLine("Selecciona ID del articulo que desea comprar ");
                int idValue = int.Parse(Console.ReadLine());
                AddArticuloDto ArticuloSeleccionado = findArticuloById(idValue);
                if (ArticuloSeleccionado != null)
                {
                    Console.WriteLine("Ingrese la cantidad que desea comprar ");
                    int cantidad = int.Parse(Console.ReadLine());
                    detalle = new DetallesFacturacion(
                        ArticuloSeleccionado.Nombre,
                        ArticuloSeleccionado.Precio,
                        cantidad,
                        ArticuloSeleccionado.Precio * cantidad
                    );
                    detalles.Add(detalle);
                    Console.WriteLine("¿Deseas comprar mas articulos? [1] Si [2] No");
                    int QValue = int.Parse(Console.ReadLine());
                    if(QValue == 2) 
                    {
                        facturacion = FacturacionFactory.GetFacturacion(TipoDeArticulo);
                        facturacion.Cobrar(detalles);
                        option = false;
                    } else {
                        Console.Clear();
                    }
                    
                } else {
                    Console.Write("ID del articulo no existe");
                    option = false;
                }
            } while (option);
        }

        // helpers 
        private string PreguntarTipoArticuloParaVender () {
            Console.Write("¿Cuál tipo de articulo desea vender?\n");
            Console.Write("1) Artículo de canasta básica \n");
            Console.Write("2) Artículo electrónico \n");
            Console.Write("3) Artículo de vestir  \n");
            Console.Write("Ingrese el número que desee: ");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                return "Canasta";
            } else if (option == 2) {
                return "Electronico";
            } else {
                return "Vestir";
            }
        }
        private void GetAllArticulos (string tipo) {
            foreach (AddArticuloDto articulo in articulos) {
                if (articulo.Tipo == tipo) {
                    Console.WriteLine(
                        $"Id: {articulo.Id} \n"+
                        $"Nombre: {articulo.Nombre} \n"+
                        $"Precio: {articulo.Precio} \n"
                    );
                } else {
                    continue;
                }
            }
        }
        private AddArticuloDto findArticuloById (int id) {
            foreach (AddArticuloDto articulo in articulos) {
                if (articulo.Id == id) {
                    return articulo;
                } else {
                    continue;
                }
            }
            return null;
        }
    }
}