using NigerianLawSchoolStudentApp.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace NigerianLawSchoolStudentApp.Models
{
	public class Student : BaseEntity
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string EnrollmentNo { get; set; }
        [Required]
        public string SchoolAttended { get; set; }
        [Required]
        public DateTime GradYear { get; set; }
        public string Sex { get; set; }
    }
}
