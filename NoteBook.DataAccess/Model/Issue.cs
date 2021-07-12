using System;

namespace NoteBook.DataAccess.Model
{
    public class Issue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Note { get; set; }

        public int TypeId { get; set; }
        public IssueType Type { get; set; }

        public IssueStatus Status { get; set; }

        public override string ToString() =>
            $"ID {Id} Name {Name} DateStart {DateStart} DateEnd {DateEnd} Note {Note} TypeId {TypeId} Status {Status}";
    }
}
