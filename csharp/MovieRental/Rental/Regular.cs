using MovieRental.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Rental
{
    public class Regular : IRental
    {
        private Movie.Regular _movie;
        private int _daysRented;

        public Regular(Movie.Regular movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }

        public double getAmount()
        {
            double thisAmount = 2;
            if (_daysRented > 2)
                thisAmount += (_daysRented - 2) * 1.5;
            return thisAmount;
        }

        public int getFrequentRentalPoints()
        {
            return 1;
        }

        public IMovie getMovie()
        {
            return _movie;
        }
    }
}
