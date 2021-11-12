namespace adapter.Services.Facturacion.Vestir
{
    public class FacturacionArticuloVestir
    {
        public static int ITBIS (int precio) {
            return (18 * precio) / 100;
        }
    }
}