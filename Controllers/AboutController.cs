using Homework_26_05.Models;
using Homework_26_05.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace Homework_26_05.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        var aims = new List<Aim>
        {
            new Aim
            {
                Id = 1,
                StylingTitle = "bxs-bulb",
                Title = "Our Vision",
                Description = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."
            },
            new Aim
            {
                Id = 2,
                StylingTitle = "bx-revision",
                Title = "Our Mission",
                Description = "Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis."
            },
            new Aim
            {
                Id = 3,
                StylingTitle = "bxs-select-multiple",
                Title = "Our Goal",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor."
            }
        };
        
        var model = new HomeIndexVM
        {
            Aims = aims
        };
        
        return View(model);
    }
}