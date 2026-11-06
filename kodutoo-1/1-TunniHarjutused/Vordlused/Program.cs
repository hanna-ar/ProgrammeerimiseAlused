namespace kodutoo_1.TehtedArvudega
{
    class Program
    {
        static void Main(string[] args)
        {
            // Võrdlused - harjutus 1 - Kas arv on positiivne, negatiivne või null

            Console.WriteLine("=== Kas arv on pos, neg või 0? ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta suvaline arv: ");
            int arv = Convert.ToInt32(Console.ReadLine());

            if (arv>0)
            {
                Console.WriteLine("Arv on positiivne.");
            }
            else if (arv<0)
            {
                Console.WriteLine("Arv on negatiivne.");
            }
            else
            {
                Console.WriteLine("Arv on null.");
            }
            Console.WriteLine();

            // Võrdlused - harjutus 2 - kasutaja login ja admin õiguste kontroll
            
            bool loggedin = true;
            bool isAdmin = true;

            if(loggedin && isAdmin)
            {
                Console.WriteLine("Kasutajal on admin õigused ja on sisse logitud.");
            }
            else
            {
                Console.WriteLine("Kasutajal ei ole admin õigusi või ei ole sisse logitud.");
            }

            // Võrdlused - harjutus 3

            Console.WriteLine("=== Hinnete võrdlus ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta esimese õpilase 3 hinnet, eraldades need tühikuga:");

            string[] hinded1 = Console.ReadLine()!.Split(' ');

            int E_hinne1 = Convert.ToInt32(hinded1[0]);
            int E_hinne2 = Convert.ToInt32(hinded1[1]);
            int E_hinne3 = Convert.ToInt32(hinded1[2]);

            Console.WriteLine("Sisesta teise õpilase 3 hinnet, eraldades need tühikuga:");
            Console.WriteLine();

            string[] hinded2 = Console.ReadLine()!.Split(' ');

            int T_hinne1 = Convert.ToInt32(hinded2[0]);
            int T_hinne2 = Convert.ToInt32(hinded2[1]);
            int T_hinne3 = Convert.ToInt32(hinded2[2]);

            // Keskmiste hinnete arvutamine ja võrdlus

            double keskmine1 = (E_hinne1 + E_hinne2 + E_hinne3) / 3.0;
            double keskmine2 = (T_hinne1 + T_hinne2 + T_hinne3) / 3.0;
            
            if (keskmine1 > keskmine2)
            {
                Console.WriteLine("Esimese õpilase keskmine hinne on kõrgem.");
            }
            else if (keskmine1 < keskmine2)
            {
                Console.WriteLine("Teise õpilase keskmine hinne on kõrgem.");
            }
            else
            {
                Console.WriteLine("Õpilaste keskmised hinded on võrdsed.");
            }
            Console.WriteLine();

            // Kas mõlemal on miinimumhinne 3?

            int minHinne1 = Math.Min(E_hinne1, Math.Min(E_hinne2, E_hinne3));
            int minHinne2 = Math.Min(T_hinne1, Math.Min(T_hinne2, T_hinne3));

            if (minHinne1 ==3 && minHinne2 == 3)
            {
                Console.WriteLine("Mõlema õpilase miinimumhinne on 3.");
            }
            else
            {
                Console.WriteLine("Mõlema õpilase miinimumhinne ei ole 3.");
            }

        }
    }
}