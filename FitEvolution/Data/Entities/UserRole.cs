using Google.Apis.Admin.Directory.directory_v1.Data;
using System.ComponentModel.DataAnnotations;

namespace FitEvolution.Data.Entities
{
    public enum UserRole
    {
        Admin,
        Instructor,
        User

    }

    public class User
    {
        public int Id { get; set; }

        //[Display(Username = "email")]
        //[Display(Password = "Palavra-passe")]
        //[MaxLength(50, ErrorMessage = "O campo {0} deve ter o máximo {1} caractéres.")]
        //[Required(ErrorMessage = " O campo {0} é obrigatório.")]
        public string? Username { get; set; }
        public  string? Password { get; set; }
        public UserRole Role { get; set; }
    }


}
