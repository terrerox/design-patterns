using System;

namespace RRHH
{
    public class Temporero : IEmployee
    {
        public void Hire() 
        {
            Console.Write("Ingrese nombre: ");
            string nameValue = Console.ReadLine();
            Console.Write("Ingrese departamento: ");
            string departmentValue = Console.ReadLine();
            Console.Write("Ingrese puesto de trabajo: ");
            string workStationValue = Console.ReadLine();
            Console.Write("Ingrese salario: ");
            int salaryValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese horas de trabajo: ");
            int workHoursValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese costo por hora: ");
            int costPerHourValue = int.Parse(Console.ReadLine());

            
            TemporeroEntitie entitie = new TemporeroEntitie(
                nameValue,
                departmentValue,
                workStationValue,
                salaryValue,
                workHoursValue,
                costPerHourValue
            );

            Logger logger = Logger.GetLogger(
                entitie.name,
                entitie.department,
                entitie.workStation,
                entitie.salary
            );

            logger.WriteLog();
        }
    }
}