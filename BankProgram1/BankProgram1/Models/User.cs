using System;

namespace bankProgram.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string userName { get; set; }    
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string emailAddress { get; set; }
    }
}
