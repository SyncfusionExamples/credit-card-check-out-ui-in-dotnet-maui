using System;
using System.Collections.ObjectModel;
using CreditCardCheckOutSample.Models;

namespace CreditCardCheckOutSample.ViewModels
{
	public class CardsViewModel
	{
        private ObservableCollection<Cards> cards;
        private ObservableCollection<Invoice> invoice;

        public ObservableCollection<Cards> Cards
        {
            get { return cards; }
            set { this.cards = value; }
        }

        public ObservableCollection<Invoice> Invoice
        {
            get { return invoice; }
            set { this.invoice = value; }
        }


        public CardsViewModel()
		{
            cards = new ObservableCollection<Cards>();
            cards.Add(new Cards { Picture = "ccard1" });
            cards.Add(new Cards { Picture = "ccard2" });

            invoice = new ObservableCollection<Invoice>();
            invoice.Add(new Invoice { Description = "Subtotal", Price="219$" });
            invoice.Add(new Invoice { Description = "Postage", Price = "3.9$" });
            invoice.Add(new Invoice { Description = "Tax", Price = "12.45$" });
        }
	}
}

