using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.Product;
using System.Reflection.Emit;

namespace eUseControl.BusinessLogic.DBModel.Seed
{
    public class ProductContext: DbContext
    {
        public ProductContext() : base("name = eUseControl")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProductContext>());
        }

        public virtual DbSet<PDbTable> Products { get; set; }
    }
}
