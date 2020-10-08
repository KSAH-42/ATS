using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Client
{
	internal static class ValueFilter
	{
		public static string Filter( string value )
		{
			return value ?? string.Empty;
		}

		public static int Filter( int value , int minimum )
		{
			return value > minimum ? value : minimum;
		}
	}
}
