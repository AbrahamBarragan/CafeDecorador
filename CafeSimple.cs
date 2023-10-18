namespace CafeDecorador
{
    public class CafeSimple : ICafe
    {
        public string ObtenerDescripcion()
        {
            return "Café Simple";
        }

        public double ObtenerCosto()
        {
            return 1.0;
        }
    }
}
