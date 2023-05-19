using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MasterDetails.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required] 
        [DataType(DataType.Date)]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }=DateTime.Now.Date;
        [Required]
        [Display(Name = "Purchase Code")]
        public string PurchaseCode { get; set; }="TS"+Dat
        [Display(Name = "Supplier")]
        public int SupplierId { get;set; }
        public Supplier Supplier { get; set; }
        [Display(Name = "Total Amount")]
        public double? TotalAmont { get; set; }
        [Display(Name = "Discount Amount")]
        public double? DiscountAmont { get; set; }
        [Display(Name = "Discount Persent")]
        public double? DiscountPersent { get; set; }
    }
}
