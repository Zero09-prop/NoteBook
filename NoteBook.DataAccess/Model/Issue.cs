using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NoteBook.DataAccess.Model
{
    public class Issue : INotifyPropertyChanged
    {
        private string _name;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private string _note;
        private int? _typeId;
        private IssueStatus _status;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public DateTime DateStart
        {
            get => _dateStart;
            set
            {
                _dateStart = value;
                OnPropertyChanged("DateStart");
            }
        }

        public DateTime DateEnd
        {
            get => _dateEnd;
            set
            {
                _dateEnd = value;
                OnPropertyChanged("DateEnd");
            }
        }

        public string Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged("Note");
            }
        }

        public int? TypeId { 
            get => _typeId;
            set
            {
                _typeId = value;
                OnPropertyChanged("TypeId");
            }
        }

        public IssueType Type { get; set; }

        public IssueStatus Status { 
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString() =>
            $"ID {Id} Name {Name} DateStart {DateStart} DateEnd {DateEnd} Note {Note} TypeId {TypeId} Status {Status}";
    }
}
