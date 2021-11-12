using System;
using System.IO;

namespace RRHH.Dtos
{
    public class GetEmployeeDto
    {
        public GetEmployeeDto(string cedula, string name, string department, string workStation, int salary, DateTime creationDate)
        {
            this.cedula = cedula;
            this.name = name;
            this.department = department;
            this.workStation = workStation;
            this.salary = salary;
            this.creationDate = creationDate;

        }
        public string cedula { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string workStation { get; set; }
        public int salary { get; set; }
        public DateTime creationDate { get; set; }

    }
}