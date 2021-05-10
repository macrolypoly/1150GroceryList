using _1150GroceryList.Data;
using _1150GroceryList.Models.IngredientListModel;
using _1150GroceryList.Models.IngredientModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroceryList.Services
{
    public class IngredientListService
    {
        private readonly Guid _Userid;
        public IngredientListService(Guid userid)
        {
            _Userid = userid;
        }

        public bool CreateIngredientList(IngredientListCreate model)
        {
            var entity1 = new IngredientList()
            {
                Name = model.Name,
                
                
            };
            using (var ctx = new ApplicationDbContext())
            {
                foreach (var c in model.IngedientId)
                {
                    var enti = ctx.
                                    Ingredients
                                    .SingleOrDefault(r => r.Id == c);
                    if (enti is null)
                        return false;


                    entity1.Ingredients.Add(enti);
                }

                ctx.IngredientLists.Add(entity1);

                return ctx.SaveChanges() == 1;
            }

        }
        public IEnumerable<IngredientListItem2> GetAllIngredientList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.
                                IngredientLists
                                .Select(i => new IngredientListItem2()
                                {
                                    Id = i.Id,
                                    Name = i.Name,
                                    IngredientListforitem = i.Ingredients.Select(e => new IngredientDataListItem()
                                    {
                                        Id = e.Id,
                                        Name = e.Name
                                    }).ToList()

                                }).ToList();

                return query;
            }

        }
        public IngredientListDetail Getingredientlistforrecipe(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                                .IngredientLists
                                .SingleOrDefault(c => c.Id == id);



                var ingredient = new IngredientListDetail()   //using an explicit cast
                {
                    IngredientListId = entity.Id,
                    Name = entity.Name,
                    Ingredients = (List<Ingredient>)entity.Ingredients.Select(i => new IngredientListItem()
                    {
                        Name = i.Name,
                        IsOrganic = i.IsOrganic

                    })
                };
                return ingredient;
                

            }

        }

    }





}

