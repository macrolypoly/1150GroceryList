using _1150GroceryList.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Models
{
    public class RecipeDetail
    {
        public string Name { get; set; }
        public string RecipeDescription { get; set; }
        public IngredientList IngredientList { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
