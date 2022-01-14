using Autofac;
using Service.EducationRetry.Client;
using Service.UserInfo.Crud.Client;

namespace Service.EducationRetryApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterUserInfoCrudClient(Program.Settings.UserInfoCrudServiceUrl);
			builder.RegisterEducationRetryClient(Program.Settings.EducationRetryServiceUrl);
		}
	}
}