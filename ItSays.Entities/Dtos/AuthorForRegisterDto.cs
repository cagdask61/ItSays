using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Entities.Dtos
{
    public class AuthorForRegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
