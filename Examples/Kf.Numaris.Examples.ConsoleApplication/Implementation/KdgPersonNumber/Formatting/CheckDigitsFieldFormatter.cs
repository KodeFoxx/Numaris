﻿using System;
using Kf.Numaris.Api.Formatting.Fields;
using Kf.Numaris.Examples.ConsoleApplication.Implementation.KdgPersonNumber.Specification;
using Kf.Numaris.Examples.ConsoleApplication.Implementation.KdgPersonNumber.Specification.Fields;

namespace Kf.Numaris.Examples.ConsoleApplication.Implementation.KdgPersonNumber.Formatting
{
    public sealed class CheckDigitsFieldFormatter : FieldFormatter<CheckDigitsFieldSpecification, KdgPersonNumberSpecification>
    {
        private readonly int _maxLength = 2;
        private char _paddingCharacter = '0';

        public override string Format(string input)
        {
            if (input.Length == _maxLength)
                return input;

            if (input.Length > _maxLength)
                return input.Substring(0, _maxLength);

            return $"{new String(_paddingCharacter, _maxLength - input.Length)}{input}";
        }
    }
}
