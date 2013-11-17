using guthubservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace guthubservice.Controllers
{
    public class RecipeController : ApiController
    {
        private static List<Recipe> _data = new List<Recipe>()
        {
            new Recipe() {
                Id = 1,
                Title = "Salmon BBQ",
                Description = "Nice n juicy grilled salmon with some espcial BBQ sauce.",
                Ingredients = new List<Ingredient>() {
                    new Ingredient() { IngredientName="Salmon", AmountUnits = "filet", Amout = 1},
                    new Ingredient() { IngredientName="Onion", AmountUnits = "unit", Amout = 1},
                    new Ingredient() { IngredientName="BBQ Sauce", AmountUnits = "bottle", Amout = 1}
                },
                Instructions = "Cut the salmon in filets, heat up the grill for about half hour, cut the onion on thin "
                    + "slices, marinate the salmon with the BBQ sauce for about 10 minutes, when the grill is hot, put the "
                    + "salmon and let grill for 30 minutes"
            },
            new Recipe() {
                Id = 2,
                Title = "Salmon BBQ 2",
                Description = "Nice n juicy grilled salmon with some espcial BBQ sauce.",
                Ingredients = new List<Ingredient>() {
                    new Ingredient() { IngredientName="Salmon", AmountUnits = "filet", Amout = 1},
                    new Ingredient() { IngredientName="Onion", AmountUnits = "unit", Amout = 1},
                    new Ingredient() { IngredientName="BBQ Sauce", AmountUnits = "bottle", Amout = 1}
                },
                Instructions = "Cut the salmon in filets, heat up the grill for about half hour, cut the onion on thin "
                    + "slices, marinate the salmon with the BBQ sauce for about 10 minutes, when the grill is hot, put the "
                    + "salmon and let grill for 30 minutes"
            }
        };

        // GET /recipe/
        public List<Recipe> Get()
        {
            return _data;
        }

        // Get /recipe/:id
        public Recipe Get(int id)
        {
            var recipe = _data.SingleOrDefault(r => r.Id == id);
            if (recipe == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return recipe;
        }
    }
}
