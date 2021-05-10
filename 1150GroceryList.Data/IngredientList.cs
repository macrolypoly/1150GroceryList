using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Data
{
    public class IngredientList
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } //ingredientsformeal a
        public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public IngredientList()
        {
            Ingredients = new HashSet<Ingredient>();

        }
    }
}
