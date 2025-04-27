using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickStock_WindowsFormApp.Models
{
    public class DealerType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
        public virtual ICollection<Dealer> Dealers { get; set; } = new List<Dealer>();
    }
}
