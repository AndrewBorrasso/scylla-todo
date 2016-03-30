using System;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Scylla_TODO.Config;

namespace Scylla_TODO
{
	public class Global : HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			ConfigureRouteMapping();

			ConfigureDependencyInjectionContainer();
		}

		private static void ConfigureRouteMapping()
		{
			GlobalConfiguration.Configuration.Routes
				.MapHttpRoute("Default", "{controller}/{id}", new {id = RouteParameter.Optional});
		}

		private static void ConfigureDependencyInjectionContainer()
		{
			var container = new ContainerBuilder();
			container.RegisterModule<TypeModule>();
			container.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);
			GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container.Build());
		}
		
		protected void Session_Start(object sender, EventArgs e)
		{
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{
		}

		protected void Application_Error(object sender, EventArgs e)
		{
		}

		protected void Session_End(object sender, EventArgs e)
		{
		}

		protected void Application_End(object sender, EventArgs e)
		{
		}
	}
}