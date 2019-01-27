using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMoverAspNetCore.Models
{
    public class Media
    {
        private string physicalPath;

        public Media(int id, string title, string physicalPath)
        {
            Id = id;
            Title = title;
            this.physicalPath = physicalPath;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Path { get; set; }
    }
}
