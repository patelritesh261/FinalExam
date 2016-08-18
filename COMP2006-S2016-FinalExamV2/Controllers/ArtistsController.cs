using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV2.Models;
/**
 * Authors:  Ritesh Patel
 * Srudent ID : 200307232
 * Date : Aug 18 2016
 * Name: Artists Controller
 * Description: This controller call list view of artists.
 */
namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class ArtistsController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Artists
        public async Task<ActionResult> Index()
        {
            return View(await db.Artists.ToListAsync());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
