﻿using System.Collections.Generic;
using Kf.Numaris.Api.Common;
using Kf.Numaris.Api.Specifications.Numbers;
using Kf.Numaris.Api.Validation.Results;

namespace Kf.Numaris.Api.Validation.Fields
{
    public interface IFieldValidator<TNumberSpecification>
        where TNumberSpecification : INumberSpecification
    {
        Identifier Identifier { get; }
        Identifier FieldSpecificationIdentifier { get; }
        IReadOnlyList<Identifier> FieldDependencyIdentifiers { get; }
        bool HasFieldDependencies { get; }
        IPartialValidationResult Validate();
    }
}