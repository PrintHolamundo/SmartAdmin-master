#region Using

using System.Web.Mvc;

#endregion

namespace SmartAdminMvc.Controllers
{
    [Authorize]
    public class GraphsController : Controller
    {
        // GET: graphs/flot
        public ActionResult Flot()
        {
            return View();
        }

        // GET: graphs/morris
        public ActionResult Morris()
        {
            return View();
        }

        // GET: graphs/inline
        public ActionResult Inline()
        {
            return View();
        }

        // GET: graphs/dygraphs
        public ActionResult Dygraphs()
        {
            return View();
        }

        // GET: graphs/chart-js
        public ActionResult ChartJS()
        {
            return View();
        }
    }
}