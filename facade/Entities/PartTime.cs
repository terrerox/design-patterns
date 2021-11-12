namespace RRHH.Entities
{
    public class PartTime : Employee
    {
        public string accountNumber { get; set; }  
        public PartTime (
            string cedula,
            string name, 
            string department, 
            string workStation, 
            int salary, 
            int workHours,
            int costPerHour,
            string accountNumber
        ) 
        {
            this.cedula = cedula;
            this.name = name;
            this.department = department;
            this.workStation = workStation;
            this.salary = salary;
            this.workHours = workHours;
            this.costPerHour = costPerHour;
            this.accountNumber = accountNumber;
        } 
    }
}