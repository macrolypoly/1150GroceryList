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
        private readonly Guid _userId;

        public RecipeService(Guid userId)
        {
            _userId = userId;
        }

        //Creating a recipe
        public bool CreateRecipe(RecipeCreate model)
        {
            var entity =
                new Recipe()
                {
                    OwnerId = _userId,
                    Name = model.Name,
                    RecipeDescription = model.RecipeDescription,
                    IngredientList = model.IngredientList,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Recipes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Getting a recipe (READ)
        public RecipeDetail GetRecipeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Recipes
                        .Single(e => e.RecipeId == id && e.OwnerId == _userId);
                return
                    new RecipeDetail
                    {
                        Name = entity.Name,
                        RecipeDescription = entity.RecipeDescription,
                        IngredientList = entity.IngredientList,
                        CreatedUtc = entity.CreatedUtc
                    };
            }
        }

        //Update a recipe (UPDATE) Stretch

        //Delete a recipe (DELETE)
        public bool DeleteRecipe(int recipeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Recipes
                        .Single(e => e.RecipeId == recipeId && e.OwnerId == _userId);

                ctx.Recipes.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
