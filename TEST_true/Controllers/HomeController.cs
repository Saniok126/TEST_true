using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TEST_true.Models;
using TEST_true.Services;

namespace TEST_true.Controllers
{
    public class HomeController : Controller
    {
        Database db;
        IFind posts;
        public HomeController(Database context, IFind iwith)
        {
            db = context;
            posts = iwith;
        }
        public IActionResult Index()        // С комментами
        {
           
            var commented = posts.GetCommentPosts();
            return View(commented);    
            
        }
        

        public IActionResult About()    //без комментариев
        {
            var no_comments_posts = posts.GetNoCommentPosts();
            return View(posts.GetNoCommentPosts());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
