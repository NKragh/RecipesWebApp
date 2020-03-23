using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesWebApp.Models;
using RecipesWebApp.Services;

namespace RecipesWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        // GET: api/Recipe
        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> Get()
        {
            return _recipeService.Get();
        }

        // GET: api/Recipe/5
        [HttpGet("{id}")]
        public ActionResult<Recipe> Get(string id)
        {
            var recipe = _recipeService.Get(id);
            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        // POST: api/Recipe
        [HttpPost]
        public void Post([FromBody] Recipe recipe)
        {
            _recipeService.Create(recipe);
        }

        // PUT: api/Recipe/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Recipe recipeIn)
        {
            var recipe = _recipeService.Get(id) ?? throw new ArgumentNullException("_recipeService.Get(id)");
            _recipeService.Update(id, recipeIn);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _recipeService.Remove(id);
        }
    }
}
