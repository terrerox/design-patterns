using System;
using RRHH.Entities;
using RRHH.Dtos;

namespace RRHH.Services
{
    public class FullTimeService : IEmployee
    {
        public GetEmployeeDto Hire() 
        {
            Console.Write("Ingrese cedula: ");
            string cedulaValue = Console.ReadLine();
            Console.Write("Ingrese nombre: ");
            string nameValue = Console.ReadLine();
            Console.Write("Ingrese departamento: ");
            string departmentValue = Console.ReadLine();
            Console.Write("Ingrese puesto de trabajo: ");
            string workStationValue = Console.ReadLine();
            Console.Write("Ingrese salario: ");
            int salaryValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese horas diarias de trabajo: ");
            int workHoursValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese costo por hora: ");
            int costPerHourValue = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero de cuenta: ");
            string accountNumberValue = Console.ReadLine();

            GetEmployeeDto employeeDto = new GetEmployeeDto (
                cedulaValue,
                nameValue,
                departmentValue,
                workStationValue,
                salaryValue,
                DateTime.Now
            );

            Logger logger = Logger.GetLogger();

            logger.WriteLog(employeeDto);

            return employeeDto;
        }
    }
}