﻿namespace LAB12_REYES.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Name { get; set; }

        public int Credit { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
