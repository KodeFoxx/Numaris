﻿using System.Collections.Generic;
using Kf.Numaris.Api.Formatting.Fields;
using Kf.Numaris.Api.Formatting.Numbers;
using Kf.Numaris.Api.Parsing.Parsers;
using Kf.Numaris.Api.Specifications.Field;
using Kf.Numaris.Examples.ConsoleApplication.Implementation.KdgPersonNumber.Specification;

namespace Kf.Numaris.Examples.ConsoleApplication.Implementation.KdgPersonNumber.Formatting
{
    public sealed class KdgPersonNumberFormatter : NumberFormatter<KdgPersonNumberSpecification>
    {
        public KdgPersonNumberFormatter(
            IEnumerable<IFieldFormatter<KdgPersonNumberSpecification>> fieldFormatters,
            IEnumerable<IFieldSpecification<KdgPersonNumberSpecification>> fieldSpecifications,
            IStringParser<KdgPersonNumberSpecification> stringParser)
            : base(fieldFormatters, fieldSpecifications, stringParser) { }

        public override string Format(string[] input)
            => $"{OrderedFieldFormatters[0].Format(input[0])}-{OrderedFieldFormatters[1].Format(input[1])}";
    }
}
