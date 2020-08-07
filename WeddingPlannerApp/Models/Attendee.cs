using System.ComponentModel.DataAnnotations;

namespace WeddingPlannerApp.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Role")]
        public byte RoleId { get; set; }

        public Role Role { get; set; }
    }
}