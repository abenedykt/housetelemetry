using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using HouseTelemetry.Abstract;
using HouseTelemetry.Core;

namespace HouseTelemetry
{
	public class AutofacConfig
	{
		public static void Register()
		{
			var builder = new ContainerBuilder();
			builder.RegisterControllers(typeof(Global).Assembly);
			builder.RegisterType<HouseTelemetryApp>().As<IHouseTelemetry>();


			var container = builder.Build();

			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


		}
	}
}