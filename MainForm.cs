//*************************************************************************************
//  MainForm.cs
//
//  AUTHOR: DUSTIN KABAN
//  ID: T00663749
//  DATE: APRIL 22nd, 2021
//  COURSE: COMP 2211, ASSIGNMENT 5: C#, QUESTION 5, P. 644
//
//  This class handles all the form interactivity
//*************************************************************************************

using System;
using System.Windows.Forms;

namespace PreferredCustomer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            PreferredCustomer preferredCustomer = new PreferredCustomer();

            //Get the Name and the Address as entered in the text boxes
            preferredCustomer.Name = nameTextBox.Text;
            preferredCustomer.Address = addressTextBox.Text;

            //Try and get the phone number, if it was added correctly.
            string phoneNumber = phoneNumberTextBox.Text.Trim();
            if(IsValidTelephoneNumber(phoneNumber))
            {
                TelephoneFormat(ref phoneNumber);
                preferredCustomer.TelelphoneNumber = phoneNumber;
            }

            preferredCustomer.CustomerNumber = customerNumberTextBox.Text;
            preferredCustomer.OnMailingList = mailingListCheckBox.Checked;

            int amountSpent;
            if(int.TryParse(totalSpentTextBox.Text,out amountSpent))
            {
                preferredCustomer.Amount = amountSpent;
                //If the amount spent is correct, we can determine the discount
                preferredCustomer.Discount = DetermineDiscount(amountSpent);
            }

            //Add the customer to the list if they are a valid entry
            if(IsValidCustomer(preferredCustomer))
            {
                string customerString = "Name: " + preferredCustomer.Name 
                    + ", Phone: " + preferredCustomer.TelelphoneNumber 
                    + ", Customer: " + preferredCustomer.CustomerNumber
                    + ", Mailing List: " + preferredCustomer.OnMailingList
                    + ", Total Spent: " + preferredCustomer.Amount.ToString("c")
                    + ", Discount: " + preferredCustomer.Discount.ToString("p");

                customerListBox.Items.Add(customerString);
                MessageBox.Show("Customer Successfully Added to the List");
            }
            else
            {
                MessageBox.Show("Customer Information was Invalid");
            }
        }

        private bool IsValidTelephoneNumber(string str)
        {
            const int VALID_LENGTH = 10;
            bool valid = true;

            if (str.Length == VALID_LENGTH)
            {
                foreach (char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        //It's not a digit so return false
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false; //Not long enough
            }
            return valid;
        }

        private void TelephoneFormat(ref string str)
        {
            str = str.Insert(0, "("); //Insert ( at index 0
            str = str.Insert(4, ")");//Insert ) at index 4
            str = str.Insert(8, "-");//Insert - at index 8
        }

        private bool IsValidCustomer(PreferredCustomer customer)
        {
            //Customer must have a name, address, telephone number and a customer number in order to be valid.
            if(customer.Name != "" && customer.Address != "" && customer.TelelphoneNumber != "" && customer.CustomerNumber != "")
            {
                return true;
            }

            return false;
        }

        private decimal DetermineDiscount(int amountSpent)
        {
            if(amountSpent >= 2000)
            {
                return 0.1m; //10% discount
            }
            else if(amountSpent >= 1500)
            {
                return 0.07m;//7% discount
            }
            else if(amountSpent >= 1000)
            {
                return 0.06m;//6% discount
            }
            else if(amountSpent >= 500)
            {
                return 0.05m;//5% discount
            }
            return 0;//No discount
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
