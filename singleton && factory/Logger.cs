using System;
using System.IO;

namespace RRHH
{
    public class Logger
    {
        private string name { get; set; }
        public string department { get; set; }
        public string workStation { get; set; }
        public int salary { get; set; }

        private static Logger logger;
        private Logger (
            string name,
            string department,
            String workStation,
            int salary
        ) 
        {
            this.name = name;
            this.department = department;
            this.workStation = workStation;
            this.salary = salary;
        }

        public static Logger GetLogger(
            string name,
            string department,
            String workStation,
            int salary
        )
        {
           if (logger == null)
           {
               logger = new Logger(name, department, workStation, salary );
                
           }
            
           return logger;
            
        }
        public void WriteLog()
        {
            // el archivo se almacenará en bin/Debug/netcoreapp3.1/
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            using(StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine(
                    ""+
                    $"Nombre del empleado: {this.name} \n"+
                    $"Departamento: {this.department} \n"+
                    $"Puesto: {this.workStation} \n"+
                    $"Salario: {this.salary} \n"+
                    $"Fecha y hora de creación: {DateTime.Now}\n"
                );
            }
        }
    }
}