using Microsoft.AspNetCore.Mvc;
using Project_.Models;
namespace Project_.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult SearchResult()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Search s)
        {
            Search_function search_Function = new Search_function();
            List<AdsDatum> ads= search_Function.ads(s);
            return View();
        }
    }
    
}
