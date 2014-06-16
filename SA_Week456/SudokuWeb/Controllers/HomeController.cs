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
			try 
			{
				if (Request.QueryString.Count == 1)
				{
					switch (Request.QueryString.Get("button"))
					{
						case "Hint":
							sb.Hint();
						break;

						case "Load":
							sb.Load();
						break;
						
						case "Save":
							sb.Save();
						break;
					}
				}
				else if (Request.QueryString.Count == 3)
				{
					int x, y, value;

					int.TryParse(Request.QueryString.Get("x"),		out x);
					int.TryParse(Request.QueryString.Get("y"),		out y);
					int.TryParse(Request.QueryString.Get("value"),	out value);

					sb.Vakken[x, y].Value = value;

				}
				
				if (GameIsFinished())
				{
					sb.Initialize();

					return View("Finished");
				}
			}
			catch (Exception ex)
			{
				return View("Exception", ex);
			}

			return View(sb);
		}

		private bool GameIsFinished()
		{
			for (int x = 0; x < 9; x++)
			{
				for (int y = 0; y < 9; y++)
				{
					if (sb.GetVak(x, y).Value == 0)
						return false;
				}
			}
			// Er zijn geen lege plekken meer
			return sb.IsFinished();
		}

	}
}