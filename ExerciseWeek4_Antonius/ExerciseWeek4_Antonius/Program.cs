using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseWeek4_Antonius
{
    class Hash
    {
        public static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(14);
        }
        public static string HasPassword(string Password)
        {
            return BCrypt.Net.BCrypt.HashPassword(Password, GetRandomSalt());
        }
        //public static bool HasValidatePassword(string password, string correcthash)
        //{
        //    return BCrypt.Net.BCrypt.Verify(password, correcthash);
        //}
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Masukan nama anda : ");
            string name = Console.ReadLine();
            Console.Write("Masukan password anda : ");
            string password = Console.ReadLine();
            string hash = Hash.HasPassword(password);
            Console.Write("Halo " + name);
            Console.WriteLine();
            Console.Write("Ini Password Anda Setelah Di Hashing " + "'" + hash + "'");
            Console.ReadKey();
        }
    }
}
