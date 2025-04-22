using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickStock_WindowsFormApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Kategori adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Kategori adı en fazla 100 karakter olabilir.")]
        public string Name { get; set; }
        public int? UpCategoryID { get; set; }
        [ForeignKey("UpCategoryID")]
        public virtual Category UpCategory { get; set; }
        [InverseProperty("UpCategory")]
        public virtual ICollection<Category> SubCategories { get; set; } = new List<Category>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
