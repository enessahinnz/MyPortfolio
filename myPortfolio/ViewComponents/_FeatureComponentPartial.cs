using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;

namespace myPortfolio.ViewComponents
{
	public class _FeatureComponentPartial : ViewComponent
	{
		MyPortFolioContext portfolioContext = new MyPortFolioContext();

		public IViewComponentResult Invoke()
		{

			var values = portfolioContext.Features.ToList();
			return View(values);

		}
	}
}
