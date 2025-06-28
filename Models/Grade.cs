namespace LAB12_REYES.Models
{
    public class Grade
    {
        public int GradeID { get; set; }

        public string HOName { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; } = false;

        public List<Student> Students { get; set; }
    }
}
