namespace kodutoo_1.TehtedArvudega
{
    class Program
    {
        static void Main(string[] args)
        {
            // Massiivid ja loendid - harjutus 1

            Console.WriteLine("=== Filmide massiiv ===");
            Console.WriteLine();

            string [] filmid = {"The Matrix", "Devil Wears Prada", "MadMax: Fury Road", "Death Proof", "Pride and Prejudice"};
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+1 + "." + " " + filmid[i]);
            }
            
            // Massiivid ja loendid - harjutus 2

            Console.WriteLine("=== Sõprade nimekiri ===");
            Console.WriteLine();

            List<string> sobrad = new List<string>();
            sobrad.Add("Sigmund");
            sobrad.Add("Herbert");
            sobrad.Add("Khätleen");

            sobrad.RemoveAt(0);

            Console.WriteLine("Sõpru on nimekirjas " + sobrad.Count + ": " + sobrad[0] + " ja " + sobrad[1]);
            Console.WriteLine();

            // Massiivid ja loendid - harjutus 3

            Console.WriteLine("=== Viie klassikaaslaste nimekiri ===");
            Console.WriteLine();

            string [] kk = {"Stiiv", "Äntoni", "Aita", "Trixibell", "Silli"};
            Console.WriteLine("Esimene: " + kk[0] + ", Teine: " + kk[2] + ", Kolmas: " + kk[4]);
            kk[1] = "Sigmund";

            Console.WriteLine();
            Console.WriteLine("Uus klassiaaslaste nimekiri:");

            for (int i = 0; i < kk.Length; i++)
            {
                Console.WriteLine(kk[i]);
            }

            
        }
    }
}
