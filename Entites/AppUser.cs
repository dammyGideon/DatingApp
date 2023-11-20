using System.ComponentModel.DataAnnotations;

namespace API.Entites
{
    public class AppUser
    {
        [Key]
        public int Id {get;set;}
        public string UserName {get;set;}
        public string LastName {get;set;}
    }
}