using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewToController.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string CourseOne { get; set; }
        public string CourseTwo { get; set; }
        public string CourseThree { get; set; }
    }
}