using System;
using System.ComponentModel.DataAnnotations;
namespace DatingApp1.DTOs
{
	public class RegisterDto
	{
		[Required]
			public string? Username { get; set; }
		
		[Required]
			public string? Password { get; set; }
	}
}

