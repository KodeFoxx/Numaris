﻿using Kf.Numaris.Api.Specifications.Field;
using Kf.Numaris.Api.Tests.Specifications.Numbers;

namespace Kf.Numaris.Api.Tests.Specifications.Fields
{
    public sealed class FakeFieldOneSpecification : FieldSpecification<FakeNumberSpecification>
    {
        public override int Order => 1;
    }
}
