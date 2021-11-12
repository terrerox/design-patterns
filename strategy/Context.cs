using strategy.Services;
using strategy.Models;
using System.Collections.Generic;

namespace strategy
{
    public class Context
    {
        IStrategy estrategia;
        public Context(IStrategy objeto)
        {
            this.estrategia = objeto;            
        }
        public void Ejecutar(FormData formData)
        {
            estrategia.GuardarLog(formData);
        }

        public List<FormData> Leer ()
        {
            return estrategia.LeerLog();
        }
    }
}