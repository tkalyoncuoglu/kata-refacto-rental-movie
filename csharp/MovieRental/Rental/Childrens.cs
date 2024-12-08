using MovieRental.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Rental
{
    public class Childrens : IRental
    {
        private Movie.Childrens _movie;
        private int _daysRented;

        public Childrens(Movie.Childrens movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }
        public double getAmount()
        {
            double thisAmount = 1.5;
            if (_daysRented > 3)
                thisAmount += (_daysRented - 3) * 1.5;
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
