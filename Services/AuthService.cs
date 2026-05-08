using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginNexus.Models;

namespace LoginNexus.Services
{
     public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { Email = "daniel@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Arnaldo" },
        new User { Email = "joao@nexus.edu", Password = "123", Role = "Student", Name = "Estudante 01" }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}