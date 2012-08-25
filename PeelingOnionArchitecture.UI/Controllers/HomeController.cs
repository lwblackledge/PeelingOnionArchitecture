using System.Web.Mvc;
using PeelingOnionArchitecture.Core.Repositories;
using PeelingOnionArchitecture.Core.Services;

namespace PeelingOnionArchitecture.UI.Controllers
{
	public class HomeController : Controller
	{
		private readonly IOnionRepository _onionRepository;
		private readonly IOnionStockerService _onionStocker;

		public HomeController( 
			IOnionRepository onionRepository, 
			IOnionStockerService onionStocker )
		{
			_onionRepository = onionRepository;
			_onionStocker = onionStocker;
		}

		//
		// GET: /Home/

		public ActionResult Index()
		{
			return View( _onionStocker.GetStores() );
		}

	}
}
