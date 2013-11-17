using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace guthubservice.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}