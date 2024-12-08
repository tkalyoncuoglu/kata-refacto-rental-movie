using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Movie
{
    public class NewRelease : IMovie
    {
        private String _title;

        public NewRelease(String title)
        {
            _title = title;
        }


        public String getTitle()
        {
            return _title;
        }
    }
}
