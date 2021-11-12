using RRHH.Entities;
using RRHH.Services;
using RRHH.Dtos;

using System.Collections.Generic;
using System;

namespace RRHH
{
    public class Facade
    {
        private Permission permission;
        private Unlinking unlinking;
        private Vacation vacation;

        private List<GetEmployeeDto> Employees = new List<GetEmployeeDto>();

        public void PermissionOperations () 
        {
            Console.Write("Ingrese cedula: ");
            string cedulaValue = Console.ReadLine();
            if(findByCedula(cedulaValue)) 
            {
                Console.Write("Ingrese fecha de permiso: ");
                string date = Console.ReadLine();
                DateTime dateValue = DateTime.Parse(date);

                permission = new Permission(cedulaValue, dateValue);

                Logger logger = Logger.GetLogger();

                logger.WritePermissionLog(permission);
                Console.Write("Almacenado en logger");
            } else {
                Console.Write("ERROR: Cedula no registrada");
            }
        }

        public void VacationOperations () 
        {
            Console.Write("Ingrese cedula: ");
            string cedulaValue = Console.ReadLine();
            if(findByCedula(cedulaValue)) 
            {
                Console.Write("Ingrese fecha de inicio: ");
                string dateOne = Console.ReadLine();
                DateTime startDateValue = DateTime.Parse(dateOne);
                Console.Write("Ingrese fecha final: ");
                string dateTwo = Console.ReadLine();
                DateTime endDateValue = DateTime.Parse(dateTwo);

                vacation = new Vacation(cedulaValue, startDateValue, endDateValue);
                vacation.daysOfVacation();
                Logger logger = Logger.GetLogger();

                logger.WriteVacationLog(vacation);
                Console.Write("Almacenado en logger");
            } else {
                Console.Write("ERROR: Cedula no registrada");
            }

        }

        public void UnlinkingOperations () 
        {
            Console.Write("Ingrese cedula: ");
            string cedulaValue = Console.ReadLine();
            if(findByCedula(cedulaValue)) 
            {
                Console.Write("Ingrese la causa: ");
                string causeValue = Console.ReadLine();
                unlinking = new Unlinking(cedulaValue, causeValue);

                if(unlinking.Unlinked()) { 
                    deleteEmployee(cedulaValue);
                    Console.WriteLine("Empleado eliminado");
                    Logger logger = Logger.GetLogger();

                    logger.WriteUnlinkingLog(unlinking);
                    Console.Write("Almacenado en logger");
                } else {
                    Console.WriteLine("ERROR");
                }
            } else {
                Console.Write("ERROR: Cedula no registrada");
            }
        }

        public void HireEmployeeOperations () 
        {
            Console.Clear();
            Console.Write("¿Cuál tipo de empleando desea agregar?\n");
            Console.Write("1) Tiempo completo \n");
            Console.Write("2) Medio completo \n");
            Console.Write("Cualquier otro nùmero) Temporero \n");
            Console.Write("Ingrese el número que desee: ");
            int option = int.Parse(Console.ReadLine());
            
            IEmployee employee = Creator.GetEmployee(option);

            Employees.Add(employee.Hire());

            Console.Write("Empleado agregado correctamente!");
        }

        // helpers

        private bool findByCedula (string cedula) {
            foreach (GetEmployeeDto employee in Employees) {
                if (employee.cedula == cedula) {
                    Console.WriteLine(
                        $"Nombre del empleado: {employee.name} \n"+
                        $"Departamento: {employee.department} \n"+
                        $"Puesto: {employee.workStation} \n"+
                        $"Salario: {employee.salary} \n"+
                        $"Fecha y hora de creación: {employee.creationDate}\n"
                    );
                    return true;
                } else {
                    continue;
                }
            }
            return false;
        }

        private void deleteEmployee (string cedula) {
            Employees.RemoveAll(r => r.cedula == cedula);
        } 
    }
}