using System;

namespace tpmodul4_103022300104
{
    class ProgramDoor
    {
        static void Main()
        {
            DoorMachine door = new DoorMachine();

            while (true)
            {
                Console.Write("Ketik 'buka' untuk membuka atau 'kunci' untuk mengunci (ketik 'exit' untuk keluar): ");
                string input = Console.ReadLine().ToLower();

                if (input == "buka")
                {
                    door.BukaPintu();
                }
                else if (input == "kunci")
                {
                    door.KunciPintu();
                }
                else if (input == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenali.");
                }
            }
        }
    }
}