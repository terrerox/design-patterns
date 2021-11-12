using System;
using RRHH.Services;

namespace RRHH
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
                Console.Write("1) Agregar empleado \n");
                Console.Write("2) Otorgar vacaciones \n");
                Console.Write("3) Otorgar permiso \n");
                Console.Write("4) Desvinculación \n");
                Console.Write("Ingrese el número que desee: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        facade.HireEmployeeOperations();
                        break;
                    case 2:
                        facade.VacationOperations();
                        break;
                    case 3:
                        facade.PermissionOperations();
                        break;
                    case 4:
                        facade.UnlinkingOperations();
                        break; 
                } 


                Console.ReadKey();
            } while (option != 4);
        }
    }
}
