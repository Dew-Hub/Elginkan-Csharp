using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console106
{
    class Dikdortgen : Sekil
    {
        public Dikdortgen(int kısakenar, int uzunkenar) : base(kısakenar, uzunkenar)
        {

        }

        public void AlanHesapla()
        {
            int alan = kisakenar * uzunkenar;
            Console.WriteLine("Dikdörtgenin alanı: " + alan);
        }
    }
}
