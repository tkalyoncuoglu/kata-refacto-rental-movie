using MovieRental.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Rental
{
    public class NewRelease : IRental
    {
        private Movie.NewRelease _movie;
        private int _daysRented;

        public NewRelease(Movie.NewRelease movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }
        public double getAmount()
        {
            return _daysRented * 3;
        }

        public int getFrequentRentalPoints()
        {
            if (_daysRented > 1)
                return 2;
            return 1;
        }

        public IMovie getMovie()
        {
            return _movie;
        }
    }
}
