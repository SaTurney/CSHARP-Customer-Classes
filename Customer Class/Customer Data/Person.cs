using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Data
{
    class Person
    {
        //Designate the customer's entered info into variables.
        string cusName;
        string cusAddress;
        string cusPhoneNumber;

        //Creating the Name as a value:
        public string Name
        {
            get
            {
                return cusName;
            }
            set
            {
                cusName = value;
            }
        }

        //Doing the same get/set method for the address:
        public string Address
        {
            get
            {
                return cusAddress;
            }
            set
            {
                cusAddress = value;
            }
        }
        //And one more time for the customer's phone number.
        public string PhoneNumber
        {
            get
            {
                return cusPhoneNumber;
            }
            set
            {
                cusPhoneNumber = value;
            }
        }
    }
}
