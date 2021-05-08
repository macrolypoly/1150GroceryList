using _1150GroceryList.Data;
using _1150GroceryList.Models.IngredientModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Services
{
    public class IngredientService
    {
        public bool CreateIngredient(IngredientCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = new Ingredient();
                entity.Id = model.IngredientId;
                entity.Name = model.Name;

                ctx.Ingredients.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<IngredientListItem> GetAllIngredients()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Ingredients
                    .Select(p => new IngredientListItem()
                    {
                        IngredientId = p.Id,
                        Name = p.Name
                    });
                return query.ToArray();
            }
        }
        public bool DeleteIngredient(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Ingredients
                    .Single(e => e.Id == id);
                ctx.Ingredients.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
