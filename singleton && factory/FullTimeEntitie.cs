namespace RRHH
{
    public class FullTimeEntitie
    {
        public string name { get; set; }
        public string department { get; set; }
        public string workStation { get; set; }
        public int salary { get; set; }
        public int dailyWorkHours { get; set; }
        public int costPerHour { get; set; }
        public string accountNumber { get; set; }  
        public FullTimeEntitie (
            string name, 
            string department, 
            string workStation, 
            int salary, 
            int dailyWorkHours,
            int costPerHour,
            string accountNumber
        ) 
        {
            this.name = name;
            this.department = department;
            this.workStation = workStation;
            this.salary = salary;
            this.dailyWorkHours = dailyWorkHours;
            this.costPerHour = costPerHour;
            this.accountNumber = accountNumber;
        }
    }
}