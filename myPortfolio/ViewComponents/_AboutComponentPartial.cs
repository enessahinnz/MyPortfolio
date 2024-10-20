using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;

namespace myPortfolio.ViewComponents
{
	public class _AboutComponentPartial : ViewComponent
	{
		MyPortFolioContext aboutContext = new MyPortFolioContext();

		public IViewComponentResult Invoke()
		{
			ViewBag.aboutTitle = aboutContext.Abouts.Select(X => X.Title).FirstOrDefault();
			ViewBag.aboutSubDescription = aboutContext.Abouts.Select(X => X.SubDescription).FirstOrDefault();
			ViewBag.aboutDetail = aboutContext.Abouts.Select(X => X.Detail).FirstOrDefault();
			return View();
		}
	}
}
