using adapter.Models;
using System.Collections.Generic;

namespace adapter.Services.Facturacion
{
    public interface IFacturacionService
    {
        void Cobrar(List<DetallesFacturacion> detalles);
    }
}