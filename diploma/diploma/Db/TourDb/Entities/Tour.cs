using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diploma.Db.Tour.Entities
{
    public class Tour
    {
        [Key]
        public int Id { get; set; }
        public string? TourName { get; set; }
        public string? TourDescription { get; set; }
        public DateTime TourTimeStart { get; set; }
        public DateTime TourTimeEnd { get; set; }
        [ForeignKey("Id")]
        public virtual Country? Country { get; set;}
        [ForeignKey("Id")]
        public virtual City? City { get; set; }
        [ForeignKey("Id")]
        public virtual Hotel? Hotel { get; set; }
    }
}
