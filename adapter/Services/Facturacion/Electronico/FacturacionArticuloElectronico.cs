namespace adapter.Services.Facturacion.Electronico
{
    public class FacturacionArticuloElectronico
    {
        public static int ITBISAndISC (int precio) {
            return (28 * precio) / 100;
        }
    }
}