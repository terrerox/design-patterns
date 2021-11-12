namespace RRHH
{
    public class TemporeroEntitie
    {
        public TemporeroEntitie (
            string name, 
            string department, 
            string workStation, 
            int salary, 
            int workHours,
            int costPerHour
        ) 
        {
            this.name = name;
            this.department = department;
            this.workStation = workStation;
            this.salary = salary;
            this.workHours = workHours;
            this.costPerHour = costPerHour;
        }
        public string name { get; set; }
        public string department { get; set; }
        public string workStation { get; set; }
        public int salary { get; set; }
        public int workHours { get; set; }
        public int costPerHour { get; set; }
    }
}