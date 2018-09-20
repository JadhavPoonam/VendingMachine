using System;
using Net_Core.Classes;

namespace Net_Core
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("-----Test 1: Testing machine by inserting coin and pressing button-----");
                CandyVendingMachine machine = new CandyVendingMachine(3);
                Console.WriteLine(machine);
                machine.insertCoin();
                Console.WriteLine(machine);
                machine.pressButton();
                Console.WriteLine(machine);

                Console.WriteLine("-----Test 2: Testing machine by pressing button without inserting coin-----");
                CandyVendingMachine machine2 = new CandyVendingMachine(3);
                Console.WriteLine(machine2);
                machine2.pressButton();
                Console.WriteLine(machine2);

                Console.WriteLine("-----Test 3: Testing machine running out of candies-----");
                CandyVendingMachine machine3 = new CandyVendingMachine(3);
                Console.WriteLine(machine3);
                machine3.insertCoin();
                machine3.pressButton();
                machine3.insertCoin();
                machine3.pressButton();
                machine3.insertCoin();
                machine3.pressButton();
                machine3.insertCoin();
                machine3.pressButton();
                Console.WriteLine(machine3);
        }
    }
}
