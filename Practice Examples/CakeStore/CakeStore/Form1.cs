using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeStore
{
    public partial class Form1 : Form //You see that your form is actually a child class of the Form class
    {
        private Order order;
        //This is where the form is initialized
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen(); //This just make the form appear at the center of your screen
            //Initizialize the order
            order = new Order();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //This if statement is to check whether radCustomCake or radTraditionCake is checked
            if (radCustomCake.Checked)
            {
                //These if statements are used to check which radiobuttons are checked
                string flavor, occasion;
                int tier;
                if (radChocolate.Checked)
                {
                    flavor = "Chocolate";
                } else if (radVanilla.Checked)
                {
                    flavor = "Vanilla";
                } else { flavor = "Banana"; }

                if (radWedding.Checked)
                {
                    occasion = "Wedding";
                } else if (radGraduation.Checked)
                {
                    occasion = "Graduation";
                } else { occasion = "Aniversary"; }

                if (radTier1.Checked)
                {
                    tier = 1;
                } else if (radTier2.Checked)
                {
                    tier = 2;
                } else { tier = 3; }
                //Call the addCake method from Order class
                //We add a new CustomCake because the radCustomCake is checked
                order.addCake(new CustomCake(flavor, occasion, tier));
                
            }
            else
            {
                //This foreach is to retrieve all the seleced cakes
                foreach(int i in lstTradCakes.SelectedIndices)
                {
                    //Call the addCake method from Order class
                    //We add a new TraditionalCake because the radTraditonalCake is checked
                    order.addCake(new TraditionalCake(lstTradCakes.Items[i].ToString()));
                }              
            }
        }

        //This thing handle what happen when you change between radCustomCake and radTradCake
        private void radCustomCake_CheckedChanged(object sender, EventArgs e)
        {
            if (radCustomCake.Checked)
            {
                grpCustomCake.Enabled = true;
                lstTradCakes.Enabled = false;
            } else
            {
                grpCustomCake.Enabled = false;
                lstTradCakes.Enabled = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!order.listCake.Any()) //Basically check if the list is empty or not
            {
                MessageBox.Show("Your cart is empty");
            }
            else
            {
                string cakeNames = "";
                foreach (Cake cake in order.listCake) //Again foreach to go through the listCake
                {
                    cakeNames += cake.Name + "\n";
                }
                MessageBox.Show(cakeNames + "Total Cost: $" + order.calculateCost()); //Call calculateCost from Order Class
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            order.listCake.Clear(); //clear all item from the listCake
            MessageBox.Show("Cart Cleared Successfully!");
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text)) //Check if the user has entered their first name and last name or not
            {
                MessageBox.Show("Please enter your First Name and Last Name", "Name Cannot Be Empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!order.listCake.Any()) //Check if the user has add a cake to their cart or not
            {
                MessageBox.Show("Your cart is empty. Please add an item to your cart to proceed with checking out.");
            }
            else
            {
                order.customer = new Customer(txtFName.Text, txtLName.Text); //Init the customer of the order object
                MessageBox.Show(order.ToString()); //Call the ToString method from the Oder Class

            }
        }

        //Just reseting the form to it original from
        //I dont clear the cart because I'm not sure if you need to
        //If you want to clear the cart just coppy the code from clearCart button click and paste them inside
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtFName.Focus();
            txtLName.Clear();
            radCustomCake.Checked = true;
            radChocolate.Checked = true;
            radAniversary.Checked = true;
            radTier1.Checked = true;
            lstTradCakes.ClearSelected();
        }

        //Exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
