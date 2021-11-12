using System;

namespace RRHH
{
    public class Creator
    {
        public static IEmployee GetEmployee(int type)
        {
            if (type == 1)
            {
               return new FullTime();
            }
            if (type == 2)
            {
                return new PartTime();
            }
            if (type == 3)
            {
                return new Temporero();
            }
            else
            {
                return new Error();
            }
        }
    }
}