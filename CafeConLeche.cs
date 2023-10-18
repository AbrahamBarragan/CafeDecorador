namespace CafeDecorador
{
    public class CafeConLeche : ICafe
    {
        private ICafe _cafe;

        public CafeConLeche(ICafe cafe)
        {
            _cafe = cafe;
        }

        public string ObtenerDescripcion()
        {
            return _cafe.ObtenerDescripcion() + ", Leche";
        }

        public double ObtenerCosto()
        {
            return _cafe.ObtenerCosto() + 0.5;
        }
    }
}
