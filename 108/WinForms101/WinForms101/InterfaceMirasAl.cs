using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms101
{
    internal class InterfaceMirasAl : IToplama
    {
        public int topla(int a, int b) { return (a + b); }
    }
}
