using System;
namespace JSON_Web_Token.Models
{
	public class UserDto
	{
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}

