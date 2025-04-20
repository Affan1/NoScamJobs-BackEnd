using System.ComponentModel.DataAnnotations;

namespace UserManagementService.Models
{
    public class Users
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        public string EmailConfirmed { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string Address { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string City { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string PostCode { get; set; } = string.Empty;
    }
}
