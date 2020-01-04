//Sabrina Turney
//C# I
//Problem 4: Customer and Person Classes
//Last Edited 10/03/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //Create the customer class in the actual form:
            Customer customer = new Customer();
            SetCustomerData(customer);
            //Use a function to set all the data into the boxes for the user.

            lblName.Text = customer.Name;
            lblAddress.Text = customer.Address;
            lblPhoneNo.Text = customer.PhoneNumber;
            //Last two need to be set using ToString method because
            //they are different value types (also in separate class!)
            lblCustomerNo.Text = customer.CustomerNumber.ToString();
            lblMailing.Text = customer.Mailing.ToString();
            //All the classes should cause the labels to fill,
            //and the labels should fill with the exact data entered-
            //except they will be Teal.
        }

        //Here is our function to check our data entered and apply it to our
        //customer object.
        private void SetCustomerData(Customer customer)
        {
            //initialize variables we'll use in this function
            //(apart from the objects we're referencing above)
            int customerNumber;
            bool mailing;

            //Begin checking for empty boxes.
            
            //Is a name entered?
            if (txtName.Text != "")
            {
                customer.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Please enter a name!");
            }

            //Next: is there an address entered?
            if (txtAddress.Text != "")
            {
                customer.Address = txtAddress.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid address.");
            }
            
            //Last: is there a phone number entered?
            if (txtPhoneNo.Text != "")
            {
                customer.PhoneNumber = txtPhoneNo.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.");
            }

            //---------------------------------------
            //Now, we check to see that our customer number is in fact a number.
            if (int.TryParse(txtCustomerNo.Text, out customerNumber))
            {
                customer.CustomerNumber = customerNumber;
            }
            else
            {
                MessageBox.Show("Invald customer number. Please enter numbers only.");
            }

            //Lastly, we check the Bool of the mailing checkbox.
            if (bool.TryParse(chkMailing.Checked.ToString(), out mailing))
            {
                customer.Mailing = mailing;
            }
            else
            {
                MessageBox.Show("Invalid Mailing Check: Please review.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Exits the program. You already know I live for this part.
            this.Close();
            //Nice.
        }
    }
}
