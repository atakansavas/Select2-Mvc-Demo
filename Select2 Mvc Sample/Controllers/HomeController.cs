using Select2_Mvc_Sample.Data;
using System.Linq;
using System.Web.Mvc;

namespace Select2_Mvc_Sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetValues(string searchTerm, int pageSize, int pageNum, string countyId)
        {
            //Getting items
            var itemList = Utility.GetItems().Where(p => string.IsNullOrEmpty(searchTerm) || p.Id == int.Parse(searchTerm)).ToList();

            //Creating new object for return.
            var result = new
            {
                Total = itemList.Count(),
                Results = itemList.Skip((pageNum * pageSize) - 100).Take(pageSize)
            };

            return new JsonResult
            {
                Data = result,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}