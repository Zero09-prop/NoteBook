using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteBook.DataAccess.Model;

namespace NoteBook.DataAccess.Configuration
{
    public class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasData(
                new[]
                {
                    new Issue{Id = 1,Name="Работа",DateStart = DateTime.Now,DateEnd = DateTime.MaxValue,Note = "dfdjflkj",TypeId = 2,Status = IssueStatus.Waited},
                    new Issue{Id=2,Name = "lion",TypeId = 1}, 
                });
        }
    }
}
