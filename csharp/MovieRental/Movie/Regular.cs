using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Movie
{
    public class Regular : IMovie
    {
        private String _title;

        public Regular(String title)
        {
            _title = title;
        }


        public String getTitle()
        {
            return _title;
        }
    }
}
