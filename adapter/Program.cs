using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            int option;
            do {
                Console.Clear();
                Console.Write("Seleccione la opción que desee: \n");
                Console.Write("1) Agregar articulo \n");
                Console.Write("2) Vender articulo \n");
                Console.Write("Ingrese el número que desee: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        facade.AgregarArticulo();
                        break;
                    case 2:
                        facade.VenderArticulo();
                        break;
                } 
        
                Console.ReadKey();
            } while (option != 2);
        }
    }
}
