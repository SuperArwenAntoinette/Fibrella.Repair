using Fibrella.Core.Data;
using Fibrella.Repair.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibrella.Repair.Core
{
    public class RepairCenter
    {
        //accept repair
        //check repair status by SMNE

        public RepairOrder CheckStatus(string searchString)
        {
            RepairService rs = new RepairService();
            var result = rs.GetRepairOrder(searchString);
            return result;
        }
    }
}
