using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Data
{
    public class Meal
    {
        [Key]
        public int MealId { get; set; }
        [Required]
        public string MealName { get; set; }
        [Required]
        public string MealDecription { get; set; }
        [Required]
        public virtual ICollection<Recipe> RecipesList{ get; set; }
        [Required]
        [ForeignKey("IngredientList")]
        public int IngredientListId { get; set; }
        public virtual IngredientList IngredientList { get; set; }

    }
}
