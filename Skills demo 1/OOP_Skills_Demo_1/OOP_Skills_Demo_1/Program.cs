//James Fleming
//CS-021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Skills_Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an instance of a petrol pump called pump1 with the relevant data
            PetrolPump pump1 = new PetrolPump(0.75, 20000.00, 2.0, "Unleaded 98");
            //requests the user to input how many litres of fuel they want
            Console.WriteLine("How many Litres of " + pump1.getFuelType() + " would you like?");
            //inputs the users input into the fillCarFromPump method
            pump1.fillCarFromPump(Convert.ToInt32(Console.ReadLine()));
            //prompts the user to press any key to continue
            Console.WriteLine("Press any key to continue");
            //detects if user presses a key
            Console.ReadKey();
            //adds a 1000 litres of fuel to the Pumps tank
            pump1.addFuel(1000.0);
            //clears the screen
            Console.Clear();
            //displays to the user how much fuel is in the Pumps Tank after the 1000 litres of fuel is added
            Console.WriteLine("There is "+pump1.getFuelLevel()+" Litres of fuel in the Pumps Tank");

            Console.ReadKey();

        }
    }
}
