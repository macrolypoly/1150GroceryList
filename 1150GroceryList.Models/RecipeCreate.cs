using _1150GroceryList.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Models
{
    public class RecipeCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RecipeDescription { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Required]
        public IngredientList IngredientList { get; set; }
    }
}
