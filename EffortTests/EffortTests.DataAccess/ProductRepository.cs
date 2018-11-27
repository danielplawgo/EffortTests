using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EffortTests.Models;

namespace EffortTests.DataAccess
{
    public class ProductRepository
    {
        private Lazy<DataContext> _db;

        protected DataContext Db
        {
            get { return _db.Value; }
        }

        public ProductRepository(Lazy<DataContext> db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetAllActive()
        {
            return Db.Products
                .Where(p => p.IsActive)
                .ToList();
        }
    }
}
