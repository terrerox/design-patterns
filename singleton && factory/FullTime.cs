using System;

namespace RRHH
{
    public class FullTime : IEmployee
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
            Console.Write("Ingrese horas diarias de trabajo: ");
            int dailyWorkHoursValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese costo por hora: ");
            int costPerHourValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero de cuenta: ");
            string accountNumberValue = Console.ReadLine();

            FullTimeEntitie entitie = new FullTimeEntitie(
                nameValue,
                departmentValue,
                workStationValue,
                salaryValue,
                dailyWorkHoursValue,
                costPerHourValue,
                accountNumberValue
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