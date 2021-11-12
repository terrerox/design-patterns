using System.Collections.Generic;
using strategy.Models;

namespace strategy.Services
{
    public interface IStrategy
    {
        void GuardarLog(FormData formData);
        List<FormData> LeerLog();
    }
}