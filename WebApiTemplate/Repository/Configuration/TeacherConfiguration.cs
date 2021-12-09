using Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(
                    new Teacher
                    {
                        Id = new Guid("46a47703-8405-459a-95a3-dae276e0eb46"),
                        Name = "Hans Georg",
                        CourseId = new Guid("a9e69332-e9b6-4ff5-aeaa-c65a40189fc1")
                    },
                    new Teacher
                    {
                        Id = new Guid("fdffc1b3-da38-4cc6-b946-f9f2a98e6e6a"),
                        Name = "Hans Georg",
                        CourseId = new Guid("01725814-8660-4493-b42b-b90082b45c88")
                    }
                ); 
        }
    }
}
