namespace sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastegele = new Random();
            hafiza = rastegele.Next(1, 100);
            while (tahmin != hafiza)
            {
                sayac++;
                Console.Write("Lütfen bir sayı giriniz: ");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if (tahmin > hafiza)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Daha küçük bir sayı giriniz.\n");                    
                }
                else if (tahmin < hafiza)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Daha büyük bir sayı giriniz.\n");                   
                }
            }           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Tebriklerr...");
            Console.WriteLine("{0}.denemede bildiniz :)", sayac);
            Console.ReadLine();
        }
    }
}