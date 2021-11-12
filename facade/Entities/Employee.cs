namespace RRHH.Entities
{
    public abstract class Employee
    {
        public string cedula { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string workStation { get; set; }
        public int salary { get; set; }
        public int workHours { get; set; }
        public int costPerHour { get; set; }
    }
}