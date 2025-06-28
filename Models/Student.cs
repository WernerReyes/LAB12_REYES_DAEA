namespace LAB12_REYES.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public bool IsDeleted { get; set; } = false;

        public Grade Grade { get; set; } 

        public int GradeID { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
