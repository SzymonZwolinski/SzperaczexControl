using Autofac;
using SzperaczexControlCore.Repositories;

namespace SzperaczexControlInfrastructure.IOC
{
	class ServicesModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder.RegisterType<SensorsReadingsService>().As<ISensorsReadingsService>().InstancePerLifetimeScope();
		}
	}
}
