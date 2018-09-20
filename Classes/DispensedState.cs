using System;
using Net_Core.Interfaces;

namespace Net_Core.Classes
{
    public class DispensedState: CandyVendingMachineState
    {
        CandyVendingMachine machine;
        public DispensedState(CandyVendingMachine machine)
        {
            this.machine = machine;
        }

        public override string ToString()
        {
            return "Dispensed state!";
        }

        public void dispense()
        {
            if(machine.getCount() > 0){
                machine.setState(machine.getDispensedState());
                machine.setCount(machine.getCount()-1);
            }
            else{
                Console.WriteLine("No candies available.");
                machine.setState(machine.getNoCandyState());
            }
        }

        public void insertCoin()
        {
            Console.WriteLine("Error: System is currently dispensing");
        }

        public void pressButton()
        {
            Console.WriteLine("Error: System is currently dispensing");
        }
    }
}
