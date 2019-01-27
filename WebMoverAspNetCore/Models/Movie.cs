using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMoverAspNetCore.Models
{
    public class Movie : Media
    {
        public Movie(int id, string title, string physicalPath) : base(id, title, physicalPath)
        {
        }
    }
}
