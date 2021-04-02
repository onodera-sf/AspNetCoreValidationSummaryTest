using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ValidationSummaryTest.Models;

namespace ValidationSummaryTest.Controllers
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

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult ValidateNone()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ValidateNone(UserViewModel model)
		{
			if (model.IsAccepted == false)
			{
				ModelState.AddModelError("PropertyName1", "プロパティに依存するエラー (None)");
				ModelState.AddModelError("", "空のキーエラー (None)");
			}
			if (ModelState.IsValid == false) return View(model);
			ViewData["Message"] = "正常に登録しました。";
			return View(model);
		}

		public IActionResult ValidateModelOnly()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ValidateModelOnly(UserViewModel model)
		{
			if (model.IsAccepted == false)
			{
				ModelState.AddModelError("PropertyName1", "プロパティに依存するエラー (ModelOnly)");
				ModelState.AddModelError("", "空のキーエラー (ModelOnly)");
			}
			if (ModelState.IsValid == false) return View(model);
			ViewData["Message"] = "正常に登録しました。";
			return View(model);
		}

		public IActionResult ValidateAll()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ValidateAll(UserViewModel model)
		{
			if (model.IsAccepted == false)
			{
				ModelState.AddModelError("PropertyName1", "プロパティに依存するエラー (All)");
				ModelState.AddModelError("", "空のキーエラー (All)");
			}
			if (ModelState.IsValid == false) return View(model);
			ViewData["Message"] = "正常に登録しました。";
			return View(model);
		}
	}
}
