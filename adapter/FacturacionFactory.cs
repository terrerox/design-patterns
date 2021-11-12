using System;
using adapter.Services.Facturacion;
using adapter.Services.Facturacion.Electronico;
using adapter.Services.Facturacion.Vestir;
namespace adapter
{
    public class FacturacionFactory
    {
        public static IFacturacionService GetFacturacion(string type)
        {
            if (type == "Canasta")
            {
               return new FacturacionCanastaBasica();
            }
            if (type == "Electronico")
            {
                return new FacturacionArticuloElectronicoAdapter();
            }
            else
            {
                return new FacturacionArticuloVestirAdapter();
            }
        }
    }
}