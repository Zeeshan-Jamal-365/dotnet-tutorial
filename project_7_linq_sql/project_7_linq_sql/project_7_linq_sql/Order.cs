using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_7_linq_sql
{
    public class Orders
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public double ItemRate { get; set; }
        public double Quantity { get; set; }
    }
}