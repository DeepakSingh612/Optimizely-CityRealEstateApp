using CityRealEstate.Models;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CityRealEstate.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}
