using Autofac;
using Microsoft.Extensions.Logging;
using Service.EducationRetry.Client;
using Service.UserInfo.Crud.Client;

namespace Service.EducationRetryApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterUserInfoCrudClient(Program.Settings.UserInfoCrudServiceUrl);

			builder.RegisterEducationRetryClient(Program.Settings.EducationRetryServiceUrl, Program.LogFactory.CreateLogger(typeof(EducationRetryClientFactory)));
		}
	}
}