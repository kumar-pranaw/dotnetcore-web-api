using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatingAppRepository.DataModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string KnownAs { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string UserDescription { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsEmailVerified { get; set; }
    }
}
