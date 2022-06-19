using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia_Testing
{
    public class User 
    {
        private string _Name;
        private DateTime _DOB;
        private string _EmailAddress;
        public string Name { get => _Name; set => _Name = value; }
        public string EmailAddress { get => _EmailAddress; set => _EmailAddress = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public List<User> ListUsers = new List<User>();
        public List<User> Followers = new List<User>();
        public void UserInfo(string Name, string EmailAddress, DateTime DOB)
        {
            _Name = Name;
            _EmailAddress = EmailAddress;
            _DOB = DOB;
        }

        //public static void Login()
        //{
        //    Console.Write("Enter username: ");

            
        //}
        //public static void CreateUser(User User,string Name, DateTime DOB, string EmailAddress)
        //{
            
        //    Console.Write("Enter your username: ");
        //    User.Name = Console.ReadLine();
        //    System.Threading.Thread.Sleep(100);
        //    Console.Write("Enter your DOB: (MM/DD/YYYY)");
        //    User.DOB = DateTime.Parse(Console.ReadLine());
        //    System.Threading.Thread.Sleep(100);
        //    Console.Write("Enter your email address");
        //    User.EmailAddress = Console.ReadLine();
        //    System.Threading.Thread.Sleep(100);

        //    Console.Write(User._Name);
        //}
    }
}
