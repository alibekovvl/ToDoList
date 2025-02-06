using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.ViewModels;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
        

        //public Task<IActionResult> Create(CreateTaskViewModel model)
        //{

        //}
    }
}
