using System;
using System.Collections.Generic;
using System.IO;
using RRHH.Dtos;

using Newtonsoft.Json;

namespace RRHH.Entities
{
    public class Logger
    {
        private static Logger logger;
        private Logger () {}

        public static Logger GetLogger()
        {
           if (logger == null)
           {
               logger = new Logger();
                
           }
            
           return logger;
            
        }
        public void WriteLog(GetEmployeeDto employeeDto)
        {
            // el archivo se almacenará en bin/Debug/netcoreapp3.1/
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            using(StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine(
                    ""+
                    $"Nombre del empleado: {employeeDto.name} \n"+
                    $"Departamento: {employeeDto.department} \n"+
                    $"Puesto: {employeeDto.workStation} \n"+
                    $"Salario: {employeeDto.salary} \n"+
                    $"Fecha y hora de creación: {employeeDto.creationDate}\n"
                );
            }
        }

        
        public void WriteVacationLog(Vacation vacation)
        {
            // el archivo se almacenará en bin/Debug/netcoreapp3.1/
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            using(StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine(
                    ""+
                    "******Vacaciones****** \n"+
                    $"Cedula: {vacation.cedula} \n"+
                    $"Fecha ida: {vacation.startDate} \n"+
                    $"Fecha final: {vacation.endDate}\n"
                );
            }
        }

        public void WriteUnlinkingLog(Unlinking unlinking)
        {
            // el archivo se almacenará en bin/Debug/netcoreapp3.1/
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            using(StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine(
                    ""+
                    "-------Desvinculación------- \n"+
                    $"Cedula: {unlinking.cedula} \n"+
                    $"Causa: {unlinking.cause} \n"
                );
            }
        }

        public void WritePermissionLog(Permission permission)
        {
            // el archivo se almacenará en bin/Debug/netcoreapp3.1/
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            using(StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine(
                    ""+
                    "++++++++Permiso++++++++ \n"+
                    $"Cedula: {permission.cedula} \n"+
                    $"Frcha de permiso: {permission.date} \n"
                );
            }
        }
    }
}