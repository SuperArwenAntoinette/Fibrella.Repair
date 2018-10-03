using Fibrella.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibrella.Repair.Service
{
    public class RepairService
    {
        public RepairOrder GetRepairOrder(string searchString)
        {
            RepairOrder repair = new RepairOrder();
            using (FibrellaContext context = new FibrellaContext())
            {
                long convertedSmne = Convert.ToInt64(searchString);
                repair = context.RepairOrders.FirstOrDefault(z => z.SMNE == convertedSmne);
            }
            return repair;
        }

        public IList<RepairOrder> GetAllRepairOrders()
        {
            IList<RepairOrder> repairList = new List<RepairOrder>();
            using (FibrellaContext context = new FibrellaContext())
            {
                repairList = context.RepairOrders.ToList();
            }
            return repairList;
        }

        public void CreateRepairOrder(RepairOrder repairOrder)
        {
            using (FibrellaContext context = new FibrellaContext())
            {
                context.RepairOrders.Add(repairOrder);
                context.SaveChanges();
            }
        }
    }
}
