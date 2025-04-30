using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickStock_WindowsFormApp.Models
{
    public class ProductVariant
    {
        public int ID { get; set; }
        public int VariantID { get; set; }
        [ForeignKey("VariantID")]
        public virtual Variant Variant { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public int Stock { get; set; }
    }
}
