using System;
using Net_Core.Interfaces;

namespace Net_Core.Classes
{
    public class NoCandyState: CandyVendingMachineState
    {
        CandyVendingMachine machine;
        public NoCandyState(CandyVendingMachine machine)
        {
            this.machine = machine;
        }

        public override string ToString()
        {
            return "No Candy state!";
        }

        public void dispense()
        {
            Console.WriteLine("No candies available");
        }

        public void insertCoin()
        {
            Console.WriteLine("No candies available");
        }

        public void pressButton()
        {
            Console.WriteLine("No candies available");
        }
    }
}
