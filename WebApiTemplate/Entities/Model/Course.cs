using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Model
{
    public class Course
    {
        [Column("CourseId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Course Title is required field.")]
        [MaxLength(60, ErrorMessage="Maximum length of Title is 60 charactrers.")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ICollection<Student>? Students { get; set; }

        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

    }
}
