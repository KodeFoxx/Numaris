﻿using Kf.Numaris.Api.Common;
using Kf.Numaris.Api.Tests.Specifications.Fields;
using Xunit;

namespace Kf.Numaris.Api.Tests.Specifications.Numbers
{
    public class NumberSpecificationTests
    {
        [Fact]
        public void Shows_correct_identifier()
        {
            var expected = new Identifier(typeof(FakeFieldOneSpecification));
            var sut = new FakeFieldOneSpecification();
            Assert.Equal(expected, sut.Identifier);
        }
    }
}
