using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Data
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public Guid OwnerId { get; set; }
        public string RecipeDescription { get; set; }
        public IngredientList IngredientList { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
