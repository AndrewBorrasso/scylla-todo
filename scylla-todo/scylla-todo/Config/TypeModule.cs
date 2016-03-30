using System;
using System.Diagnostics;
using Autofac;
using Cassandra;
using Cassandra.Mapping;
using Scylla_TODO.Controllers;
using Scylla_TODO.Repositories;
using Scylla_TODO.Services;

namespace Scylla_TODO.Config
{
	public class TypeModule : Module
	{
		private static readonly string NODE_ADDRESS = "node address";
		private static readonly string KEYSPACE = "keyspace";

		protected override void Load(ContainerBuilder builder)
		{
			RegisterRepositories(builder);
			
			RegisterServices(builder);

			RegisterControllers(builder);

			RegisterCassandraSession(builder);
		}

		protected virtual void RegisterCassandraSession(ContainerBuilder builder)
		{
			try
			{
				MappingConfiguration.Global.Define<Mappings>();
				
				ConfigureCassandraDriverDiagnostics();

				var cluster = Cluster.Builder().AddContactPoint(NODE_ADDRESS).Build();
				var session = cluster.Connect(KEYSPACE);
				
				builder
					.RegisterInstance(session)
					.As<ISession>()
					.SingleInstance()
					.OnRelease(sesh =>
					{
						sesh.Dispose();
						cluster.Dispose();
					});
			}
			catch (Exception)
			{
				return;
			}
		}

		private static void ConfigureCassandraDriverDiagnostics()
		{
			Diagnostics.CassandraPerformanceCountersEnabled = true;
			Diagnostics.CassandraStackTraceIncluded = true;
			Diagnostics.CassandraTraceSwitch.Level = TraceLevel.Verbose;
			Trace.Listeners.Add(new ConsoleTraceListener());
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