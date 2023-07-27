using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_ToDoList.Areas.Identity.Data;
using web_ToDoList.Data;
using web_ToDoList.Models;

namespace web_ToDoList.Controllers
{
	[Authorize]
	public class AppController : Controller
	{
		private readonly web_ToDoListDbContext dbContext;
		private readonly UserManager<ApplicationUser> userManager;

        public AppController(web_ToDoListDbContext dbContext, UserManager<ApplicationUser> userManager)
		{
			this.dbContext = dbContext;
			this.userManager = userManager;
		}

        public IActionResult Index()
		{
			ApplicationUser currentUser = userManager.GetUserAsync(User).Result;
			string nickName = currentUser.NickName;
			ViewBag.NickName = nickName;
			return View();
		}

		public IActionResult Today()
		{
            ApplicationUser currentUser = userManager.GetUserAsync(User).Result;
            string nickName = currentUser.NickName;
            ViewBag.NickName = nickName;
            return View();
        }

		public IActionResult Yesterday()
		{
            ApplicationUser currentUser = userManager.GetUserAsync(User).Result;
            string nickName = currentUser.NickName;
            ViewBag.NickName = nickName;
            return View();
		}

		public IActionResult Upcoming()
		{
            ApplicationUser currentUser = userManager.GetUserAsync(User).Result;
            string nickName = currentUser.NickName;
            ViewBag.NickName = nickName;
            return View();
		}

        public IActionResult SideBar()
		{
			return PartialView();
		}
		
		public IActionResult Login()
		{
			return PartialView();
		}
	}
}
