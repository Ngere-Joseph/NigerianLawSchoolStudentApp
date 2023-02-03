using NigerianLawSchoolStudentApp.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using NigerianLawSchoolStudentApp.DTO;
using NigerianLawSchoolStudentApp.Models;
using System.Diagnostics;

namespace NigerianLawSchoolStudentApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _studentService.GetAllStudents();
			return View(nameof(Index), model);
        }

        [HttpGet]
        public IActionResult StudentDetail(long id)
        {
            StudentViewModel model = new StudentViewModel();
 
            Student student = _studentService.GetStudent(id); 
            
            if (student != null)
            {
                model.Id = student.Id;
                model.FirstName = student.FirstName;
                model.LastName = student.LastName;
                model.EnrollmentNo = student.EnrollmentNo;
			    model.Sex = student.Sex;
			    model.SchoolAttended = student.SchoolAttended;
			    model.Year = student.GradYear.Year;

		    }
 
            return PartialView("~/Views/Student/StudentDetail.cshtml", model);
        }

        [HttpGet]
        public IActionResult AddEditStudent(long? id)
        {
            StudentViewModel model = new StudentViewModel();
            if (id.HasValue)
            {
                Student student = _studentService.GetStudent(id.Value); if (student != null)
                {
                    model.Id = student.Id;
                    model.FirstName = student.FirstName;
                    model.LastName = student.LastName;
                    model.EnrollmentNo = student.EnrollmentNo;
                    model.Sex = student.Sex;
                    model.SchoolAttended = student.SchoolAttended;
                    model.GradYear = student.GradYear;

                }
            }
            return PartialView("~/Views/Student/AddEditStudent.cshtml", model);
        }

        [HttpPost]
        public ActionResult AddEditStudent(long? id, StudentViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    if (isNew)
                    {
                        _studentService.SaveStudent(model);
                    }
                    else
                    {
                        _studentService.UpdateStudent(model, id);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
