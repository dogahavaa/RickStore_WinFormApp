using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickStock_WindowsFormApp.Models
{
    public class Dealer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DealerTypeID { get; set; }
        [ForeignKey("DealerTypeID")]
        public virtual DealerType DealerType { get; set; }
        public string DealerTypeKey { get; set; }
        public string Website { get; set; }
        public bool IsActive { get; set; }
    }
}
