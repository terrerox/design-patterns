namespace RRHH
{
    public class PartTimeEntitie
    {
        public PartTimeEntitie (
            string name, 
            string department, 
            string workStation, 
            int salary, 
            int workHours,
            int costPerHour,
            string accountNumber
        ) 
        {
            this.name = name;
            this.department = department;
            this.workStation = workStation;
            this.salary = salary;
            this.workHours = workHours;
            this.costPerHour = costPerHour;
            this.accountNumber = accountNumber;
        }
        public string name { get; set; }
        public string department { get; set; }
        public string workStation { get; set; }
        public int salary { get; set; }
        public int workHours { get; set; }
        public int costPerHour { get; set; }
        public string accountNumber { get; set; }  
    }
}