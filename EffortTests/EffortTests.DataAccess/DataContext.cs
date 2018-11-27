using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EffortTests.Models;

namespace EffortTests.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("Name=DefaultConnection")
        {
        }

        public DataContext(DbConnection connection)
            : base(connection, true)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
