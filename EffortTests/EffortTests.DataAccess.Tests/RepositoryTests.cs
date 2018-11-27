using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Effort;
using Effort.DataLoaders;

namespace EffortTests.DataAccess.Tests
{
    public class RepositoryTests
    {
        protected DataContext CreateContext(string path = null)
        {
            IDataLoader loader = new CsvDataLoader(path ?? "Data");

            return new DataContext(DbConnectionFactory.CreateTransient(loader));
        }
    }
}
