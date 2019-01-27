using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMoverAspNetCore.Models
{
    public class Movies
    {
        private readonly MediaLibrary _mediaLibrary;

        public Movies(MediaLibrary mediaLibrary)
        {
            _mediaLibrary = mediaLibrary;
        }

        public Movie Get(int id)
        {
            return _mediaLibrary.GetMovies().FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _mediaLibrary.GetMovies();
        }
    }
}
