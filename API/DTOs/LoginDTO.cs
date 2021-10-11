using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    //sve dto klase odgovaraju modelima koji se vracaju korisniku u apiju (postman)
    public class LoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}