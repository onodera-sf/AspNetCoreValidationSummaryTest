using System;
using System.ComponentModel.DataAnnotations;

namespace ValidationSummaryTest.Models
{
	public class UserViewModel
	{
		[Required]
		[StringLength(20)]
		public string ID { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(50)]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[Range(0, 150)]
		public int Age { get; set; }
		
		[Required]
		[EnumDataType(typeof(GenderType))]
		public GenderType Gender { get; set; }
		
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		
		[Required]
		[DataType(DataType.Date)]
		public DateTime Birthday { get; set; }
		
		[StringLength(200)]
		[DataType(DataType.MultilineText)]
		public string Comment { get; set; }
		
		[Required]
		public bool IsAccepted { get; set; }
	}
}
