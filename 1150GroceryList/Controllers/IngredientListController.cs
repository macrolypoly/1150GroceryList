using _1150GroceryList.Models.IngredientListModel;
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
    public class IngredientListController : ApiController
    {

        private IngredientListService CreateIngredientListServices()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var sservices = new IngredientListService(userid);
            return sservices;
        }

        public IHttpActionResult PostIngredintToLiost(IngredientListCreate model)
        {
            var ing = CreateIngredientListServices();
            var sservice = ing.CreateIngredientList(model);
            return Ok("ingredeint");
        }
        public IHttpActionResult GetAllIngredientList()
        {
            var ing = CreateIngredientListServices();
            var sservice = ing.GetAllIngredientList();
            return Ok(sservice);
        }
    }
}
