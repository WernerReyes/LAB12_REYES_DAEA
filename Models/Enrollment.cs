namespace LAB12_REYES.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentIdStudent { get; set; }
        public int CourseIdCourse { get; set; }
        public DateTime Date { get; set; }

        public bool IsDeleted { get; set; } = false;

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
