using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_one.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre GenreType { get; set; }
        public byte GenreTypeId { get; set; }

    }
}