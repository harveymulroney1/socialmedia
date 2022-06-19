using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SocialMedia_Testing.Models
{
    public class Users
    {
        [Key]
        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
