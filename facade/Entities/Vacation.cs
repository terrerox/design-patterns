using System;
using RRHH.Entities;

namespace RRHH.Entities
{
    public class Vacation
    {
        public string cedula { get; set; }  
        public DateTime startDate { get; set; }  
        public DateTime endDate { get; set; }  

        public Vacation(string cedula, DateTime startDate, DateTime endDate) {
            this.cedula = cedula;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public void daysOfVacation () {
            TimeSpan diffDates = this.endDate.Subtract(this.startDate); 
            Console.WriteLine("Días de vacaciones: " + diffDates.Days);
        }
    }
}