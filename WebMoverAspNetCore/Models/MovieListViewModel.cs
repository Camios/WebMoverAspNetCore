using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMoverAspNetCore.Models
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }

    }
}
