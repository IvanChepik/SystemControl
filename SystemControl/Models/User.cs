﻿using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User 
    {
        [Key] public int Id { get; set; }
        [Required] public string Login { get; set; }
        [Required] public string Password { get; set; }
    }
}