using System.ComponentModel.DataAnnotations;
using Service.Core.Client.Education;

namespace Service.EducationRetryApi.Models
{
	public class UseRetryRequest
	{
		[Required]
		public EducationTutorial Tutorial { get; set; }

		[Required]
		public int Unit { get; set; }

		[Required]
		public int Task { get; set; }
	}
}