using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WhereHouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WhereHouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WhereHouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WhereHouseAddress { get; set; }   

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
