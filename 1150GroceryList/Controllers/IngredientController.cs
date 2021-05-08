using _1150GroceryList.Models.IngredientModels;
using _1150GroceryList.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1150GroceryList.Controllers
{
    [Authorize]
    public class IngredientController : ApiController
    {
        private IngredientService CreateIngredientService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var ingredientservice = new IngredientService();
            return ingredientservice;
        }
        public IHttpActionResult Get(int id)
        {
            IngredientService ingredientService = CreateIngredientService();
            var ingredients = ingredientService.GetAllIngredients();
            return Ok(ingredients);
        }
        public IHttpActionResult Post(IngredientCreate ingredient, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateIngredientService();

            if (!service.CreateIngredient(ingredient))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Put(IngredientEdit ingredient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateIngredientService();

            if (!service.UpdateIngredient(ingredient))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateIngredientService();

            if (!service.DeleteIngredient(id))
                return InternalServerError();

            return Ok();
        }
    }
}
