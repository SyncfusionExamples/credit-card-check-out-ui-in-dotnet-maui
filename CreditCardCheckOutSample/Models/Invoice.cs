using System;
namespace CreditCardCheckOutSample.Models
{
	public class Invoice
	{
        private string description;
        private string price;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}

