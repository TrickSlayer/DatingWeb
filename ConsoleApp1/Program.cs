using API.Data;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hmac = new HMACSHA512();
            byte[] a = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaas"));
            foreach (byte i in a){
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(a);
            byte[] b = hmac.Key;
            foreach (byte i in b)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(b);
            Console.WriteLine("\n\n\n\n");
            try
            {
                AppUser user = new AppUser()
                {
                    PasswordHash = a,
                    PasswordSalt = b
                };
                var context = new DatingAppContext();
                context.AppUsers.Add(user);
                context.SaveChanges();
            } catch (Exception e){ Console.WriteLine(e); }
            

        }
    }
}
