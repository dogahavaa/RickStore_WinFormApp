using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickStock_WindowsFormApp.Models
{
    public class Variant
    {
        public int ID { get; set; }
        public string VariantType { get; set; }
        public string VariantValue { get; set; }
        public virtual List<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
    }
}
