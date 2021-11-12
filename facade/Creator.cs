using System;
using RRHH.Services;

namespace RRHH
{
    public class Creator
    {
        public static IEmployee GetEmployee(int type)
        {
            if (type == 1)
            {
               return new FullTimeService();
            }
            if (type == 2)
            {
                return new PartTimeService();
            }
            else
            {
                return new TemporeroService();
            }
        }
    }
}