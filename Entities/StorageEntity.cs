using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuanity { get; set; }

        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }  

        public string WareHouseId { get; set; }
        public WareHouseEntity WareHouse { get; set; }

        public ICollection<InOutEntity> InOuts { get; set; }
    }
}
