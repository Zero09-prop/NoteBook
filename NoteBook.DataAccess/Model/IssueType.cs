using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NoteBook.DataAccess.Model
{
    public class IssueType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public MyColor Color { get; set; }

        private ICollection<Issue> Issues { get; set; }

        public override string ToString() => $"ID {Id} Name {Name} Color {Color}";

    }
}
