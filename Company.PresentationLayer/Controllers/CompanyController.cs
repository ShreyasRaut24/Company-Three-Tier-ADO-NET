using Microsoft.AspNetCore.Mvc;
using Company.Model;
using System.Data.SqlTypes;
using Company.BusinessLayer;
namespace Company.PresentationLayer.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CompanyModel companyModel)
        {
            _companyService.Create(companyModel);
            return RedirectToAction("Index");
        }
    }
}
