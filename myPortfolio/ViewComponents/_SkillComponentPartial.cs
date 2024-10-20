using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;

namespace myPortfolio.ViewComponents
{
	public class _SkillComponentPartial : ViewComponent
	{

		MyPortFolioContext skillContext = new MyPortFolioContext();
		public IViewComponentResult Invoke()
		{
			var values = skillContext.Skils.ToList();
			return View(values);
		}
	}
}
