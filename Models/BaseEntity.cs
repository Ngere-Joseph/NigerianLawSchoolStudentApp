using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NigerianLawSchoolStudentApp.Models
{
	public class BaseEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Int64 Id { get; set; }
		public DateTime AddedDate { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
