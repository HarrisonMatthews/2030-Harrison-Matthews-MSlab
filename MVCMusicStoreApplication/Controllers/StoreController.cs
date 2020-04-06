using MVCMusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        MVCMusicStoreDB db = new MVCMusicStoreDB();

        public ActionResult Index(int id)
        {
            var albums = db.Albums.Where(a => a.GenreId == id)
                .ToList();
            return View(albums);
        }
        
        public ActionResult Browse(string genre)
        {
            var genres = db.Genres.ToList();
            return View(genres);
        }

        public ActionResult Details(int? id)
        {
            var album = db.Albums.Find(id);
            return View(album);
        }
    }
}
    
