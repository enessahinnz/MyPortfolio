using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;

namespace myPortfolio.ViewComponents
{
	public class _ExperinceComponentPartial : ViewComponent
	{
		MyPortFolioContext experinceContext = new MyPortFolioContext();
		public IViewComponentResult Invoke()
		{
			var values = experinceContext.Experiences.ToList();
			return View(values);
		}
	}
}
