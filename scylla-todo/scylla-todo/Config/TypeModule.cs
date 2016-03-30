
using Autofac;
using Autofac.Core;
using Scylla_TODO.Controllers;
using Scylla_TODO.Repositories;
using Scylla_TODO.Services;

namespace Scylla_TODO.Config
{
	public class TypeModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			RegisterRepositories(builder);

			RegisterServices(builder);

			RegisterControllers(builder);
		}

		protected virtual void RegisterRepositories(ContainerBuilder builder)
		{
			builder.RegisterType<ToDoRepository>().As<IToDoRepository>().InstancePerRequest();
		}

		protected virtual void RegisterServices(ContainerBuilder builder)
		{
			builder.RegisterType<ToDoService>().As<IToDoService>().InstancePerRequest();
		}

		protected virtual void RegisterControllers(ContainerBuilder builder)
		{
			builder.RegisterType<ToDoController>().InstancePerRequest();
		}
	}
}