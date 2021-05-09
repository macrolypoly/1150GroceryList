using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Models.IngredientListModel
{
    public class IngredientListItem2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IngredientDataListItem> IngredientListforitem { get; set; }
    }
}
