using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01CryptoSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoin = decimal.Parse(Console.ReadLine());
            decimal ethereum = decimal.Parse(Console.ReadLine());
            decimal litecoin = decimal.Parse(Console.ReadLine());
            short tranzakcii = short.Parse(Console.ReadLine());
            decimal[] sums = new decimal[tranzakcii];
            string[] valuta = new string[tranzakcii];
            string[] operation = new string[tranzakcii];
            for (int i = 0; i < tranzakcii; i++)
            {
                sums[i] = decimal.Parse(Console.ReadLine());
                valuta[i] = Console.ReadLine();
                operation[i] = Console.ReadLine();
            }
            decimal Totalsustoqnie = 0;
            
            decimal[] sustoqniq = new decimal[tranzakcii];
            decimal[] komersialni = new decimal[tranzakcii];
            for (int j = 0; j < tranzakcii; j++)
            {
                decimal sustoqnie = 0;
                decimal komers = 0;
                if (valuta[j] == "Bitcoin")
                {
                    sustoqnie = sums[j] * bitcoin;
                }
                else if (valuta[j] == "Ethereum")
                {
                    sustoqnie = sums[j] * ethereum;
                }
                else if (valuta[j] == "Litecoin")
                {
                    sustoqnie = sums[j] * litecoin;
                }
                sustoqniq[j] = sustoqnie;
                komers = sustoqnie * 0.073456764216789345M;
                komersialni[j] = komers;

            }
            for (int i = 0; i < tranzakcii; i++)
            {
                if (operation[i] == "Buy")
                {
                    Totalsustoqnie += sustoqniq[i];

                }
                else
                {
                    Totalsustoqnie -= sustoqniq[i];
                }
            }
           
            Console.WriteLine($"{(Totalsustoqnie - komersialni.Sum()):f16}");
        }
    }
}
