using LAB12_REYES.Data;
using LAB12_REYES.Requests;
using LAB12_REYES.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB12_REYES.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentCustomController : ControllerBase
    {
        private readonly DBContext _context;

        public StudentCustomController(
            DBContext context
            )
        {
            this._context = context;
        }

        [HttpGet]
        public List<StudentResponse> GetStudents(
            [FromQuery] GetStudentsRequest getStudentsRequest
            )
        {
            var students = this._context.Students
                .Where(c =>
                    !c.IsDeleted &&
                    (string.IsNullOrEmpty(getStudentsRequest.Name) || c.FirstName.Contains(getStudentsRequest.Name)) &&
                    (string.IsNullOrEmpty(getStudentsRequest.Lastname) || c.LastName.Contains(getStudentsRequest.Lastname)) &&
                    (string.IsNullOrEmpty(getStudentsRequest.Email) || c.Email.Contains(getStudentsRequest.Email))

                )
                .Select(c => new StudentResponse
                {
                    Email = c.Email,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Phone = c.Phone,
                    StudentID = c.StudentID
                })
                .ToList();

          
            return students.OrderByDescending(e => e.LastName).ToList();
           
        }


        [HttpGet]
        public List<StudentResponse> GetStudentsByNameAndGrade(
           [FromQuery] GetStudentsRequest getStudentsRequest
           )
        {
            var students = this._context.Students
                .Where(c =>
                    !c.IsDeleted &&
                    (string.IsNullOrEmpty(getStudentsRequest.Name) || c.FirstName.Contains(getStudentsRequest.Name)) &&
                    (string.IsNullOrEmpty(getStudentsRequest.GradeName) || c.Grade.HOName.Contains(getStudentsRequest.GradeName)) &&
                   

                )
                .OrderByDescending(c => c.Grade.HOName)
                .Select(c => new StudentResponse
                {
                    Email = c.Email,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Phone = c.Phone,
                    StudentID = c.StudentID
                })
                .ToList();

            return students;

        }

        [HttpGet]
        public List<StudentResponse> GetStudentsByCourseName(
           [FromQuery] GetStudentsRequest getStudentsRequest
           )
        {
            var students = this._context.Students
                .Where(c =>
                    !c.IsDeleted &&
                   // (string.IsNullOrEmpty(getStudentsRequest.CourseName) || c.C.Contains(getStudentsRequest.Name)) &&
                    (string.IsNullOrEmpty(getStudentsRequest.GradeName) || c.Grade.HOName.Contains(getStudentsRequest.GradeName))



                )
                .OrderByDescending(c => c.Grade.HOName)
                .Select(c => new StudentResponse
                {
                    Email = c.Email,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Phone = c.Phone,
                    StudentID = c.StudentID
                })
                .ToList();

            return students;

        }



        [HttpPost]
        public void InsertStudent([FromBody] InsertStudentRequest insertStudentRequest)
        {
            var student = new Models.Student
            {
                FirstName = insertStudentRequest.FirstName,
                LastName = insertStudentRequest.LastName,
                Phone = insertStudentRequest.Phone,
                Email = insertStudentRequest.Email,
                GradeID = insertStudentRequest.GradeID,

            };
            _context.Students.Add(student);
            _context.SaveChanges();
           
        }
    }
}
