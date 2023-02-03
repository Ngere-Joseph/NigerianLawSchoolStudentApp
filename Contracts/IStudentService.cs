
using NigerianLawSchoolStudentApp.DTO;
using NigerianLawSchoolStudentApp.Models;
using System.Collections.Generic;

namespace NigerianLawSchoolStudentApp.Contracts
{
	public interface IStudentService
	{
		void SaveStudent(StudentViewModel student);
		IEnumerable<StudentViewModel> GetAllStudents();
		Student GetStudent(long id);
		void UpdateStudent(StudentViewModel student, long? id);
	}
}
