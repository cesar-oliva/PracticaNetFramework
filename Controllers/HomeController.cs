
using DataLayer;
using NET_Framework.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
    public class HomeController : Controller
	{
		private readonly MyContext _myContext = new MyContext();
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Products()
		{
			ViewBag.Message = "Productos";

			var product = _myContext.Products.ToList();
			var model = new ProductsViewModel()
			{
				Product = product,
				Company = product.First().Company
		};

			return View(model);
		}

		public ActionResult JsonObtener(string comment)
		{
			var producto = _myContext.Products.Where(x => x.Description.Contains(comment)).FirstOrDefault();

			return Json(new { nombre = producto.Name, desc = producto.Description}, JsonRequestBehavior.AllowGet);
		}
	}
}