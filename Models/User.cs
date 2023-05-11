using System;
namespace JSON_Web_Token.Models
{
	public class User
	{
		public string Username { get; set; } = string.Empty;
		public string PasswordHash { get; set; } = string.Empty;
	}
}

