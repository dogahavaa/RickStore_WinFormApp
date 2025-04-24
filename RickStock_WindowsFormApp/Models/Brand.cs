using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickStock_WindowsFormApp.Models
{
    public class Brand
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Marka adı zorunludur.")]
        [Index(IsUnique = true)]
        [StringLength(100, ErrorMessage = "Marka adı en fazla 100 karakter olabilir.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Logo URL en fazla 200 karakter olabilir.")]
        public string Logo { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public virtual ICollection<Product> Products { get; set; }
    }
}
