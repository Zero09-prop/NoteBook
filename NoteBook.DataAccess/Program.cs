using System;
using NoteBook.DataAccess.Repository;

namespace NoteBook.DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var issue = new IssueRepo())
            {
                foreach (var iss in issue.GetAll())
                {
                    Console.WriteLine(iss);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
