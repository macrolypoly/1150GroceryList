using _1150GroceryList.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Models.IngredientListModel
{
    public class IngredientListDetail
    {
        public int IngredientListId { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
    }
}
