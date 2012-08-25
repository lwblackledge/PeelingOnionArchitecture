﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PeelingOnionArchitecture.UI.Framework;

namespace PeelingOnionArchitecture.UI
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			DependencyResolver.SetResolver( new IoCDependencyResolver() );
			GlobalConfiguration.Configuration.DependencyResolver = DependencyResolver.Current.ToServiceResolver();

			WebApiConfig.Register( GlobalConfiguration.Configuration );
			FilterConfig.RegisterGlobalFilters( GlobalFilters.Filters );
			RouteConfig.RegisterRoutes( RouteTable.Routes );
			BundleConfig.RegisterBundles( BundleTable.Bundles );
		}
	}
}