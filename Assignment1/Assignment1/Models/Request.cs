using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public enum EquipmentType { Laptop, Phone, Tablet, Another }

    public class Request
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Role { get; set; }
        [Required]
        public EquipmentType Equipment { get; set; }
        [Required]
        public string? RequestDetails { get; set; }
        [Range(1, 30)]
        public int Duration { get; set; }
    }

}
