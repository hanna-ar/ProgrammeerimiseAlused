namespace kodutoo_1.harjutus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random suvakasnr = new Random();
            int arv = suvakasnr.Next(1, 101);

            int pakkumine;

            while (true)
            {
                   Console.WriteLine("Paku arv 1-100: ");
                 pakkumine = Convert.ToInt32(Console.ReadLine());
            

                 if (pakkumine > arv)
                 {
                    Console.WriteLine("Proovi väiksemat arvu ;)");
                 }
                 else if (pakkumine < arv)
                 {
                     Console.WriteLine("Proovi suuremat arvu ;)");
                 }
                  else
                 {
                     Console.WriteLine("Omg sa oled selgeltnägija!");
                     break;
                 }
            }
        }
    }
}