using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit;

namespace Ploeh.Samples.CoffeeMaker.UnitTests
{
    public class TestConventionsAttribute : AutoDataAttribute
    {
        public TestConventionsAttribute()
            : base(new Fixture().Customize(new AutoMoqCustomization()))
        {
        }
    }
}
