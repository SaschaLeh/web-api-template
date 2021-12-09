using Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class CourseStudentConfiguration : IEntityTypeConfiguration<CourseStudent>
    {
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            builder.HasData(
                new CourseStudent
                {
                    CoursesId = new Guid("a9e69332-e9b6-4ff5-aeaa-c65a40189fc1"),
                    StudentsId = new Guid("de6764bf-3490-4ce0-ac06-dd6d9345b52b")
                },
                new CourseStudent
                {
                    CoursesId = new Guid("01725814-8660-4493-b42b-b90082b45c88"),
                    StudentsId = new Guid("de6764bf-3490-4ce0-ac06-dd6d9345b52b")
                },
                new CourseStudent
                {
                    CoursesId = new Guid("01725814-8660-4493-b42b-b90082b45c88"),
                    StudentsId = new Guid("b1fd6091-bad7-4cf0-bbdd-65a77dfcb8b7")
                }
                );
        }
    }
}
