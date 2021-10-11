using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required] //ako negdje koristim ovaj model moram popuniti ovaj podatak
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}