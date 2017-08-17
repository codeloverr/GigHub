using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class FolloweeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FolloweeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Following()
        {
            var userId = User.Identity.GetUserId();

            var artists = _context.Followings
                .Where(a => a.FollowerId == userId)
                .Select(a => a.Followee)
                .ToList();

            return View(artists);
        }
    }
}