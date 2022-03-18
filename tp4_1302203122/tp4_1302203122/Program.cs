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
            Console.Write("Massukan NIM : ");
            string nim;
            nim = Console.ReadLine();
            DataGeneric<String> data = new DataGeneric<string>(nim);
            data.Prindata();

        }

        class DataGeneric<T>
        {
            private T data;
            public DataGeneric(T data)
            {
                this.data = data;
            }

            public void Prindata()
            {
                Console.WriteLine("Data yang tersimpan adalah : " + data);
            }
        }

    }
}
