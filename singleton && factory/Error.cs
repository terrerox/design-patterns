using System;

namespace RRHH
{
    public class Error : IEmployee
    {
        public void Hire () 
        {
            Console.WriteLine($"That type doesn´t exist");
        }
    }
}