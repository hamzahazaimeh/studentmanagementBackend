using System;
using System.Collections.Generic;

namespace StudentManagementSystem.Models
{
    public partial class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string Grade { get; set; }
        public string Image { get; set; }
    }
}
