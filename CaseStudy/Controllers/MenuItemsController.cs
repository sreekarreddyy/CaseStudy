using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {

        public static List<MenuItem> mnItems = new List<MenuItem>
        {
            new MenuItem{ItemId = 1, ItemName = "Pizza", Price = 50, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-10"), FreeDelivery = "yes"},
            new MenuItem{ItemId = 2, ItemName = "Burger", Price = 35, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-15"), FreeDelivery = "yes"},
            new MenuItem{ItemId = 3, ItemName = "Pasta", Price = 60, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-15"), FreeDelivery = "yes"},
            new MenuItem{ItemId = 4, ItemName = "Maggie", Price = 30, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-15"), FreeDelivery = "yes"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<MenuItem>> GetMenuItems()
        {
            return mnItems;
        }

        [HttpGet("{id}")]
        public ActionResult<MenuItem> GetItems(int id)
        {
            var mItem = mnItems.FirstOrDefault(item => item.ItemId == id);

            if (mItem == null)
            {
                return NotFound();
            }

            return mItem;
        }
    }
}
