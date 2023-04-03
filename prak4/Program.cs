using prak4;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil = new Mobil();

            mobil.warna = "Hitam";
            mobil.merk = "Daihaha";
            mobil.models = "Cylock";
            mobil.year = "2018";
            mobil.gas = "60 km/jam";
            mobil.klakson = "TINTINNNN";
            mobil.pintu = "5\n";
            mobil.mobil();

            Console.ReadLine();
        }
    }
}
