using System.ComponentModel.DataAnnotations;

namespace EmpMngSystem.Models
{
    public class UserAccount
    {
        [Key]
        public int EmpID { get; set; }

        [Required(ErrorMessage = "Firstname is required.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        public string? Username { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "PhoneNumber is required.")]
        public int PhoneNumber { get; set; }
    }
}
