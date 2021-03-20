using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
           string secim;
            double bakiye = 0;
            do
            {
                Console.Write("1-Bakiye götüntüleme \n 2-Para  yatırma\n 3-Para çekme\n 4-çıkış\n seçiminiz");
                secim = Console.ReadLine();
                Console.WriteLine("---------------");


                switch (secim)
                {
                 case "1":
                        Console.WriteLine("Bakiyeniz {0} Tl", bakiye);
                    break;

                 case "2":
                        Console.Write("Ne kadar yatırmak istiyorsunuz:");
                        double miktar=double.Parse(Console.ReadLine());
                        bakiye = bakiye + miktar;

                    break;

                 case "3":
                        Console.Write("Ne kadar para istiyorsunuz?");
                        double eksilen = double.Parse(Console.ReadLine());
                        if (eksilen>bakiye)
                        {
                            Console.WriteLine("Bakiye yetersiz");
                        }
                        else
                        {
                            bakiye = bakiye - eksilen;
                        }
                    break;

                  
                }
            } while (secim !="4");
          

        }
    }
}
