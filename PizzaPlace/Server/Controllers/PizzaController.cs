using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;
namespace PizzaPlace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaPlaceDbContext db;
        public PizzaController(PizzaPlaceDbContext db)
        {
            this.db = db;
        }
        [HttpGet("/pizzas")]
        public IQueryable<Pizza> GetPizzas()
            => this.db.Pizzas;
        [HttpPost("/pizzas")]
        public IActionResult InsertPizza([FromBody] Pizza pizza)
        {
            db.Pizzas.Add(pizza);
            db.SaveChanges();
            return Created($"pizzas/{pizza.Id}", pizza);
        }
            

    }
}
