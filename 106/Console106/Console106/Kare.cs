using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console106
{
    class Kare : Sekil
    {
        public Kare(int kenar) : base(kenar)
        {

        }
        public void AlanHesapla()
        {
            int alan = kenar * kenar;
            Console.WriteLine("Karenin alanı: " + alan);
        }
    }
}
