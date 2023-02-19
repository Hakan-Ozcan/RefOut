
namespace RefOut
{
    class Program
    {
        static void Main()
        {
            //int x= 5; ref kullansaydım başlangıç değeri vermeliydim. ve parametreleri out değilde ref olarak yazmalıydım.
            int x;
            Console.WriteLine(Bol(19, 5, out x));
            Console.WriteLine(x);
            Console.ReadLine();
        }
        static int Bol(int bolunen, int bolen, out int kalan)
        {
            int bolum = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (bolunen > bolen)
                {
                    bolunen -= bolen;
                    bolum++;
                }
                else
                {
                    break;
                }

            }
            kalan = bolunen;
            return bolum;

        }


    }

}