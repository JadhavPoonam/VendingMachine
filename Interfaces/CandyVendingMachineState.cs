using System;
using Net_Core.Classes;

namespace Net_Core.Interfaces
{
    public interface CandyVendingMachineState
    {
        void insertCoin();
        void pressButton();
        void dispense();
    }
}
