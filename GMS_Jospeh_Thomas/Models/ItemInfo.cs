using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS_Jospeh_Thomas.Models
{
    public class ItemInfo
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose a category.")]
        public ItemCategory Category { get; set; }

        [Required(ErrorMessage = "Purchase date is required.")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 1000, ErrorMessage = "Quantity must be between 1 and 1,000.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(typeof(decimal), "0.01", "1000", ErrorMessage = "Price must be between 0.01 and 1,000.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
