using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore
{
    //Just like the Custom Cake class, this Traditional Cake class is also a child of the Cake class
    class TraditionalCake : Cake
    {
        //I create a bunch of static to represent the prices of the type of cake
        public static int STRAWBERRY_CHEESE_CAKE = 20;
        public static int LEMON_VELVET_CAKE = 30;
        public static int BLUEBERRY_MOUSSE = 23;
        public static int TIRAMISU = 27;
        //A constructor
        public TraditionalCake(string name)
        {
            //Give the Name a value
            this.Name = name;
            //Give the price a value using a switch statement (do more research on switch statement to learn more)
            //There are many ways to do this, THIS IS NOT THE ONLY WAY
            switch (name)
            {
                case "Strawberry Cheese Cake":
                    this.Price = STRAWBERRY_CHEESE_CAKE;
                    break;
                case "Lemon Velvet Cake":
                    this.Price = LEMON_VELVET_CAKE;
                    break;
                case "Blueberry Mousse":
                    this.Price = BLUEBERRY_MOUSSE;
                    break;
                default:
                    this.Price = TIRAMISU;
                    break;

            }
        }
        
    }
}
