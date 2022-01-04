using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class User
        {
            [Key]
            public int UserId { get; set; }

            [Required]
            [MinLength(2)]
            public string FirstName {get; set;}

            [Required]
            [MinLength(2)]
            public string LastName {get; set;}


            [Required]
            [EmailAddress]
            public string Email {get; set;}

            [Required]
            [DataType(DataType.Password)]
            [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
            public string Password {get; set;}
                // Will not be mapped to your users table!
            [NotMapped]
            [Compare("Password")]
            [DataType(DataType.Password)]
            public string Confirm {get;set;}       

        }
}