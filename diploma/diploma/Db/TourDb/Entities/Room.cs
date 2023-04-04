using System.ComponentModel.DataAnnotations;

namespace diploma.Db.Tour.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? NumberOfGuests { get; set; }
        [Required]
        public string? HotelBuilding { get; set; }
        [Required]
        public string? WindowView { get; set; }
    }
}
