using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMoverAspNetCore.Models
{
    public class TvSeries
    {
        public IEnumerable<TvEpisode> Episodes { get; set; }
    }
}
