using System.ComponentModel.DataAnnotations;

namespace ClaimsPortal.Models.Entities
{
    public class Claim
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int HoursWorked { get; set; }

        [Required]
        public int Rate { get; set; }

        public int Total { get; set;}

        public string Status { get; set; }

    }
}
