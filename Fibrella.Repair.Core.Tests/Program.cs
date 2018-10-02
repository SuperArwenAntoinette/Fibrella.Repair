using Fibrella.Repair.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibrella.Repair.Core.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RepairService x = new RepairService();
            //x.GetAllRepairOrders();
            
            x.CreateRepairOrder(new Fibrella.Core.Data.RepairOrder { 
                ReceiptDate = DateTime.Now.Date,
                CustomerName = "Kangkong Service Test"
            });            

        }
    }
}
