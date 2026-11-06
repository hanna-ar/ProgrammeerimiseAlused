namespace kodutoo_1.TehtedArvudega
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tingimuslaused - harjutus 1

            Console.WriteLine("=== Täisealine või alaealine? ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta oma vanus: ");
            int vanus = Convert.ToInt32(Console.ReadLine());

            if (130 > vanus && vanus >= 18)
            {
                Console.WriteLine("Oled täitsa täisealine.");
            }
            else if (vanus < 18 && vanus >= 1)
            {
                Console.WriteLine("Oled veel alaealine.");
            }
            else
            {
                Console.WriteLine("Mm.. kindel, et see sinu vanus on?");
            }
            Console.WriteLine();

            // Tingimuslaused - harjutus 2

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

            // Tingimuslaused - harjutus 3

            Console.WriteLine("=== Hindame hinnet ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta hinne skaalal 1-5: ");
            int hinne = Convert.ToInt32(Console.ReadLine());

            switch (hinne)
            {
                case 1:
                Console.WriteLine("Hinne 1 - Tagantpoolt võitja :`)");
                break;

                case 2:
                Console.WriteLine("Hinne 2 - Puudulik");
                break;

                case 3:
                Console.WriteLine("Hinne 3 - Aktsepteeritav");
                break;

                case 4:
                Console.WriteLine("Hinne 4 - Hea");
                break;

                case 5:
                Console.WriteLine("Hinne 5 - Väga hea");
                break;

            }
            Console.WriteLine();

            // Tingimuslaused - harjutus 4

            Console.WriteLine("=== Tööpäev või nädalavahetus? ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta nädalapäeva number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                Console.WriteLine( day + " - see on tööpäev.");
                break;
                case 6:
                case 7:
                Console.WriteLine( day + " - see on nädalavahetus.");
                break;
            }
            Console.WriteLine();

            // Tingimuslaused - harjutus 5

            Console.WriteLine("=== Kalkulaator ===");
            Console.WriteLine();

            Console.WriteLine("Sisesta esimene täisarv: ");
            int arv1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta teine täisarv: ");
            int arv2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe (+, -, *, /): ");
            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "+":
                Console.WriteLine(arv1 + " + " + arv2 + " = " + (arv1 + arv2));
                break;

                case "-":
                Console.WriteLine(arv1 + " - " + arv2 + " = " + (arv1 - arv2));
                break;

                case "*":
                Console.WriteLine(arv1 + "*" + arv2 + " = " + (arv1 * arv2));
                break;

                case "/":
                if (arv2 == 0)
                    {
                        Console.WriteLine("Nulliga ei saa jagada :(");
                    }
                else
                    {
                        Console.WriteLine(arv1 + " / " + arv2 + " = " + (arv1/arv2));
                    }
                break;

            }

        }
    }
}
