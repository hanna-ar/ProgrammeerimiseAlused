namespace kodutoo_1.TehtedArvudega
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehted arvudega - harjutus 1 - Ruudu pindala

            Console.WriteLine("=== Ruudu pindala ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta ruudu külje pikkus:");
            int kylg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ruudu pindala on " + Math.Pow(kylg, 2));
            Console.WriteLine();

            // Tehted arvudega - harjutus 2 - Ristküliku pindala

            Console.WriteLine("=== Ristküliku pindala ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta ristküliku I külje pikkus:");
            int kylg1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta ristküliku II külje pikkus:");
            int kylg2 = Convert.ToInt32(Console.ReadLine());
            int pindala2 = kylg1 * kylg2;

            Console.WriteLine("Ristküliku pindala on " + pindala2);
            Console.WriteLine();

            // Tehted arvudega - harjutus 3 - Ringi pindala

            Console.WriteLine("=== Ringi pindala ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta ringi raadius:");
            int r = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ringi pindala on: " + Math.PI * Math.Pow(r, 2));

        }
    }
}