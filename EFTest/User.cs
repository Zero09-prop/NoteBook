using System.Drawing;

namespace EFTest
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Art Color { get; set; }
    }

    public enum Art
    {
        Aqua,Black,White
    }
}
