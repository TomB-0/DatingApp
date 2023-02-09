using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string KnownAs { get; set; }
         [Required]
        public string Gender { get; set; }
         [Required]
        public DateOnly? DateOfBirth { get; set; } //optinal to make required work(DateOnly cannot be null, so for required tag we need to make it optional)
         [Required]
        public string City { get; set; }
         [Required]
        public string Country { get; set; }

        [StringLength(8, MinimumLength = 4)]
        [Required]
        public string Password { get; set; }
    }
}