using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore1.Models
{
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public StudentStatus Status { get; set; }
        public Student()
        {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Gender = Gender.Male;
            this.Status = StudentStatus.Activated;
        }
    }
    public enum Gender
    {
        Male = 1,
        Female = 0,
        Orther = 2
    }
    public enum StudentStatus
    {
        Activated = 1,
        DeActivated = 0
    }
}
