//*************************************************************************************
//  Customer.cs
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
    class Customer : Person
    {
        private string _customerNumber;
        private bool _onMailingList;

        public Customer()
        {
            _customerNumber = "";
            _onMailingList = false;
        }

        public string CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        public bool OnMailingList
        {
            get { return _onMailingList; }
            set { _onMailingList = value; }
        }
    }
}
