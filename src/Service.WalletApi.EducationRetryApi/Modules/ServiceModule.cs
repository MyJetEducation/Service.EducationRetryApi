using Autofac;
using Microsoft.Extensions.Logging;
using MyJetWallet.ApiSecurityManager.Autofac;
using MyJetWallet.Sdk.RestApiTrace;
using Service.EducationRetry.Client;

namespace Service.WalletApi.EducationRetryApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterEncryptionServiceClient();

			builder.RegisterEducationRetryClient(Program.Settings.EducationRetryServiceUrl, Program.LoggerFactory.CreateLogger(typeof (EducationRetryClientFactory)));

			if (Program.Settings.EnableApiTrace)
			{
				builder
					.RegisterInstance(new ApiTraceManager(Program.Settings.ElkLogs, "api-trace",
						Program.LoggerFactory.CreateLogger("ApiTraceManager")))
					.As<IApiTraceManager>()
					.As<IStartable>()
					.AutoActivate()
					.SingleInstance();
			}
		}
	}
}