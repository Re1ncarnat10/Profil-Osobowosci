using Microsoft.AspNetCore.Identity;
namespace Profil_Osobowosci.Models;

public class User:IdentityUser
{
    public string Name { get; set; }
    public User(string name)
    {
        Name = name;
    }

    public User()
    {
    }
}
