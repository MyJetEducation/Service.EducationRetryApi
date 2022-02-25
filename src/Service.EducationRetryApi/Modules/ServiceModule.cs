using Autofac;
using Microsoft.Extensions.Logging;
using Service.EducationRetry.Client;

namespace Service.EducationRetryApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterEducationRetryClient(Program.Settings.EducationRetryServiceUrl, Program.LogFactory.CreateLogger(typeof(EducationRetryClientFactory)));
		}
	}
}