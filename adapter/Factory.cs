using adapter.Services.Articulos;

namespace adapter
{
    public class Factory
    {
        public static IArticulosService GetArticulo(int type)
        {
            if (type == 1)
            {
               return new ArticuloCanastaService();
            }
            if (type == 2)
            {
                return new ArticuloElectronicoService();
            }
            else
            {
                return new ArticuloDeVestirService();
            }
        }
    }
}