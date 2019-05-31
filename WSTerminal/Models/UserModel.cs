using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSTerminal.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public int Money { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}