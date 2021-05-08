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

        public string Name { get; set; }
        public virtual ICollection<Ingredient> ListofIngredient { get; set; }

        public IngredientList()
        {
            ListofIngredient = new HashSet<Ingredient>();

        }
    }
}
