using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NoteBook.Model;

namespace NoteBook
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private IssueType issueType;

        public IssueType IssueType
        {
            get
            {
                return issueType;
            }
            set
            {
                issueType = value;
                OnPropertyChanged("IssueType");
            }
        }
        public ObservableCollection<IssueType> issueTypes { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
