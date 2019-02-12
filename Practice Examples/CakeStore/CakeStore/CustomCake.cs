using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore
{
    //This is a child of a cake class
    //Do research on c# Parent, Child class, Polymorphism to learn more about this and how to do them, they are very important
    class CustomCake : Cake
    {
        //In the below area, I will create a bunch of properties
        //These properties represent the things that Custom cake has which Cake doesnt have
        //This is what a child class for, to extend the parent class
        //A static because they base price for all Custom cake is the same
        public static int BASE_PRICE = 20; //This is not a property
        //Property area begin
        public string Flavor { get; set; } 
        public string Occasion { get; set; }
        public int Tier { get; set; }
        //End of property area
        //Building an overload constructor which does more than just initizialing the object
        public CustomCake(string flavor, string occasion, int tier) //The stuffs inside the () are call parethensis, do more reasearch on Class and Methods to understand them, they are very important
        {
            //I give the properties a values retrieve from the parenthesis
            this.Flavor = flavor;
            this.Occasion = occasion;
            this.Tier = tier;
            //I give the Name property a value
            this.Name = tier + "-Tier Custom Cake with " + flavor + " flavor for " + occasion + " occasion";
            //I give the Price property a value
            this.Price = BASE_PRICE * tier;
            //Notice that there are no Name or Price in the Property area but they still show up here
            //That is because this Custom Cake class is a child of the Cake class
            //And the Cake class has these so by default the Custom Cake class will also have them
            //Again please do more research on Parent and Children class to fully understand them
        }
    }
}
