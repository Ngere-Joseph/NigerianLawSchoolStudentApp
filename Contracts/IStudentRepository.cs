
using NigerianLawSchoolStudentApp.Models;
using System.Collections.Generic;

namespace NigerianLawSchoolStudentApp.Contracts
{
	public interface IStudentRepository
    {
        void SaveStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(long id);
        void UpdateStudent(Student student);
    }
}
