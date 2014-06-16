using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SudokuWeb.Controllers
{
	public class HomeController : Controller
	{
		private static SudokuBasic.Spel sb = new SudokuBasic.Spel();

		public ActionResult Index(string btn)
		{
			if (btn == "Hint")
				sb.Hint();
			else if (Request.QueryString.Count == 3)
			{
				int x, y, value;

				int.TryParse(Request.QueryString.Get("x"),		out x);
				int.TryParse(Request.QueryString.Get("y"),		out y);
				int.TryParse(Request.QueryString.Get("value"),	out value);

				sb.Vakken[x, y].Value = value;

				if (sb.IsFinished())
				{
					sb.Initialize(); // Reset het spel voor de volgende keer
					Response.RedirectPermanent("/Home/Finished");
				}
			}

			return View(sb);
		}

		public ActionResult Finished()
		{
			return View();
		}

	}
}