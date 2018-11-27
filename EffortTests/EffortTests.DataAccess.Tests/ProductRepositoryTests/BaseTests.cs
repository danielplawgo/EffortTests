using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffortTests.DataAccess.Tests.ProductRepositoryTests
{
    public class BaseTests : RepositoryTests
    {
        protected ProductRepository Create(string path = null)
        {
            var context = CreateContext(path);

            return new ProductRepository(new Lazy<DataContext>(() => context));
        }
    }
}
