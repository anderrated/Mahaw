using System;
using System.ComponentModel.DataAnnotations;

namespace MahawMedicineAPI.Models;

// User models

public class User
{
    public int Id { get; set; }

    [Required, StringLength(50)]
    public required string Email { get; set; }

    [Required]
    public required string Password { get; set; } 

    [Required]
    public string Role { get; set; } = "User"; // Set default role as "User"
}
