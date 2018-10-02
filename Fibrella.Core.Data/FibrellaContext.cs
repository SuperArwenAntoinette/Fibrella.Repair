using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibrella.Core.Data
{
    public class FibrellaContext : DbContext
    {
        public ObjectContext Context
        {
            get { return ((IObjectContextAdapter)this).ObjectContext; }
        }

        public FibrellaContext()
            : base("FibrellaContext")
        {            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RepairOrder>();
            modelBuilder.Entity<RepairDetail>();

            //modelBuilder.Entity<Activity>()
                //.HasRequired(m => m.CreatedByUser)
                //.WithMany(u => u.CreatedByActivities)
                //.HasForeignKey(m => m.CreatedBy);

            //modelBuilder.Entity<ProductSubscription>().HasRequired(o => o.Product).WithMany(o => o.ProductSubscriptions).HasForeignKey(o => o.ProductID).WillCascadeOnDelete(false);
            
            //modelBuilder.Entity<Request>()
            //    .HasOptional(m => m.ProcessedByUser)
            //    .WithMany(t => t.ProcessedByRequest)
            //    .HasForeignKey(m => m.ProcessedBy)
            //    .WillCascadeOnDelete(false);
        }

        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<RepairDetail> RepairDetails { get; set; }
        //public DbSet<ConfirmationOfServicesProduct> ConfirmationOfServicesProducts { get; set; }

    }
}
