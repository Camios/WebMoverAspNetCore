using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;

namespace WebMoverAspNetCore.Models
{
    public class MediaLibrary
    {
        private readonly IConfiguration _configuration;

        //private List<IFileProvider> _tvProviders = new List<IFileProvider>();
        //private List<IFileProvider> _movieProviders = new List<IFileProvider>();


        public MediaLibrary(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // TODO
        //public IEnumerable<TvShow> GetTvShows()
        //{
        //    var folders = _configuration.GetSection("folders:tvshows").Get<List<string>>();
        //    int id = 0;

        //    foreach (var folder in folders)
        //    {
        //        IFileProvider fileProvider = new PhysicalFileProvider(folder);

        //        foreach (var dirContents in fileProvider.GetDirectoryContents(""))
        //        {
        //            if (dirContents.IsDirectory)
        //            {
        //                var show = new TvShow(id, dirContents.Name, dirContents.PhysicalPath);
        //                id++;
        //                show.Series = LoadSeries(show, dirContents);
        //            }
        //        }


        //    }
        //}

        public IEnumerable<Movie> GetMovies()
        {
            var folders = _configuration.GetSection("folders:movies").Get<List<string>>();
            int id = 0;
            var movies = new List<Movie>();
            foreach (var folder in folders)
            {
                IFileProvider fileProvider = new PhysicalFileProvider(folder);

                foreach (var dirContents in fileProvider.GetDirectoryContents(""))
                {
                    if (dirContents.IsDirectory)
                    {
                        var movie = new Movie(id, dirContents.Name, dirContents.PhysicalPath);
                        id++;
                        movies.Add(movie);
                    }
                }
            }

            return movies;
        }
    }
}
