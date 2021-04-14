using System;

namespace DatingAppWebApi.DatingAppDto
{
    public class RegisterUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
