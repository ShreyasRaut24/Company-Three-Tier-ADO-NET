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
            var companyList = _companyService.List();
            return View(companyList);
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
