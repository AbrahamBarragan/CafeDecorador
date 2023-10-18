using CafeDecorador;

class Program
{
    static void Main(string[] args)
    {
        // Café simple
        ICafe cafe = new CafeSimple();
        Console.WriteLine($"Descripción: {cafe.ObtenerDescripcion()}, Costo: {cafe.ObtenerCosto()}");

        // Café con leche
        ICafe cafeConLeche = new CafeConLeche(cafe);
        Console.WriteLine($"Descripción: {cafeConLeche.ObtenerDescripcion()}, Costo: {cafeConLeche.ObtenerCosto()}");

        // Café con leche y caramelo
        ICafe cafeConLecheYCaramelo = new CafeConCaramelo(cafeConLeche);
        Console.WriteLine($"Descripción: {cafeConLecheYCaramelo.ObtenerDescripcion()}, Costo: {cafeConLecheYCaramelo.ObtenerCosto()}");

        Console.ReadKey();
    }
}
