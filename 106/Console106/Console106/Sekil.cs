using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console106
{
    class Sekil
    {
        public int kenar { get; set; }
        public int kisakenar { get; set; }
        public int uzunkenar { get; set; }

        public Sekil(int kenar)
        {
            this.kenar = kenar;
        }
        public Sekil(int kısakenar, int uzunkenar)
        {
            this.kisakenar = kısakenar;
            this.uzunkenar = uzunkenar;
        }


    }
}
