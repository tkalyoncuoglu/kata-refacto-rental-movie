using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Movie
{
    public class Childrens : IMovie
    {
        private String _title;

        public Childrens(String title)
        {
            _title = title;
        }

        
        public String getTitle()
        {
            return _title;
        }
    }
}
