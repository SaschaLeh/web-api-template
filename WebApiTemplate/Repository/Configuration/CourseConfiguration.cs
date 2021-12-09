using Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                new Course
                {
                    Id = new Guid("a9e69332-e9b6-4ff5-aeaa-c65a40189fc1"),
                    Title = "Math Part 1",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr."
                },
                new Course
                {
                    Id = new Guid("01725814-8660-4493-b42b-b90082b45c88"),
                    Title = "Programming 1",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam."
                }

                ) ; 
        }
    }
}
