using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibrella.Core.Data
{
    [Table("RepairDetail")]
    public class RepairDetail
    {        
        [Key]
        public long RepairDetailId { get; set; }
        public long RepairOrderId { get; set; }
        
        [StringLength(50, ErrorMessage = "Customer Name should max 50 characters.")]
        public string ItemNumber { get; set; }

        [StringLength(50, ErrorMessage = "Parts code should max 50 characters.")]
        public string PartsCode { get; set; }

        public decimal? Cost { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? SubTotal { get; set; }
    }
}
