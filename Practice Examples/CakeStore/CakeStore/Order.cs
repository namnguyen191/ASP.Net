using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeStore
{
    //This is a little bit tricky, but in this assignment, I also see order as an object
    //The logic behind why I make this class is because:
    // a. I see order as an object
    // b. I don't want to make my Main Class too complicate
    // c. The code look cleaner and more organized
    class Order
    {
        //Property area begin
        public List<Cake> listCake { get; set; } //Creating a list of Cake
        public Customer customer { get; set; } //Creating a customer object
        //Property area end
        //A static for the tax because the tax for all order should be the same
        public static double TAX = 1.13;
        //A constructor
        public Order()
        {
            //Initizalizing the Cake list and the Customer object
            listCake = new List<Cake>();
            customer = new Customer();
        }
        //This is a method, I use it to add a cake to the cake list and show a message box
        //Please learn more about method in c#, this is something VERY IMPORTANT, you need to know when to make a method
        public void addCake(Cake cake)
        {
            listCake.Add(cake);
            MessageBox.Show("You add 1 " + cake.Name);
        }
        //This is a method I use to calculate the total cost of the order
        public double calculateCost()
        {
            double cost = 0;
            foreach(Cake cake in listCake) //Foreach loop to loop through every item in a list, learn more about c# list and you will understand
            {
                cost += cake.Price;
            }
            return cost;
        }
        //This is a method to print out the finnal message for the order
        public string ToString()
        {
            string orderMessage = "Thank you " + customer.FName + " " + customer.LName + "!\nYou have ordered:\n";
            foreach(Cake cake in listCake)
            {
                orderMessage += "1 " + cake.Name + "\n";
            }
            orderMessage += "For the total of: $" + calculateCost();
            return orderMessage;
        }
    }
}
