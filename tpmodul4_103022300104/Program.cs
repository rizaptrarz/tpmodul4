using System;

namespace tpmodul4_103022300104
{
    class Program
    {
        static void Main()
        {
            KodePos kodePos = new KodePos();

            Console.Write("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();

            string kode = kodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode pos untuk {kelurahan} adalah {kode}");
        }
    }
}
