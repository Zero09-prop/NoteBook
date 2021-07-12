using System;
using System.Drawing;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ApplicationContext())
            {
                User user = new User
                {
                    Name = "Misha",
                    Color = Art.White
                };
                ctx.Add(user);
                ctx.SaveChanges();

                var users = ctx.Users;
                foreach (var usr in users)
                {
                    Console.WriteLine($"Name: {usr.Name} Color: {usr.Color} Id: {usr.Id}");
                }
            }
        }
    }
}
