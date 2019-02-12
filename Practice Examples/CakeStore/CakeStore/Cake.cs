using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore
{
    //Cake class to create a cake object
    //I create this class because both custom cake and traditional cake have: a price and a name
    class Cake
    {
        //Variable price(because both cake have a price) with double datatype(price is a number so you can make it integer, float ... as well if you want)
        public double Price { get; set; }
        //Variable name(because both cake have a name) with string datatype
        public string Name { get; set; }

        //Name and Price here are called property, its just easier to use. (Do some reasearch on c# property (Linda or youtube) if you wish to learn more)

        //Default Constructor which we use to initizialize the cake object, this constructor does nothing else
        public Cake()
        {

        }
    }
}
