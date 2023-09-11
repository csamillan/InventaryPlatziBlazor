using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class InOutEntity
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set;}

        [Required]
        public int Quantity { get; set;}

        [Required]
        public bool IsInPut { get; set;}

        public string StorageId { get; set;}
        public StorageEntity Storages { get; set;}
    }
}
