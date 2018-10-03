using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibrella.Core.Data
{
    [Table("RepairOrder")]
    public class RepairOrder
    {
        [Key]
        public long RepairOrderId { get; set; }

        public long? SMNE { get; set; }

        public DateTime ReceiptDate { get; set; }

        [StringLength(100,ErrorMessage="Customer Name should max 100 characters.")]
        public string CustomerName { get; set; }

        [StringLength(100,ErrorMessage="Customer Address should max 200 characters.")]
        public string CustomerAddress { get; set; }
        
        [StringLength(15,ErrorMessage="Customer Contact No. should max 15 characters.")]
        public string CustomerContactNo { get; set; }

        public bool? IsWarrantyRepair { get; set; }

        public bool? IsDone { get; set; }
    }
}

