namespace kodutoo_1.TehtedArvudega
{
    class Program
    {
        static void Main(string[] args)
        {
            // While tsükkel - harjutus 1

            Console.WriteLine("=== Arvud 1st 10ni ===");
            Console.WriteLine();

            int arv = 1;
            while (arv <= 10)
            {
                Console.WriteLine(arv);
                arv++;
            }
            Console.WriteLine();


            // For tsükkel - harjutus 2

            Console.WriteLine("=== Arvud 10st 1ni ===");
            Console.WriteLine();

            for (int i = 10 ; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // For tsükkel - harjutus 3

            Console.WriteLine("=== Paarisarvude summa 1-50 ===");
            Console.WriteLine();

            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Paarisarvude summa 1-50ni on: " + sum);
            Console.WriteLine();

            // Foreach tsükkel - harjutus 4

            Console.WriteLine("=== Laulude nimekiri ===");
            Console.WriteLine();

            string[] laulud = {"Hung up", "Vogue", "Fantasy", "Rumors", "Clumsy", "Torn"};
            foreach (string laul in laulud)
            {
                Console.WriteLine(laul);
            }
            Console.WriteLine();

            // foreach tsükkel - harjutus 5

            Console.WriteLine("=== Massiivi summa ja suurim nr ===");
            Console.WriteLine();

            List<int> numbrid = new List<int> { 19, 20, 39, 67, 2, 7, 77, 11, 26};
            int summa = 0;
            int suurim = 0;

            foreach (int nmr in numbrid)
            {
                summa += nmr;

                if (nmr > suurim)
                {
                    suurim = nmr;
                }
            }
            Console.WriteLine("Massiivi arvude summa on: " + summa);
            Console.WriteLine("Suurim number massiivis on: " + suurim);
            Console.WriteLine();

            // While tsükkel - harjutus 6

            Console.WriteLine("=== Arvude summa ===");
            Console.WriteLine();

            int arv1 = 1;
            int summ = 0;

            while (arv1 != 0)
            {
                Console.WriteLine("Sisesta täisarve (lõpetamiseks sisesta 0): ");
                arv1 = Convert.ToInt32(Console.ReadLine());

                summ += arv1;
            }

            Console.WriteLine("Arvude summa on: " + summ);
            Console.WriteLine();

            // For tsükkel - harjutus 7

            Console.WriteLine("=== Korrutustabel ===");
            Console.WriteLine();

            int nr = 7;

            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(nr + " * " + i + " = " + nr*i);
            }
            Console.WriteLine();

            // Break-i kasutamine - harjutus 8

            Console.WriteLine("=== Väikseim arv 1-100, mis jagub 3 ja 5-ga ===");
            Console.WriteLine();


            for (int no = 1; no <=100; no++)
            {
                if (no % 3 == 0 && no % 5 == 0)
                {
                    Console.WriteLine("Väikseim arv, mis jagub 3 ja 5-ga on: " + no);
                    break;
                }

            }
            Console.WriteLine();

            // Continue kasutamine - harjutus 9

            Console.WriteLine("=== Arvud 1-20, mis ei jagu 3-ga ===");
            Console.WriteLine();


            for (int a = 1; a <=30; a++)
            {
                if (a % 3 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            Console.WriteLine();

            // For tsükkel - harjutus 10

            int parool = 1234;

            for (int katsed = 1; katsed <= 3; katsed ++)
            {
                Console.WriteLine("Sisesta parool: ");
                int katse =  Convert.ToInt32(Console.ReadLine());

                if (katse == parool)
                {
                    Console.WriteLine("Õige parool!");
                    break;
                }
                
            }


        }
    }
}
