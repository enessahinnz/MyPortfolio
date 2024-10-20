using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
	public class _ContactConponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
