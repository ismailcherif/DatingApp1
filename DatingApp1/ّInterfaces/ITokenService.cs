using System;
using DatingApp1.Entities;
namespace DatingApp1.Interfaces
{
	public interface ITokenService
	{
		string CreateToken(AppUser user);
	}
}

