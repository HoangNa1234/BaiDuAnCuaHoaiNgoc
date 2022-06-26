using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class HardCodeMenuService : IMenuService
    {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu
            {
                Pizzas = new List<Pizza> {
                    new Pizza(4, "Giay the thao", 8.99M, Spiciness.shoe1),
                    new Pizza(5, "Giay the thao", 7.99M, Spiciness.shoe2),
                    new Pizza(6, "Giay the thao", 9.99M, Spiciness.van),
                    new Pizza(7, "Giay the thao", 9.99M, Spiciness.van2),
                    new Pizza(8, "Giay the thao", 9.99M, Spiciness.van3)
                }
            });
    }
}
