using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console106;

class Program
{
    static void Main(string[] args)
    {
        Kare kr = new Kare(5);
        kr.AlanHesapla();
        Dikdortgen dk = new Dikdortgen(5, 10);
        dk.AlanHesapla();
    }
}