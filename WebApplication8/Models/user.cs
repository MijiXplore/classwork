using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection;

namespace WebApplication8.Models
{
    public class user
    {
        [Required]
        public string? name { get; set; }
        [Required]
        [EmailAddress]
        public string? email { get; set; }
        [Required]
        [PasswordPropertyText]
        public string? password { get; set; }
        [Compare("password", ErrorMessage = "Password doesn't match please type again !")]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public string role { get; set; }

        public enum roles
        {
            admin,
            customer
        }

        public user()
        {

        }

        public user(string name, string email, string password, string role)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
    }
}
/*
Database:
    Table: user
         Fields:
            1. name
            2. email
            3. password
            4. role

user1:
{
    name:  
    email: 
    password: 
    role:  
}

user2:
{
    name:
    email:
    password:
    role:
}

//5 users
object - user1
object - user2
......

class  --> my template
using this template i will be creating multiple objects of users
*/
