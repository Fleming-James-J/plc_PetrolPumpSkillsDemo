//James Fleming
//CS-021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Skills_Demo_1
{
    /// <summary>
    /// Class for a Petrol Pump
    /// </summary>
    class PetrolPump
    {
        //member variables
        private double petrolPrice;
        private double fuelLevel;
        private double minOrder;
        private string fuelType;
        //constructors
        /// <summary>
        /// default constructor for when the oject is created and th ecretor doesn't input any values
        /// </summary>
        public PetrolPump()
        {
            this.petrolPrice = 0.0;
            this.fuelLevel = 0.0;
            this.minOrder = 0.0;
            this.fuelType = "";
        }
        /// <summary>
        /// overloaded constructor to allow user input the values when the object is created
        /// </summary>
        /// <param name="price">Petrol price : double</param>
        /// <param name="level">Fuel in tank : double</param>
        /// <param name="order">Minimum order customer can make  : double</param>
        /// <param name="type">what fuel it is : string</param>
        public PetrolPump(double price, double level, double order, string type)
        {
            petrolPrice = price;
            fuelLevel = level;
            minOrder = order;
            fuelType = type;
        }
        //gets and sets
        //gets
        /// <summary>
        /// Gets the petrol Price
        /// </summary>
        /// <returns>Price of Petrol : double</returns>
        public double getPetrolPrice()
        {
            return this.petrolPrice;
        }
        /// <summary>
        /// Gets how much is left in the tank
        /// </summary>
        /// <returns>Current tank Capacity : double</returns>
        public double getFuelLevel()
        {
            return this.fuelLevel;
        }
        /// <summary>
        /// finds out what the minimum order is
        /// </summary>
        /// <returns>What the minimum order  : double</returns>
        public double getMinOrder()
        {
            return this.minOrder;
        }
        /// <summary>
        /// finds out what fuel type it is
        /// </summary>
        /// <returns>what type of fuel it is : string</returns>
        public string getFuelType()
        {
            return this.fuelType;
        }
        //set
        /// <summary>
        /// sets the price of petrol
        /// </summary>
        /// <param name="petrolPriceIn">price of petrol : double</param>
        public void setPetrolPrice(double petrolPriceIn)
        {
            this.petrolPrice = petrolPriceIn;
        }
        /// <summary>
        /// sets the quantity of fuel in the tank
        /// </summary>
        /// <param name="fuelLevelIn">quantity of fuel in tank : double</param>
        public void setFuelLevel(double fuelLevelIn)
        {
            this.fuelLevel = fuelLevelIn;
        }
        /// <summary>
        /// sets the minimum order on a fill of fuel
        /// </summary>
        /// <param name="minOrderIn">minimum order of fuel : double</param>
        public void setMinOrder(double minOrderIn)
        {
            this.minOrder = minOrderIn;
        }
        /// <summary>
        /// what type of fuel is in the tank
        /// </summary>
        /// <param name="fuelTypeIn">what type of fuel is in the tank : string</param>
        public void setFuelType(string fuelTypeIn)
        {
            this.fuelType = fuelTypeIn;
        }
        //behaviours
        /// <summary>
        /// adds the inputted amount to the tank of fuel
        /// </summary>
        /// <param name="fuelAdded"> amount of fuel added : double</param>
        public void addFuel(double fuelAdded)
        {
            this.setFuelLevel(getFuelLevel() + fuelAdded);
        }
        /// <summary>
        /// Checks required each time fuel is pumped from the tank
        /// </summary>
        /// <param name="custFill">the amount of fuel the customer wants : double</param>
        public void fillCarFromPump(double custFill)
        {
            //checks if what the customers order is less than the minimum order and if it is prints appropriate error message to screen
            if(custFill< minOrder)
            {
                Console.Clear();

                Console.WriteLine("Apologies we have a minimum order of " + getMinOrder() + " Litres");
            }
            //checks if there's enough fuel in the tank for the customers order if there isn't print appropriate error message to screen
            if(fuelLevel<custFill)
            {
                Console.Clear();

                Console.WriteLine("Apologies there is insufficient Fuel for your order.");
            }
            //checks if there's enough fuel for customer's order and if it is greater than or equal to the minimum order if it is
            //it removes customer's fuel from tank's current capacity and prints to screen the price the customer is charged
            if(custFill<fuelLevel && custFill>=minOrder)
            {
                this.setFuelLevel(getFuelLevel() - custFill);

                Console.Clear();

                Console.WriteLine("Your purchase comes to : " + (getPetrolPrice() * custFill)+ "euro");
            }
            
        }
    }
}
