﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Functional.Tests.Unions
{
    public class UnionTests
    {
		public class Match
		{
			[Fact]
			public void EightValueMatchOne()
				=> EightDefinition
					.Create((byte)10)
					.Value()
					.Match(_ => true, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false)
					.Should()
					.BeTrue();
		}
    }

	public class OneDefinition : UnionDefinition<OneDefinition, byte> { }

	public class TwoDefinition : UnionDefinition<EightDefinition, byte, sbyte> { }

	public class ThreeDefinition : UnionDefinition<EightDefinition, byte, sbyte, ushort> { }

	public class FourDefinition : UnionDefinition<EightDefinition, byte, sbyte, ushort, short> { }

	public class FiveDefinition : UnionDefinition<EightDefinition, byte, sbyte, ushort, short, uint> { }

	public class SixDefinition : UnionDefinition<EightDefinition, byte, sbyte, ushort, short, uint, int> { }

	public class SevenDefinition : UnionDefinition<EightDefinition, byte, sbyte, ushort, short, uint, int, ulong> { }

	public class EightDefinition : UnionDefinition<EightDefinition, byte, sbyte, ushort, short, uint, int, ulong, long> { }
}
