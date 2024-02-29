using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Core.Application.ViewModels.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Debe ingresar un nombre de usuario")]
        [Display(Name = "Nombre de usuario")]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
