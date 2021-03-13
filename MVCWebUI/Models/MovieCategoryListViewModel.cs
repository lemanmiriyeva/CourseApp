using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebUI.Models.Entity;

namespace MVCWebUI.Models
{
    public class MovieCategoryListViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Category> Categories { get; set; }
    }
}
