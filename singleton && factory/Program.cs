using System;

namespace RRHH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("¿Cuál tipo de empleando desea agregar?\n");
            Console.Write("1) Tiempo completo \n");
            Console.Write("2) Medio completo \n");
            Console.Write("3) Temporero \n");
            Console.Write("Ingrese el número que desee: ");
            int value = int.Parse(Console.ReadLine());

            IEmployee employee = Creator.GetEmployee(value);

            employee.Hire();

            Console.ReadKey();
        }
    }
}
