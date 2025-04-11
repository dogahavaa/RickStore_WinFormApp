using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickStock_WindowsFormApp.Models
{
    public class Manager
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 20, ErrorMessage = "Bu alan 20 karakterden uzun olamaz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 20, ErrorMessage = "Bu alan 20 karakterden uzun olamaz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 20, ErrorMessage = "Bu alan 20 karakterden uzun olamaz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 12, MinimumLength = 4 , ErrorMessage = "Şifreniz 4 ile 12 karakter arasında olmalıdır.")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan 20 karakterden uzun olamaz.")]
        public string Email{ get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
