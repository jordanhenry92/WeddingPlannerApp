using System.ComponentModel.DataAnnotations;

namespace WeddingPlannerApp.Models
{
    public class Role
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}