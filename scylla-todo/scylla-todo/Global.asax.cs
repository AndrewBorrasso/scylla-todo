using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
			ConfigureFormatters();
			ConfigureDependencyInjectionContainer();
		}

		private static void ConfigureFormatters()
		{
			var appXmlType = GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
			GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
		}

		[SuppressMessage("ReSharper", "RedundantArgumentNameForLiteralExpression")]
		[SuppressMessage("ReSharper", "RedundantArgumentName")]
		private static void ConfigureRouteMapping()
		{
			GlobalConfiguration.Configuration.Routes
				.MapHttpRoute(
					name: "Default",
					routeTemplate: "api/{controller}/{id}",
					defaults: new {id = RouteParameter.Optional});
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