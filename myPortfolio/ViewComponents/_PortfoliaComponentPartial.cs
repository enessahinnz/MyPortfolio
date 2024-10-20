using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
	public class _PortfoliaComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
