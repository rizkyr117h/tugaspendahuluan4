using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_1302203122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namaKu;
            Console.Write("Massukan Nama : ");
            namaKu = Console.ReadLine();
            HaloGeneric.sapauser<string>(namaKu);
        }
    }
    class HaloGeneric
    {
        public static void sapauser<t>(t nama)
        {
            Console.WriteLine("halo user" + nama);
        }
    }

}
