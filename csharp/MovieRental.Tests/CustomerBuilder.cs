using MovieRental.Rental;
using System;
using System.Collections.Generic;

namespace MovieRental.Tests
{
    public class CustomerBuilder
    {

        public static readonly String NAME = "Roberts";

    private String name = NAME;
        private List<IRental> rentals = new List<IRental>();

        public Customer build()
        {
            Customer result = new Customer(name);
            foreach (IRental rental in rentals)
            {
                result.addRental(rental);
            }
            return result;
        }

        public CustomerBuilder withName(String name)
        {
            this.name = name;
            return this;
        }

        public CustomerBuilder withRentals(params IRental[] rentals)
        {
            this.rentals.AddRange(rentals);
            return this;
        }
    }

}
