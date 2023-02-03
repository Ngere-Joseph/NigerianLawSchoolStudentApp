using Microsoft.EntityFrameworkCore;
using NigerianLawSchoolStudentApp.Models;

namespace NigerianLawSchoolStudentApp.Models
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Student> Students { get; set; }
	}
}
