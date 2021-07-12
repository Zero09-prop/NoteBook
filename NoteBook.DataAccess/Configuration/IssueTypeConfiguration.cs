using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteBook.DataAccess.Model;

namespace NoteBook.DataAccess.Configuration
{
    public class IssueTypeConfiguration : IEntityTypeConfiguration<IssueType>
    {
        public void Configure(EntityTypeBuilder<IssueType> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasData(
                new[]
                {
                    new IssueType {Id = 1, Name = "Famous", Color = MyColor.Aqua},
                    new IssueType {Id = 2, Name = "Interest", Color = MyColor.BlueViolet}
                });
        }
    }
}
