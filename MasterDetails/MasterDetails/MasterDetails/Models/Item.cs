using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MasterDetails.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name="Item Name")]
        public string Name { get; set; }

        [Display(Name= "Item Code")]
        public string ItemCode { get; set; }
        public string Description { get; set; }
    }
}
