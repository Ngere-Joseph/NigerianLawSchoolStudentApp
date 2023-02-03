using System;
using System.ComponentModel.DataAnnotations;

namespace NigerianLawSchoolStudentApp.DTO
{
	public class StudentViewModel
	{
		public Int64 Id { get; set; }
		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Required]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Required]
		[Display(Name = "Enrollment No")]
		public string EnrollmentNo { get; set; }
        [Required]
        [Display(Name = "Previous School Attended")]
        public string SchoolAttended { get; set; }
        [Required]
        [Display(Name = "Year Of Graduation")]
        public DateTime GradYear { get; set; }
		public int Year { get; set; }
		[Required]
        [Display(Name = "Sex")]
        public string Sex { get; set; }
    }
}
