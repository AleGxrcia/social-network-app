using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SocialNetwork.Core.Application.ViewModels.User
{
    public class SaveUserViewModel
    {
        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Nombre")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Apellido")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Nombre de usuario")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "La {0} es requerida")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coinciden")]
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Confirmar contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Correo electronico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Telefono")]
        public string Phone { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Foto de perfil")]
        public IFormFile? File { get; set; }
        public string? ProfilePicture { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
