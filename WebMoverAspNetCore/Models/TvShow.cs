using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMoverAspNetCore.Models
{
    public class TvShow : Media
    {
        public TvShow(int id, string title, string physicalPath) : base(id, title, physicalPath)
        {

        }

        public IEnumerable<TvSeries> Series { get; set; }
    }
}
