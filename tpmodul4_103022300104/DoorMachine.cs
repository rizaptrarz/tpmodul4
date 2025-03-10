using System;

namespace tpmodul4_103022300104
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State state;

        public DoorMachine()
        {
            state = State.Terkunci;
        }

        public void KunciPintu()
        {
            if (state == State.Terbuka)
            {
                state = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        public void BukaPintu()
        {
            if (state == State.Terkunci)
            {
                state = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah tidak terkunci");
            }
        }

        public void CekStatus()
        {
            Console.WriteLine("Status pintu: " + state);
        }
    }
}
