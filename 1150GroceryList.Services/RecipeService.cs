using _1150GroceryList.Data;
using _1150GroceryList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Services
{
    public class RecipeService
    {
        public bool CreateRecipe(RecipeCreate model)
        {
            var entity =
                new Recipe()
                {
                    RecipeId = model.RecipeId,
                    RecipeDescription = model.RecipeDescription
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Recipes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


    }
}
