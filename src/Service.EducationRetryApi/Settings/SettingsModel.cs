using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationRetryApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationRetryApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationRetryApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationRetryApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationRetryApi.JwtAudience")]
		public string JwtAudience { get; set; }

		[YamlProperty("EducationRetryApi.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }
	}
}