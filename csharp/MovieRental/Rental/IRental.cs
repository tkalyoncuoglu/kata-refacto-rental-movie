using MovieRental.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Rental
{
    public interface IRental
    {
        double getAmount();

        int getFrequentRentalPoints();

        IMovie getMovie();
    }
}
