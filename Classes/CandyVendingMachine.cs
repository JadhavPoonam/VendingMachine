using System;
using Net_Core.Interfaces;

namespace Net_Core.Classes
{
    public class CandyVendingMachine
    {
        CandyVendingMachineState noCoinState;
        CandyVendingMachineState noCandyState;
        CandyVendingMachineState dispensedState;
        CandyVendingMachineState containsCoinState;
        CandyVendingMachineState state;
        int count;

        public override string ToString()
        {
            return "Current state of machine: " + state + ". Candies available: " + count;
        }

        public CandyVendingMachine(int stock)
        {
            count = stock;
            noCoinState = new NoCoinState(this);
            noCandyState = new NoCandyState(this);
            dispensedState = new DispensedState(this);
            containsCoinState = new ContainsCoinState(this);
            state = noCoinState;

        }

        public void refillCandy(int count)
        {
            this.count += count;
            this.state = noCoinState;
        }

        public void ejectCandy(){
            if (count != 0)
                count--;
        }

        public void insertCoin(){
            Console.WriteLine("You inserted a coin");
            state.insertCoin();
        }

        public void pressButton(){
            Console.WriteLine("You pressed a button");

            state.pressButton();
            state.dispense();
        }

        public CandyVendingMachineState getNoCandyState(){
            return noCandyState;
        }

        public void setNoCandyState(CandyVendingMachineState noCandyState){
            this.noCandyState = noCandyState;
        }

        public CandyVendingMachineState getNoCoinState()
        {
            return noCoinState;
        }

        public void setNoCoinState(CandyVendingMachineState noCoinState)
        {
            this.noCoinState = noCoinState;
        }

        public int getCount()
        {
            return count;
        }

        public void setCount(int count)
        {
            this.count = count;
        }

        public CandyVendingMachineState getState()
        {
            return state;
        }

        public void setState(CandyVendingMachineState state)
        {
            this.state = state;
        }

        public CandyVendingMachineState getContainsCoinState()
        {
            return containsCoinState;
        }

        public void setConatinsCoinState(CandyVendingMachineState containsCoinState)
        {
            this.containsCoinState = containsCoinState;
        }

        public CandyVendingMachineState getDispensedState()
        {
            return dispensedState;
        }

        public void setDispensedState(CandyVendingMachineState dispensedState)
        {
            this.dispensedState = dispensedState;
        }

    }
}
