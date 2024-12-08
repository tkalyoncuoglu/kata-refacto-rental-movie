using MovieRental.Rental;
using System.Collections.Generic;

namespace MovieRental
{
    public class Customer
    {

        private string _name;
        private List<IRental> _rentals = new List<IRental>();

        public Customer(string name)
        {
            _name = name;
        }

        public void addRental(IRental arg)
        {
            _rentals.Add(arg);
        }

        public string getName()
        {
            return _name;
        }

        public string statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = "Rental Record for " + getName() + "\n";

            foreach (IRental each in _rentals)
            {
                double thisAmount = 0;

                //determine amounts for each line
                thisAmount += each.getAmount();

                // add frequent renter points
                frequentRenterPoints += each.getFrequentRentalPoints();
                
                // show figures for this rental
                result += "\t" + each.getMovie().getTitle() + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            // add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points";

            return result;
        }
    }

}
