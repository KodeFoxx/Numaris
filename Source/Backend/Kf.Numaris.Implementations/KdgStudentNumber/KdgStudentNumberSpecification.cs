﻿using Kf.Numaris.Api.Parsing;
using Kf.Numaris.Api.Specifications.Number;

namespace Kf.Numaris.Implementations.KdgStudentNumber
{
    public sealed class KdgStudentNumberSpecification : NumberSpecification<KdgStudentNumberSpecification>
    {
        public KdgStudentNumberSpecification(INumberParser<KdgStudentNumberSpecification> numberParser)
            : base(numberParser)
        {
        }
    }
}