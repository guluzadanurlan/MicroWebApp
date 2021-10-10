using System.ComponentModel.DataAnnotations;

namespace MicroWebApp.Models
{
    public class RegisterModel
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Password{get;set;}
       public string UserName { get; set; }
       
       [Required] 
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}