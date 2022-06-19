using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_science_social_media_project_8_june
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            var User = new User();
            var Name = "";
            var DOB = new DateTime();
            var EmailAddress ="";

            Console.WriteLine("Welcome to --- Social Media Network \n What's Next: 1.Login | 2. Register | 3.Quit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    User.Login();
                    break;
                case 2:
                    User.CreateUser(User,Name,DOB,EmailAddress);    
                    break;
                default:
                    break;
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    }
}
