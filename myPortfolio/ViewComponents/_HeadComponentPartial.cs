using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
	public class _HeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();

		}
	}
}
