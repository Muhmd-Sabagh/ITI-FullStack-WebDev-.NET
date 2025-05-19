﻿using System.ComponentModel.DataAnnotations;

namespace MyMVCWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int Degree { get; set; }

        public int MinDegree { get; set; }

        public int Hours { get; set; }

        public int DeptId { get; set; }

        public virtual Department Department { get; set; }

        public virtual List<Instructor> Instructors { get; set; } = new List<Instructor>();

        public virtual List<CrsResult> CrsResults { get; set; } = new List<CrsResult>();
    }
}
