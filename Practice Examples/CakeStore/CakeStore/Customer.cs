using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore
{
    //I make a class for customer because I see customer as an object
    class Customer
    {
        //Property area begin
        public string FName { get; set; }
        public string LName { get; set; }
        //Property area end
        //This is the default constructor
        public Customer()
        {

        }
        //Another constructor
        public Customer(string fname, string lname)
        {
            //Give the FName a value
            FName = fname;
            //Give the LName a value
            LName = lname;
        }
    }
}
