using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Data
{
    class Customer : Person //Add the person modifier here!
                            //or nothing will work!
    {
        int customerNumber; //I make this lowercase so it won't confuse the compiler.
        //it may still confuse me.
        bool mailing;
        //Once we've initialized our variables,
        //we can start creating a new property.

        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                customerNumber = value;
            }
        }
        //Do the same for the mailing check - Who doesn't  love to subscribe to an email list?
        public bool Mailing
        //again, I use the capital form for properties.
        {
            get
            {
                return mailing;
            }
            set
            {
                mailing = value;
            }

        }
    }
}
