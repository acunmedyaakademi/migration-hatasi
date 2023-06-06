using BasicBlogCms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicBlogCms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route(template: "post")]

        public IActionResult Post()
        {
            return View();
        }

        [Route ( template:"hakkimda")]
        public IActionResult About()
        {
            return View();
        }

        [Route(template: "iletisim")]

        public IActionResult Contact()
        {
            return View();
        }

        //public IActionResult SaveForm()
        //{
        //    var ContactForm = new ContactModel();
        //    ContactForm.Name = "Çiğdem Kabak";
        //    ContactForm.Email = "cigdemkoca96@gmail.com";
        //    ContactForm.Phone = "(538) 685 46 84 ";
        //    ContactForm.Message = "Site mük olmuş";


        //    _context.Add();
        //    _context.SaveChanges();

        //    return Content("Eklendi");
        //}

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}