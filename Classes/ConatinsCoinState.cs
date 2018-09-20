using System;
using Net_Core.Interfaces;

namespace Net_Core.Classes
{
    public class ContainsCoinState: CandyVendingMachineState
    {
        CandyVendingMachine machine;
        public ContainsCoinState(CandyVendingMachine machine)
        {
            this.machine = machine;
        }

        public override string ToString()
        {
            return "Conatins Coin state!";
        }

        public void dispense()
        {
            Console.WriteLine("Press button to dispense");
        }

        public void insertCoin()
        {
            Console.WriteLine("Coin already inserted");
        }

        public void pressButton()
        {
            machine.setState(machine.getDispensedState());
        }
    }
}
