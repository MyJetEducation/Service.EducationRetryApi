using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationRetryApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationRetryApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationRetryApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationRetryApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationRetryApi.EnableApiTrace")]
		public bool EnableApiTrace { get; set; }

		[YamlProperty("EducationRetryApi.MyNoSqlReaderHostPort")]
		public string MyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationRetryApi.AuthMyNoSqlReaderHostPort")]
		public string AuthMyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationRetryApi.SessionEncryptionKeyId")]
		public string SessionEncryptionKeyId { get; set; }

		[YamlProperty("EducationRetryApi.MyNoSqlWriterUrl")]
		public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationRetryApi.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }
	}
}