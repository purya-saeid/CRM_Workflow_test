using System.Diagnostics;
using CRM_Workflow_test.Models;
using CRM_Workflow_test.Services;
using CRM_Workflow_test.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Workflow_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly userServices _userServices;
        private readonly WFServices _wfServices;

        public HomeController(ILogger<HomeController> logger, userServices userServices, WFServices wFServices)
        {
            _logger = logger;
            _userServices = userServices;
            _wfServices = wFServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ViewData()
        {
            var user = new user
            {
                Name = "user3"
            };
            //_userServices.addUser(user);

            var task = new task
            {
                Name = "task6",
                isHead = false,
            };
            //_wfServices.addTask(task);

            var taskTransitoin = new taskTransition
            {
                taskId = 6,
                childId = 8,
                condition = "complete"
            };
            //_wfServices.AddTaskTransition(taskTransitoin);

            var viewModel = new homeViewModel
            {
                Users = await _userServices.getAllUsers(),
                Tasks = await _wfServices.getAllTasks(),
                TasksTransitions = await _wfServices.getAllTaskTransitions()
            };



            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
