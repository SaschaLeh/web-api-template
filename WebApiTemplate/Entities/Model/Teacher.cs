using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Model
{
    public class Teacher
    {
        [Column("TeacherId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Teacher name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum lengt for the Name is 30 characters.")]
        public string? Name { get; set; }

        [ForeignKey(nameof(Course))]
        public Guid CourseId{ get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
