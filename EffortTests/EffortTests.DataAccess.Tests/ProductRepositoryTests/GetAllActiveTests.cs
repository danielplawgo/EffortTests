using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace EffortTests.DataAccess.Tests.ProductRepositoryTests
{
    public class GetAllActiveTests : BaseTests
    {
        [Fact]
        public void Return_Only_Active_Products()
        {
            var repository = Create();

            var products = repository.GetAllActive();

            products.Should().NotBeNull();
            products.Count().Should().Be(9);
            products.Should().OnlyContain(p => p.IsActive);
        }

        [Fact]
        public void Return_Empty_Collection()
        {
            var repository = Create(@"ProductRepositoryTests\Data\NoActiveProducts");

            var products = repository.GetAllActive();

            products.Should().NotBeNull();
            products.Count().Should().Be(0);
        }
    }
}
