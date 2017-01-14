using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEntityConfig
    {
        void SetupEntity(DbModelBuilder modelBuilder);
    }
}
