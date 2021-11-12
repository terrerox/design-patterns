using System;

namespace RRHH.Entities
{
    public class Unlinking
    {
        public string cedula { get; set; }  
        public string cause { get; set; }  

        public Unlinking(string cedula, string cause) {
            this.cedula = cedula;
            this.cause = cause;
        }

        public bool Unlinked () {
            Console.WriteLine("¿Estas seguro de desvincular empleado? [1]si [2]no");
            string option = Console.ReadLine();
            if (option == "1")
            {
                return true;
            } else {
                return false;
            }
        }
    }
}