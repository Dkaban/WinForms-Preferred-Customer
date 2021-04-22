//*************************************************************************************
//  PreferredCustomer.cs
//
//  AUTHOR: DUSTIN KABAN
//  ID: T00663749
//  DATE: APRIL 22nd, 2021
//  COURSE: COMP 2211, ASSIGNMENT 5: C#
//
//  This class inherits the Person class to create a customer for a business
//*************************************************************************************

namespace PreferredCustomer
{
    class PreferredCustomer : Customer
    {
        public int _amount;
        public decimal _discount;

        public PreferredCustomer()
        {
            _amount = 0;
            _discount = 0;
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
    }
}
