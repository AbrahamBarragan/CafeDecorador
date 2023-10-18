namespace CafeDecorador
{
    public class CafeConCaramelo : ICafe
    {
        private ICafe _cafe;

        public CafeConCaramelo(ICafe cafe)
        {
            _cafe = cafe;
        }

        public string ObtenerDescripcion()
        {
            return _cafe.ObtenerDescripcion() + ", Caramelo";
        }

        public double ObtenerCosto()
        {
            return _cafe.ObtenerCosto() + 0.7;
        }
    }
}
