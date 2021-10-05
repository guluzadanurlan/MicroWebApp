using Microsoft.AspNetCore.Identity;

namespace MicroWebApp.Identity
{
    public class User: IdentityUser
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }

       public string Password{get;set;}
    }
}