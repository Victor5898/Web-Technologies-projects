using eUseControl.Domain.Entities.Session;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBModel.Seed
{
    public class SessionContext : DbContext
    {
        public SessionContext() : base("name = eUseControl")
        {

        }

        public virtual DbSet<DbSession> Sessions { get; set; }
    }
}
