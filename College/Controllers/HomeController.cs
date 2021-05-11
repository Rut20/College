using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IEnumerable<Details> GetAllStudent()
        {
            return BL.Bissnes.GetList();
        }

        [HttpGet("{param}")]
        public IEnumerable<Details> GetSearchStudent(string param)
        {
            return BL.Bissnes.GetSearchList(param);
        }
    }
}
