//*************************************************************************************
//  Person.cs
//
//  AUTHOR: DUSTIN KABAN
//  ID: T00663749
//  DATE: APRIL 22nd, 2021
//  COURSE: COMP 2211, ASSIGNMENT 5: C#
//
//  This is a base class with the intention to be inherited by other classes needing a Person
//*************************************************************************************

namespace PreferredCustomer
{
    class Person
    {
        private string _name;
        private string _address;
        private string _telephoneNumber;

        public Person()
        {
            _name = "";
            _address = "";
            _telephoneNumber = "";
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string TelelphoneNumber
        {
            get { return _telephoneNumber; }
            set { _telephoneNumber = value; }
        }
    }
}
