using System;

namespace RRHH.Entities
{
    public class Permission
    {
        public string cedula { get; set; }  
        public DateTime date { get; set; } 

        public Permission(string cedula, DateTime date) {
            this.cedula = cedula;
            this.date = date;
        }
    }
}