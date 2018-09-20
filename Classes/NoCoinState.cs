using System;
using Net_Core.Interfaces;

namespace Net_Core.Classes
{
    public class NoCoinState: CandyVendingMachineState
    {
        CandyVendingMachine machine;
        public NoCoinState(CandyVendingMachine machine)
        {
            this.machine = machine;
        }

        public override string ToString()
        {
            return "No Coin state!";
        }

        public void dispense()
        {
            Console.WriteLine("No coin inserted");
        }

        public void insertCoin()
        {
            machine.setState(machine.getContainsCoinState());
        }

        public void pressButton()
        {
            Console.WriteLine("No coin inserted");
        }
    }
}
