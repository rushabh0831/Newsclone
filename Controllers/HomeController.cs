using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newsclone.Models;

namespace Newsclone.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsService _newsService;

        public HomeController(NewsService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IActionResult> Index()
        {
            var news = await _newsService.GetTopHeadlinesAsync();
            return View(news.Articles);
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
        public async Task<IActionResult> Buss()
        {
            var news = await _newsService.GetBussHeadlinesAsync();
            return View(news.Articles);
        }
        public async Task<IActionResult> Tech()
        {
            var news = await _newsService.GetTechHeadlinesAsync();
            return View(news.Articles);
        }

    }

}

