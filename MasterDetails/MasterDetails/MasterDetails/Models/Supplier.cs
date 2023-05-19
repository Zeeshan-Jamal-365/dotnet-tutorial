using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MasterDetails.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string SupplierName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Email")]
        public string SupplierEmail { get; set; }

        [Display(Name = "Phone")]
        public string SupplierPhone { get; set;}

        [Display(Name = "Address")]
        public string SupplierAddress { get; set;}
         
    }
}
