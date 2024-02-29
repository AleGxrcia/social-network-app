using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Core.Application.ViewModels.User
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Debe colocar el correo del usuario")]
        [Display(Name = "Correo electronico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe tener un token")]
        [DataType(DataType.Text)]
        public string Token { get; set; }

        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coinciden")]
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Confirmar contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
