using Microsoft.AspNetCore.Mvc;
using SoftUniTwitter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Twitter.Data;

namespace SoftUniTwitter.Controllers
{
    public class TweetsController:Controller
    {
        ApplicationDbContext db;

        public TweetsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Create(string Text)
        {
            return View();
        }

        public IActionResult SaveToDatabase(string text)
        {
            var tweet = new Tweet();
            tweet.Text = text;
            tweet.CreatedOn = DateTime.Now;
            tweet.UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            db.Tweets.Add(tweet);
            db.SaveChanges();

            return Redirect("/");
        }
    }
}
