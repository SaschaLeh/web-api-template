using Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = new Guid("de6764bf-3490-4ce0-ac06-dd6d9345b52b"),
                    Name = "John Doe",
                    Age = 16,
                },
                 new Student
                 {
                     Id = new Guid("b1fd6091-bad7-4cf0-bbdd-65a77dfcb8b7"),
                     Name = "Jane Doe",
                     Age = 17,
                 }
                ); 
        }
    }
}
