using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        public static List<MenuItem> MenuItems = new List<MenuItem>()
        {
            new MenuItem(){ Id=1, Name="Paste", freeDelivery=false, Price=110.5, dateOfLaunch=new DateTime(2022,7,1), Active=true},
            new MenuItem() { Id=2,Name="Brush",freeDelivery=false, Price= 30, dateOfLaunch=new DateTime(2022,7,1), Active=true },
            new MenuItem() { Id=3,Name="Soap",freeDelivery=false, Price= 60, dateOfLaunch=new DateTime(2022,7,1), Active=true },
            new MenuItem() { Id=4,Name="Shampoo",freeDelivery=true, Price= 170, dateOfLaunch=new DateTime(2022,7,1), Active=true },
            new MenuItem() { Id=5,Name="Conditioner",freeDelivery=true, Price= 200, dateOfLaunch=new DateTime(2022,7,1), Active=true }
        };
       
        // GET: api/<MenuItemController>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return MenuItems.ToList();
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            MenuItem item = MenuItems.FirstOrDefault(p => p.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
