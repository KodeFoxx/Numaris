﻿using Kf.Numaris.Api.Common;
using Kf.Numaris.Api.Specifications.Numbers;

namespace Kf.Numaris.Api.Specifications.Field
{
    public abstract class FieldSpecification<TNumberSpecification> : IFieldSpecification<TNumberSpecification>
        where TNumberSpecification : INumberSpecification
    {
        public Identifier Identifier
            => Identifier.For<IFieldSpecification<TNumberSpecification>>(GetType());

        public Identifier NumberSpecificationIdentifier
            => Identifier.For<INumberSpecification>(typeof(TNumberSpecification));

        public abstract int Order { get; }
    }
}
